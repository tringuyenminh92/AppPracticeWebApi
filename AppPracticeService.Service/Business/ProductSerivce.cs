//***********************************************************************
//
//	Created By: Nguyen Minh Tri
//	Created Date: 08-08-2015
//	Description: Add comment header,
//
//	Modified By: Nguyen Minh Tri
//	Modified Date: 09-08-2015
//	Description:
//
//***********************************************************************

using AppPracticeService.Data;
using AppPracticeService.Pattern.Repositories;
using AppPracticeService.Pattern.UnitOfWork;
using AppPracticeService.Service.IBusiness;

namespace AppPracticeService.Service.Business
{
    public class ProductSerivce:IProductService
    {

        private readonly IRepositoryAsync<T_Product> _iRepositoryAsync;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly ISpContext _spContext;

        public ProductSerivce(IRepositoryAsync<T_Product>  iRepositoryAsync, IUnitOfWorkAsync unitOfWorkAsync, ISpContext spContext)
        {
            _iRepositoryAsync = iRepositoryAsync;
            _unitOfWorkAsync = unitOfWorkAsync;
            _spContext = spContext;
        }

    }
}
