using System;
using System.Transactions;
using PostSharp.Aspects;

namespace Common.Aspects.Postsharp.TransActionAspectScope
{
    [Serializable]
    public class TransActionAspectScope:OnMethodBoundaryAspect
    {
        private TransactionScopeOption _transactionScopeOption;
        public TransActionAspectScope(TransactionScopeOption transactionScopeOption)
        {
            _transactionScopeOption = transactionScopeOption;
        }
        public TransActionAspectScope()
        {

        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_transactionScopeOption);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
