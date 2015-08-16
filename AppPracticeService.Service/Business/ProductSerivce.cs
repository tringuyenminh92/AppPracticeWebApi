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

using System;
using System.Linq;
using AppPracticeService.Data;
using AppPracticeService.Helpers;
using AppPracticeService.Models;
using AppPracticeService.Pattern.Repositories;
using AppPracticeService.Pattern.UnitOfWork;
using AppPracticeService.Service.IBusiness;
using AutoMapper;
using log4net;

namespace AppPracticeService.Service.Business
{
    public class ProductSerivce : IProductService
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly bool IsErrorEnabled = Logger.IsErrorEnabled;

        private readonly IRepositoryAsync<T_Product> _iRepositoryAsync;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly ISpContext _spContext;

        public ProductSerivce(IRepositoryAsync<T_Product> iRepositoryAsync, IUnitOfWorkAsync unitOfWorkAsync, ISpContext spContext)
        {
            _iRepositoryAsync = iRepositoryAsync;
            _unitOfWorkAsync = unitOfWorkAsync;
            _spContext = spContext;
        }

        public ResultModel AddProduct(ProductModel productModel)
        {
            try
            {
                ResultModel rs;
                if (!_iRepositoryAsync.Query(p => p.Code == productModel.Code).Select().Any())
                {
                    Mapper.CreateMap<PictureProductModel, T_Picture>();
                    Mapper.CreateMap<ProductModel, T_Product>();
                    _iRepositoryAsync.Insert(Mapper.Map<ProductModel, T_Product>(productModel));
                    _unitOfWorkAsync.SaveChanges();
                    rs = new ResultModel
                    {
                        Message = string.Format("Adding new product {0}-{1} success!", productModel.Name, productModel.Code),
                        IsError = true
                    };
                }
                else
                {
                    rs = new ResultModel
                      {
                          Message = string.Format("Exist product {0} in system!", productModel.Code),
                          IsError = false
                      };
                }
                return rs;
            }
            catch (Exception ex)
            {
                if (IsErrorEnabled)
                {
                    Logger.Error(string.Format("productModel: {0}", LogHelper.ConvertObjectDataToString(productModel)), ex);
                }
                return new ResultModel { Message = ex.InnerException.Message, IsError = true };
            }
        }

    }
}
