using GopiVemuriMVC.BOs;
using GopiVemuriMVC.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GopiVemuriMVC.Models;
using GopiVemuriMVC.AppDbContext;
using Microsoft.ApplicationBlocks.Data;

namespace GopiVemuriMVC.UserDLs
{
    public class UsersDL
    {

        #region"Register User                   "
        public ResponseBO<UserBO> RegisterUserInsertUpdate(LoginMDL objUserBO)
        {
            ResponseBO<UserBO> Resp = new ResponseBO<UserBO>();

            try
            {

                SqlParameter[] objParams = new SqlParameter[5];
                objParams = SqlHelperParameterCache.GetSpParameterSet(ConstantsBO.DBConnection, "dbo.GopiVemuriUser_Register");

               

                if (!string.IsNullOrEmpty(objUserBO.UserName))
                    objParams[0].Value = objUserBO.UserName;
                else
                    objParams[0].Value = DBNull.Value;

                if (!string.IsNullOrEmpty(objUserBO.UserPassword))
                    objParams[1].Value = objUserBO.UserPassword;
                else
                    objParams[1].Value = DBNull.Value;

                if (!string.IsNullOrEmpty(objUserBO.Email))
                    objParams[2].Value = objUserBO.Email;
                else
                    objParams[2].Value = DBNull.Value;


                objParams[3].Value = DBNull.Value;
                objParams[4].Value = DBNull.Value;


                SqlHelper.ExecuteNonQuery(ConstantsBO.DBConnection, CommandType.StoredProcedure, "dbo.GopiVemuriUser_Register", objParams);

                if (objParams[3].Value != null)
                    Resp.RID = Convert.ToInt16(objParams[3].Value);

                if (objParams[4].Value != null)
                    Resp.MessageCode = objParams[4].Value.ToString();


                if (Resp.RID == 0)
                {
                    Resp.OperationStatus = OperationStatus.Success;
                }
            }
            catch (Exception ex)
            {
                Resp.OperationStatus = OperationStatus.Failure;
                Resp.MessageCode = "UserRegsitrationFailed";
                Resp.RID = 1;
                throw ex;
            }
            return Resp;
        }

        public ResponseBO<UserBO> RegisterUser(LoginMDL objUserBO)
        {
            ResponseBO<UserBO> Resp = new ResponseBO<UserBO>();

            try
            {
                GopiDbContext dbcontext = new GopiDbContext();
                UserBO ExtUser = dbcontext.UserBOs.Get(A => A.UserName == objUserBO.UserName || A.Email == objUserBO.Email).FirstOrDefault();
                if (ExtUser != null)
                {
                    Resp.OperationStatus = OperationStatus.Failure;
                    Resp.MessageCode = "EmailAlreadyTaken";
                    Resp.RID = ExtUser.UserID;
                }
                else if (ExtUser != null)
                {
                    Resp.OperationStatus = OperationStatus.Success;
                    Resp.RID = ExtUser.UserID;
                }
                else
                {
                    Resp.OperationStatus = OperationStatus.Success;
                    Resp.RID = 0;
                }

            }
            catch (Exception EX)
            {
                throw;
            }
            return Resp;
        }


        #endregion

    }
}