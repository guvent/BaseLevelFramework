using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.MicroServices.KPSService;
using Business.Utilities.ValidationRules.FluentValidation;
using Common.Aspects.Postsharp.FluentValidationAspects;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MemberManager:IMemberService
    {
        private IMemberDal _memberDal;
        private IKPSService _kpsService;

        public MemberManager(IMemberDal memberDal, IKPSService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }
        
        [FluentValidatorAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExist(member);

            CheckIfMemberValid(member);

            _memberDal.Add(member);
        }

        private void CheckIfMemberValid(Member member)
        {
            if (_kpsService.ValidateMember(member) == false)
            {
                throw new Exception("Kullanıcı doğrulama geçersiz!");
            }
        }

        private void CheckIfMemberExist(Member member)
        {
            if (_memberDal.Get(m => m.TCNO == member.TCNO) != null)
            {
                throw new Exception("Kullanıcı kaydı zaten var!");
            }
        }
    }
}
