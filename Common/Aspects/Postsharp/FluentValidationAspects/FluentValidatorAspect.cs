using System;
using System.Linq;
using Common.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;

namespace Common.Aspects.Postsharp.FluentValidationAspects
{
    [Serializable]
    public class FluentValidatorAspect:OnMethodBoundaryAspect
    {
        Type _validatorType;

        public FluentValidatorAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidationTool.FluentValidate(validator, entity);
            }
        }


    }
}
