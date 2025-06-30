// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkyida_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增/更新角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddOrUpdateRoleMembersRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddOrUpdateRoleMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddOrUpdateRoleMembersResponse
        /// </returns>
        public BatchAddOrUpdateRoleMembersResponse BatchAddOrUpdateRoleMembersWithOptions(BatchAddOrUpdateRoleMembersRequest request, BatchAddOrUpdateRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersInfo))
            {
                body["membersInfo"] = request.MembersInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddOrUpdateRoleMembers",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddOrUpdateRoleMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增/更新角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddOrUpdateRoleMembersRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddOrUpdateRoleMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddOrUpdateRoleMembersResponse
        /// </returns>
        public async Task<BatchAddOrUpdateRoleMembersResponse> BatchAddOrUpdateRoleMembersWithOptionsAsync(BatchAddOrUpdateRoleMembersRequest request, BatchAddOrUpdateRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersInfo))
            {
                body["membersInfo"] = request.MembersInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddOrUpdateRoleMembers",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddOrUpdateRoleMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增/更新角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddOrUpdateRoleMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddOrUpdateRoleMembersResponse
        /// </returns>
        public BatchAddOrUpdateRoleMembersResponse BatchAddOrUpdateRoleMembers(BatchAddOrUpdateRoleMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddOrUpdateRoleMembersHeaders headers = new BatchAddOrUpdateRoleMembersHeaders();
            return BatchAddOrUpdateRoleMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增/更新角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddOrUpdateRoleMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddOrUpdateRoleMembersResponse
        /// </returns>
        public async Task<BatchAddOrUpdateRoleMembersResponse> BatchAddOrUpdateRoleMembersAsync(BatchAddOrUpdateRoleMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddOrUpdateRoleMembersHeaders headers = new BatchAddOrUpdateRoleMembersHeaders();
            return await BatchAddOrUpdateRoleMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRoleMembersRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteRoleMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRoleMembersResponse
        /// </returns>
        public BatchDeleteRoleMembersResponse BatchDeleteRoleMembersWithOptions(BatchDeleteRoleMembersRequest request, BatchDeleteRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIds))
            {
                body["memberIds"] = request.MemberIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteRoleMembers",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRoleMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRoleMembersRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteRoleMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRoleMembersResponse
        /// </returns>
        public async Task<BatchDeleteRoleMembersResponse> BatchDeleteRoleMembersWithOptionsAsync(BatchDeleteRoleMembersRequest request, BatchDeleteRoleMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIds))
            {
                body["memberIds"] = request.MemberIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteRoleMembers",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRoleMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRoleMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRoleMembersResponse
        /// </returns>
        public BatchDeleteRoleMembersResponse BatchDeleteRoleMembers(BatchDeleteRoleMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteRoleMembersHeaders headers = new BatchDeleteRoleMembersHeaders();
            return BatchDeleteRoleMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteRoleMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteRoleMembersResponse
        /// </returns>
        public async Task<BatchDeleteRoleMembersResponse> BatchDeleteRoleMembersAsync(BatchDeleteRoleMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteRoleMembersHeaders headers = new BatchDeleteRoleMembersHeaders();
            return await BatchDeleteRoleMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateFormDataRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrUpdateFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateFormDataResponse
        /// </returns>
        public CreateOrUpdateFormDataResponse CreateOrUpdateFormDataWithOptions(CreateOrUpdateFormDataRequest request, CreateOrUpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/insertOrUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateFormDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateFormDataRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrUpdateFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateFormDataResponse
        /// </returns>
        public async Task<CreateOrUpdateFormDataResponse> CreateOrUpdateFormDataWithOptionsAsync(CreateOrUpdateFormDataRequest request, CreateOrUpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/insertOrUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateFormDataResponse
        /// </returns>
        public CreateOrUpdateFormDataResponse CreateOrUpdateFormData(CreateOrUpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
            return CreateOrUpdateFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateFormDataResponse
        /// </returns>
        public async Task<CreateOrUpdateFormDataResponse> CreateOrUpdateFormDataAsync(CreateOrUpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
            return await CreateOrUpdateFormDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMatrixDataByRowIdsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMatrixDataByRowIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMatrixDataByRowIdsResponse
        /// </returns>
        public DeleteMatrixDataByRowIdsResponse DeleteMatrixDataByRowIdsWithOptions(DeleteMatrixDataByRowIdsRequest request, DeleteMatrixDataByRowIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                body["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowIds))
            {
                body["rowIds"] = request.RowIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMatrixDataByRowIds",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMatrixDataByRowIdsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMatrixDataByRowIdsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMatrixDataByRowIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMatrixDataByRowIdsResponse
        /// </returns>
        public async Task<DeleteMatrixDataByRowIdsResponse> DeleteMatrixDataByRowIdsWithOptionsAsync(DeleteMatrixDataByRowIdsRequest request, DeleteMatrixDataByRowIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                body["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowIds))
            {
                body["rowIds"] = request.RowIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMatrixDataByRowIds",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMatrixDataByRowIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMatrixDataByRowIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMatrixDataByRowIdsResponse
        /// </returns>
        public DeleteMatrixDataByRowIdsResponse DeleteMatrixDataByRowIds(DeleteMatrixDataByRowIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMatrixDataByRowIdsHeaders headers = new DeleteMatrixDataByRowIdsHeaders();
            return DeleteMatrixDataByRowIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMatrixDataByRowIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMatrixDataByRowIdsResponse
        /// </returns>
        public async Task<DeleteMatrixDataByRowIdsResponse> DeleteMatrixDataByRowIdsAsync(DeleteMatrixDataByRowIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMatrixDataByRowIdsHeaders headers = new DeleteMatrixDataByRowIdsHeaders();
            return await DeleteMatrixDataByRowIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单组件别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentAliasListRequest
        /// </param>
        /// <param name="headers">
        /// GetFormComponentAliasListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentAliasListResponse
        /// </returns>
        public GetFormComponentAliasListResponse GetFormComponentAliasListWithOptions(string appType, string formUuid, GetFormComponentAliasListRequest request, GetFormComponentAliasListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormComponentAliasList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/component/alias/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentAliasListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单组件别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentAliasListRequest
        /// </param>
        /// <param name="headers">
        /// GetFormComponentAliasListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentAliasListResponse
        /// </returns>
        public async Task<GetFormComponentAliasListResponse> GetFormComponentAliasListWithOptionsAsync(string appType, string formUuid, GetFormComponentAliasListRequest request, GetFormComponentAliasListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormComponentAliasList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/component/alias/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentAliasListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单组件别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentAliasListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentAliasListResponse
        /// </returns>
        public GetFormComponentAliasListResponse GetFormComponentAliasList(string appType, string formUuid, GetFormComponentAliasListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentAliasListHeaders headers = new GetFormComponentAliasListHeaders();
            return GetFormComponentAliasListWithOptions(appType, formUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单组件别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentAliasListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentAliasListResponse
        /// </returns>
        public async Task<GetFormComponentAliasListResponse> GetFormComponentAliasListAsync(string appType, string formUuid, GetFormComponentAliasListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentAliasListHeaders headers = new GetFormComponentAliasListHeaders();
            return await GetFormComponentAliasListWithOptionsAsync(appType, formUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单 ID 查询实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormDataByIDRequest
        /// </param>
        /// <param name="headers">
        /// GetFormDataByIDHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormDataByIDResponse
        /// </returns>
        public GetFormDataByIDResponse GetFormDataByIDWithOptions(string id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormDataByID",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormDataByIDResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单 ID 查询实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormDataByIDRequest
        /// </param>
        /// <param name="headers">
        /// GetFormDataByIDHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormDataByIDResponse
        /// </returns>
        public async Task<GetFormDataByIDResponse> GetFormDataByIDWithOptionsAsync(string id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormDataByID",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormDataByIDResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单 ID 查询实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormDataByIDRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormDataByIDResponse
        /// </returns>
        public GetFormDataByIDResponse GetFormDataByID(string id, GetFormDataByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
            return GetFormDataByIDWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单 ID 查询实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormDataByIDRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormDataByIDResponse
        /// </returns>
        public async Task<GetFormDataByIDResponse> GetFormDataByIDAsync(string id, GetFormDataByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
            return await GetFormDataByIDWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetInstanceByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceByIdResponse
        /// </returns>
        public GetInstanceByIdResponse GetInstanceByIdWithOptions(string id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instancesInfos/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceByIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetInstanceByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceByIdResponse
        /// </returns>
        public async Task<GetInstanceByIdResponse> GetInstanceByIdWithOptionsAsync(string id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instancesInfos/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceByIdResponse
        /// </returns>
        public GetInstanceByIdResponse GetInstanceById(string id, GetInstanceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
            return GetInstanceByIdWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceByIdResponse
        /// </returns>
        public async Task<GetInstanceByIdResponse> GetInstanceByIdAsync(string id, GetInstanceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
            return await GetInstanceByIdWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索流程实例 ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdListRequest
        /// </param>
        /// <param name="headers">
        /// GetInstanceIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdListResponse
        /// </returns>
        public GetInstanceIdListResponse GetInstanceIdListWithOptions(GetInstanceIdListRequest request, GetInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instanceIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索流程实例 ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdListRequest
        /// </param>
        /// <param name="headers">
        /// GetInstanceIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdListResponse
        /// </returns>
        public async Task<GetInstanceIdListResponse> GetInstanceIdListWithOptionsAsync(GetInstanceIdListRequest request, GetInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instanceIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索流程实例 ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdListResponse
        /// </returns>
        public GetInstanceIdListResponse GetInstanceIdList(GetInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
            return GetInstanceIdListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索流程实例 ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdListResponse
        /// </returns>
        public async Task<GetInstanceIdListResponse> GetInstanceIdListAsync(GetInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
            return await GetInstanceIdListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索条件获取流程表单实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesRequest
        /// </param>
        /// <param name="headers">
        /// GetInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesResponse
        /// </returns>
        public GetInstancesResponse GetInstancesWithOptions(GetInstancesRequest request, GetInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstances",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索条件获取流程表单实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesRequest
        /// </param>
        /// <param name="headers">
        /// GetInstancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesResponse
        /// </returns>
        public async Task<GetInstancesResponse> GetInstancesWithOptionsAsync(GetInstancesRequest request, GetInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstances",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索条件获取流程表单实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesResponse
        /// </returns>
        public GetInstancesResponse GetInstances(GetInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesHeaders headers = new GetInstancesHeaders();
            return GetInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据搜索条件获取流程表单实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesResponse
        /// </returns>
        public async Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesHeaders headers = new GetInstancesHeaders();
            return await GetInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限矩阵数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMatrixDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMatrixDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMatrixDetailByIdResponse
        /// </returns>
        public GetMatrixDetailByIdResponse GetMatrixDetailByIdWithOptions(GetMatrixDetailByIdRequest request, GetMatrixDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                query["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMatrixDetailById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMatrixDetailByIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限矩阵数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMatrixDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMatrixDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMatrixDetailByIdResponse
        /// </returns>
        public async Task<GetMatrixDetailByIdResponse> GetMatrixDetailByIdWithOptionsAsync(GetMatrixDetailByIdRequest request, GetMatrixDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                query["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMatrixDetailById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMatrixDetailByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限矩阵数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMatrixDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMatrixDetailByIdResponse
        /// </returns>
        public GetMatrixDetailByIdResponse GetMatrixDetailById(GetMatrixDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMatrixDetailByIdHeaders headers = new GetMatrixDetailByIdHeaders();
            return GetMatrixDetailByIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取权限矩阵数据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMatrixDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMatrixDetailByIdResponse
        /// </returns>
        public async Task<GetMatrixDetailByIdResponse> GetMatrixDetailByIdAsync(GetMatrixDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMatrixDetailByIdHeaders headers = new GetMatrixDetailByIdHeaders();
            return await GetMatrixDetailByIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色详情和成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetRoleDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleDetailByIdResponse
        /// </returns>
        public GetRoleDetailByIdResponse GetRoleDetailByIdWithOptions(GetRoleDetailByIdRequest request, GetRoleDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                query["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleDetailById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleDetailByIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色详情和成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetRoleDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleDetailByIdResponse
        /// </returns>
        public async Task<GetRoleDetailByIdResponse> GetRoleDetailByIdWithOptionsAsync(GetRoleDetailByIdRequest request, GetRoleDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                query["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleDetailById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleDetailByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色详情和成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleDetailByIdResponse
        /// </returns>
        public GetRoleDetailByIdResponse GetRoleDetailById(GetRoleDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleDetailByIdHeaders headers = new GetRoleDetailByIdHeaders();
            return GetRoleDetailByIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色详情和成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleDetailByIdResponse
        /// </returns>
        public async Task<GetRoleDetailByIdResponse> GetRoleDetailByIdAsync(GetRoleDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleDetailByIdHeaders headers = new GetRoleDetailByIdHeaders();
            return await GetRoleDetailByIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/新增矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndUpdateMatrixDataRequest
        /// </param>
        /// <param name="headers">
        /// SaveAndUpdateMatrixDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAndUpdateMatrixDataResponse
        /// </returns>
        public SaveAndUpdateMatrixDataResponse SaveAndUpdateMatrixDataWithOptions(SaveAndUpdateMatrixDataRequest request, SaveAndUpdateMatrixDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                body["dataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                body["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAndUpdateMatrixData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAndUpdateMatrixDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/新增矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndUpdateMatrixDataRequest
        /// </param>
        /// <param name="headers">
        /// SaveAndUpdateMatrixDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAndUpdateMatrixDataResponse
        /// </returns>
        public async Task<SaveAndUpdateMatrixDataResponse> SaveAndUpdateMatrixDataWithOptionsAsync(SaveAndUpdateMatrixDataRequest request, SaveAndUpdateMatrixDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                body["dataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixId))
            {
                body["matrixId"] = request.MatrixId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAndUpdateMatrixData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/resources/matrices/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAndUpdateMatrixDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/新增矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndUpdateMatrixDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAndUpdateMatrixDataResponse
        /// </returns>
        public SaveAndUpdateMatrixDataResponse SaveAndUpdateMatrixData(SaveAndUpdateMatrixDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndUpdateMatrixDataHeaders headers = new SaveAndUpdateMatrixDataHeaders();
            return SaveAndUpdateMatrixDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改/新增矩阵明细数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndUpdateMatrixDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAndUpdateMatrixDataResponse
        /// </returns>
        public async Task<SaveAndUpdateMatrixDataResponse> SaveAndUpdateMatrixDataAsync(SaveAndUpdateMatrixDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndUpdateMatrixDataHeaders headers = new SaveAndUpdateMatrixDataHeaders();
            return await SaveAndUpdateMatrixDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormDataRequest
        /// </param>
        /// <param name="headers">
        /// SaveFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveFormDataResponse
        /// </returns>
        public SaveFormDataResponse SaveFormDataWithOptions(SaveFormDataRequest request, SaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormDataRequest
        /// </param>
        /// <param name="headers">
        /// SaveFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveFormDataResponse
        /// </returns>
        public async Task<SaveFormDataResponse> SaveFormDataWithOptionsAsync(SaveFormDataRequest request, SaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveFormDataResponse
        /// </returns>
        public SaveFormDataResponse SaveFormData(SaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormDataHeaders headers = new SaveFormDataHeaders();
            return SaveFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveFormDataResponse
        /// </returns>
        public async Task<SaveFormDataResponse> SaveFormDataAsync(SaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormDataHeaders headers = new SaveFormDataHeaders();
            return await SaveFormDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例 ID 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataIdListRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataIdListResponse
        /// </returns>
        public SearchFormDataIdListResponse SearchFormDataIdListWithOptions(string appType, string formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataIdListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例 ID 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataIdListRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataIdListResponse
        /// </returns>
        public async Task<SearchFormDataIdListResponse> SearchFormDataIdListWithOptionsAsync(string appType, string formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例 ID 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataIdListResponse
        /// </returns>
        public SearchFormDataIdListResponse SearchFormDataIdList(string appType, string formUuid, SearchFormDataIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
            return SearchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例 ID 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataIdListResponse
        /// </returns>
        public async Task<SearchFormDataIdListResponse> SearchFormDataIdListAsync(string appType, string formUuid, SearchFormDataIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
            return await SearchFormDataIdListWithOptionsAsync(appType, formUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级检索条件查询表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataSecondGenerationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationResponse
        /// </returns>
        public SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationWithOptions(SearchFormDataSecondGenerationRequest request, SearchFormDataSecondGenerationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataSecondGeneration",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/advances/queryAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级检索条件查询表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataSecondGenerationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationResponse
        /// </returns>
        public async Task<SearchFormDataSecondGenerationResponse> SearchFormDataSecondGenerationWithOptionsAsync(SearchFormDataSecondGenerationRequest request, SearchFormDataSecondGenerationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataSecondGeneration",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/advances/queryAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级检索条件查询表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationResponse
        /// </returns>
        public SearchFormDataSecondGenerationResponse SearchFormDataSecondGeneration(SearchFormDataSecondGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
            return SearchFormDataSecondGenerationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级检索条件查询表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationResponse
        /// </returns>
        public async Task<SearchFormDataSecondGenerationResponse> SearchFormDataSecondGenerationAsync(SearchFormDataSecondGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
            return await SearchFormDataSecondGenerationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDatasRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDatasResponse
        /// </returns>
        public SearchFormDatasResponse SearchFormDatasWithOptions(SearchFormDatasRequest request, SearchFormDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicOrder))
            {
                body["dynamicOrder"] = request.DynamicOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDatas",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDatasResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDatasRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDatasHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDatasResponse
        /// </returns>
        public async Task<SearchFormDatasResponse> SearchFormDatasWithOptionsAsync(SearchFormDatasRequest request, SearchFormDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicOrder))
            {
                body["dynamicOrder"] = request.DynamicOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDatas",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDatasResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDatasResponse
        /// </returns>
        public SearchFormDatasResponse SearchFormDatas(SearchFormDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
            return SearchFormDatasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDatasResponse
        /// </returns>
        public async Task<SearchFormDatasResponse> SearchFormDatasAsync(SearchFormDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
            return await SearchFormDatasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起新的流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="headers">
        /// StartInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, StartInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessData))
            {
                body["processData"] = request.ProcessData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起新的流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="headers">
        /// StartInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, StartInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessData))
            {
                body["processData"] = request.ProcessData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起新的流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartInstanceHeaders headers = new StartInstanceHeaders();
            return StartInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起新的流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartInstanceHeaders headers = new StartInstanceHeaders();
            return await StartInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFormDataRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFormDataResponse
        /// </returns>
        public UpdateFormDataResponse UpdateFormDataWithOptions(UpdateFormDataRequest request, UpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestVersion))
            {
                body["useLatestVersion"] = request.UseLatestVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateFormDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFormDataRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFormDataResponse
        /// </returns>
        public async Task<UpdateFormDataResponse> UpdateFormDataWithOptionsAsync(UpdateFormDataRequest request, UpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestVersion))
            {
                body["useLatestVersion"] = request.UseLatestVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFormDataResponse
        /// </returns>
        public UpdateFormDataResponse UpdateFormData(UpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
            return UpdateFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFormDataResponse
        /// </returns>
        public async Task<UpdateFormDataResponse> UpdateFormDataAsync(UpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
            return await UpdateFormDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
