// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkyida_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0
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
        /// <para>生成登录态传递用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppLoginCodeGenRequest
        /// </param>
        /// <param name="headers">
        /// AppLoginCodeGenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppLoginCodeGenResponse
        /// </returns>
        public AppLoginCodeGenResponse AppLoginCodeGenWithOptions(AppLoginCodeGenRequest request, AppLoginCodeGenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullUrl))
            {
                query["fullUrl"] = request.FullUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTimestampStr))
            {
                body["signTimestampStr"] = request.SignTimestampStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
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
                Action = "AppLoginCodeGen",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/appLoginCodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppLoginCodeGenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成登录态传递用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppLoginCodeGenRequest
        /// </param>
        /// <param name="headers">
        /// AppLoginCodeGenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppLoginCodeGenResponse
        /// </returns>
        public async Task<AppLoginCodeGenResponse> AppLoginCodeGenWithOptionsAsync(AppLoginCodeGenRequest request, AppLoginCodeGenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullUrl))
            {
                query["fullUrl"] = request.FullUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTimestampStr))
            {
                body["signTimestampStr"] = request.SignTimestampStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
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
                Action = "AppLoginCodeGen",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/appLoginCodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppLoginCodeGenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成登录态传递用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppLoginCodeGenRequest
        /// </param>
        /// 
        /// <returns>
        /// AppLoginCodeGenResponse
        /// </returns>
        public AppLoginCodeGenResponse AppLoginCodeGen(AppLoginCodeGenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppLoginCodeGenHeaders headers = new AppLoginCodeGenHeaders();
            return AppLoginCodeGenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成登录态传递用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppLoginCodeGenRequest
        /// </param>
        /// 
        /// <returns>
        /// AppLoginCodeGenResponse
        /// </returns>
        public async Task<AppLoginCodeGenResponse> AppLoginCodeGenAsync(AppLoginCodeGenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppLoginCodeGenHeaders headers = new AppLoginCodeGenHeaders();
            return await AppLoginCodeGenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取指定表单实例ID列表对应的表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetFormDataByIdListRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetFormDataByIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetFormDataByIdListResponse
        /// </returns>
        public BatchGetFormDataByIdListResponse BatchGetFormDataByIdListWithOptions(BatchGetFormDataByIdListRequest request, BatchGetFormDataByIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedFormInstanceValue))
            {
                body["needFormInstanceValue"] = request.NeedFormInstanceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchGetFormDataByIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/ids/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFormDataByIdListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取指定表单实例ID列表对应的表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetFormDataByIdListRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetFormDataByIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetFormDataByIdListResponse
        /// </returns>
        public async Task<BatchGetFormDataByIdListResponse> BatchGetFormDataByIdListWithOptionsAsync(BatchGetFormDataByIdListRequest request, BatchGetFormDataByIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedFormInstanceValue))
            {
                body["needFormInstanceValue"] = request.NeedFormInstanceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchGetFormDataByIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/ids/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFormDataByIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取指定表单实例ID列表对应的表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetFormDataByIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetFormDataByIdListResponse
        /// </returns>
        public BatchGetFormDataByIdListResponse BatchGetFormDataByIdList(BatchGetFormDataByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetFormDataByIdListHeaders headers = new BatchGetFormDataByIdListHeaders();
            return BatchGetFormDataByIdListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取指定表单实例ID列表对应的表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetFormDataByIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetFormDataByIdListResponse
        /// </returns>
        public async Task<BatchGetFormDataByIdListResponse> BatchGetFormDataByIdListAsync(BatchGetFormDataByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetFormDataByIdListHeaders headers = new BatchGetFormDataByIdListHeaders();
            return await BatchGetFormDataByIdListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除指定的表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemovalByFormInstanceIdListRequest
        /// </param>
        /// <param name="headers">
        /// BatchRemovalByFormInstanceIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRemovalByFormInstanceIdListResponse
        /// </returns>
        public BatchRemovalByFormInstanceIdListResponse BatchRemovalByFormInstanceIdListWithOptions(BatchRemovalByFormInstanceIdListRequest request, BatchRemovalByFormInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteExpression))
            {
                body["executeExpression"] = request.ExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchRemovalByFormInstanceIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<BatchRemovalByFormInstanceIdListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除指定的表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemovalByFormInstanceIdListRequest
        /// </param>
        /// <param name="headers">
        /// BatchRemovalByFormInstanceIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRemovalByFormInstanceIdListResponse
        /// </returns>
        public async Task<BatchRemovalByFormInstanceIdListResponse> BatchRemovalByFormInstanceIdListWithOptionsAsync(BatchRemovalByFormInstanceIdListRequest request, BatchRemovalByFormInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteExpression))
            {
                body["executeExpression"] = request.ExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchRemovalByFormInstanceIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<BatchRemovalByFormInstanceIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除指定的表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemovalByFormInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRemovalByFormInstanceIdListResponse
        /// </returns>
        public BatchRemovalByFormInstanceIdListResponse BatchRemovalByFormInstanceIdList(BatchRemovalByFormInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRemovalByFormInstanceIdListHeaders headers = new BatchRemovalByFormInstanceIdListHeaders();
            return BatchRemovalByFormInstanceIdListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除指定的表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRemovalByFormInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRemovalByFormInstanceIdListResponse
        /// </returns>
        public async Task<BatchRemovalByFormInstanceIdListResponse> BatchRemovalByFormInstanceIdListAsync(BatchRemovalByFormInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRemovalByFormInstanceIdListHeaders headers = new BatchRemovalByFormInstanceIdListHeaders();
            return await BatchRemovalByFormInstanceIdListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSaveFormDataRequest
        /// </param>
        /// <param name="headers">
        /// BatchSaveFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSaveFormDataResponse
        /// </returns>
        public BatchSaveFormDataResponse BatchSaveFormDataWithOptions(BatchSaveFormDataRequest request, BatchSaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJsonList))
            {
                body["formDataJsonList"] = request.FormDataJsonList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepRunningAfterException))
            {
                body["keepRunningAfterException"] = request.KeepRunningAfterException;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchSaveFormData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/batchSave",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveFormDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSaveFormDataRequest
        /// </param>
        /// <param name="headers">
        /// BatchSaveFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSaveFormDataResponse
        /// </returns>
        public async Task<BatchSaveFormDataResponse> BatchSaveFormDataWithOptionsAsync(BatchSaveFormDataRequest request, BatchSaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJsonList))
            {
                body["formDataJsonList"] = request.FormDataJsonList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepRunningAfterException))
            {
                body["keepRunningAfterException"] = request.KeepRunningAfterException;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "BatchSaveFormData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/batchSave",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSaveFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSaveFormDataResponse
        /// </returns>
        public BatchSaveFormDataResponse BatchSaveFormData(BatchSaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSaveFormDataHeaders headers = new BatchSaveFormDataHeaders();
            return BatchSaveFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存表单实例数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSaveFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSaveFormDataResponse
        /// </returns>
        public async Task<BatchSaveFormDataResponse> BatchSaveFormDataAsync(BatchSaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSaveFormDataHeaders headers = new BatchSaveFormDataHeaders();
            return await BatchSaveFormDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将多条表单实例的指定表单组件更新成指定值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceIdRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFormDataByInstanceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceIdResponse
        /// </returns>
        public BatchUpdateFormDataByInstanceIdResponse BatchUpdateFormDataByInstanceIdWithOptions(BatchUpdateFormDataByInstanceIdRequest request, BatchUpdateFormDataByInstanceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEmpty))
            {
                body["ignoreEmpty"] = request.IgnoreEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestFormSchemaVersion))
            {
                body["useLatestFormSchemaVersion"] = request.UseLatestFormSchemaVersion;
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
                Action = "BatchUpdateFormDataByInstanceId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/components",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFormDataByInstanceIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将多条表单实例的指定表单组件更新成指定值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceIdRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFormDataByInstanceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceIdResponse
        /// </returns>
        public async Task<BatchUpdateFormDataByInstanceIdResponse> BatchUpdateFormDataByInstanceIdWithOptionsAsync(BatchUpdateFormDataByInstanceIdRequest request, BatchUpdateFormDataByInstanceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEmpty))
            {
                body["ignoreEmpty"] = request.IgnoreEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestFormSchemaVersion))
            {
                body["useLatestFormSchemaVersion"] = request.UseLatestFormSchemaVersion;
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
                Action = "BatchUpdateFormDataByInstanceId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/components",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFormDataByInstanceIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将多条表单实例的指定表单组件更新成指定值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceIdResponse
        /// </returns>
        public BatchUpdateFormDataByInstanceIdResponse BatchUpdateFormDataByInstanceId(BatchUpdateFormDataByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFormDataByInstanceIdHeaders headers = new BatchUpdateFormDataByInstanceIdHeaders();
            return BatchUpdateFormDataByInstanceIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将多条表单实例的指定表单组件更新成指定值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceIdResponse
        /// </returns>
        public async Task<BatchUpdateFormDataByInstanceIdResponse> BatchUpdateFormDataByInstanceIdAsync(BatchUpdateFormDataByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFormDataByInstanceIdHeaders headers = new BatchUpdateFormDataByInstanceIdHeaders();
            return await BatchUpdateFormDataByInstanceIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过表单实例数据批量更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceMapRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFormDataByInstanceMapHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceMapResponse
        /// </returns>
        public BatchUpdateFormDataByInstanceMapResponse BatchUpdateFormDataByInstanceMapWithOptions(BatchUpdateFormDataByInstanceMapRequest request, BatchUpdateFormDataByInstanceMapHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEmpty))
            {
                body["ignoreEmpty"] = request.IgnoreEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJsonMap))
            {
                body["updateFormDataJsonMap"] = request.UpdateFormDataJsonMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestFormSchemaVersion))
            {
                body["useLatestFormSchemaVersion"] = request.UseLatestFormSchemaVersion;
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
                Action = "BatchUpdateFormDataByInstanceMap",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/datas",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFormDataByInstanceMapResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过表单实例数据批量更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceMapRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateFormDataByInstanceMapHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceMapResponse
        /// </returns>
        public async Task<BatchUpdateFormDataByInstanceMapResponse> BatchUpdateFormDataByInstanceMapWithOptionsAsync(BatchUpdateFormDataByInstanceMapRequest request, BatchUpdateFormDataByInstanceMapHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsynchronousExecution))
            {
                body["asynchronousExecution"] = request.AsynchronousExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEmpty))
            {
                body["ignoreEmpty"] = request.IgnoreEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJsonMap))
            {
                body["updateFormDataJsonMap"] = request.UpdateFormDataJsonMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestFormSchemaVersion))
            {
                body["useLatestFormSchemaVersion"] = request.UseLatestFormSchemaVersion;
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
                Action = "BatchUpdateFormDataByInstanceMap",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/datas",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFormDataByInstanceMapResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过表单实例数据批量更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceMapRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceMapResponse
        /// </returns>
        public BatchUpdateFormDataByInstanceMapResponse BatchUpdateFormDataByInstanceMap(BatchUpdateFormDataByInstanceMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFormDataByInstanceMapHeaders headers = new BatchUpdateFormDataByInstanceMapHeaders();
            return BatchUpdateFormDataByInstanceMapWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过表单实例数据批量更新表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFormDataByInstanceMapRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFormDataByInstanceMapResponse
        /// </returns>
        public async Task<BatchUpdateFormDataByInstanceMapResponse> BatchUpdateFormDataByInstanceMapAsync(BatchUpdateFormDataByInstanceMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateFormDataByInstanceMapHeaders headers = new BatchUpdateFormDataByInstanceMapHeaders();
            return await BatchUpdateFormDataByInstanceMapWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购(通过应用授权服务)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyAuthorizationOrderRequest
        /// </param>
        /// <param name="headers">
        /// BuyAuthorizationOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuyAuthorizationOrderResponse
        /// </returns>
        public BuyAuthorizationOrderResponse BuyAuthorizationOrderWithOptions(BuyAuthorizationOrderRequest request, BuyAuthorizationOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "BuyAuthorizationOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuthorizations/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuyAuthorizationOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购(通过应用授权服务)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyAuthorizationOrderRequest
        /// </param>
        /// <param name="headers">
        /// BuyAuthorizationOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuyAuthorizationOrderResponse
        /// </returns>
        public async Task<BuyAuthorizationOrderResponse> BuyAuthorizationOrderWithOptionsAsync(BuyAuthorizationOrderRequest request, BuyAuthorizationOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "BuyAuthorizationOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuthorizations/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuyAuthorizationOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购(通过应用授权服务)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyAuthorizationOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// BuyAuthorizationOrderResponse
        /// </returns>
        public BuyAuthorizationOrderResponse BuyAuthorizationOrder(BuyAuthorizationOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BuyAuthorizationOrderHeaders headers = new BuyAuthorizationOrderHeaders();
            return BuyAuthorizationOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购(通过应用授权服务)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyAuthorizationOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// BuyAuthorizationOrderResponse
        /// </returns>
        public async Task<BuyAuthorizationOrderResponse> BuyAuthorizationOrderAsync(BuyAuthorizationOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BuyAuthorizationOrderHeaders headers = new BuyAuthorizationOrderHeaders();
            return await BuyAuthorizationOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新购宜搭产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyFreshOrderRequest
        /// </param>
        /// <param name="headers">
        /// BuyFreshOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuyFreshOrderResponse
        /// </returns>
        public BuyFreshOrderResponse BuyFreshOrderWithOptions(BuyFreshOrderRequest request, BuyFreshOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "BuyFreshOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/freshOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuyFreshOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新购宜搭产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyFreshOrderRequest
        /// </param>
        /// <param name="headers">
        /// BuyFreshOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuyFreshOrderResponse
        /// </returns>
        public async Task<BuyFreshOrderResponse> BuyFreshOrderWithOptionsAsync(BuyFreshOrderRequest request, BuyFreshOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "BuyFreshOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/freshOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuyFreshOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新购宜搭产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyFreshOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// BuyFreshOrderResponse
        /// </returns>
        public BuyFreshOrderResponse BuyFreshOrder(BuyFreshOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BuyFreshOrderHeaders headers = new BuyFreshOrderHeaders();
            return BuyFreshOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新购宜搭产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuyFreshOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// BuyFreshOrderResponse
        /// </returns>
        public async Task<BuyFreshOrderResponse> BuyFreshOrderAsync(BuyFreshOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BuyFreshOrderHeaders headers = new BuyFreshOrderHeaders();
            return await BuyFreshOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号验证激活结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCloudAccountStatusRequest
        /// </param>
        /// <param name="headers">
        /// CheckCloudAccountStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCloudAccountStatusResponse
        /// </returns>
        public CheckCloudAccountStatusResponse CheckCloudAccountStatusWithOptions(string callerUid, CheckCloudAccountStatusRequest request, CheckCloudAccountStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "CheckCloudAccountStatus",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAccountStatus/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudAccountStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号验证激活结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCloudAccountStatusRequest
        /// </param>
        /// <param name="headers">
        /// CheckCloudAccountStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCloudAccountStatusResponse
        /// </returns>
        public async Task<CheckCloudAccountStatusResponse> CheckCloudAccountStatusWithOptionsAsync(string callerUid, CheckCloudAccountStatusRequest request, CheckCloudAccountStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "CheckCloudAccountStatus",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAccountStatus/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudAccountStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号验证激活结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCloudAccountStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCloudAccountStatusResponse
        /// </returns>
        public CheckCloudAccountStatusResponse CheckCloudAccountStatus(string callerUid, CheckCloudAccountStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckCloudAccountStatusHeaders headers = new CheckCloudAccountStatusHeaders();
            return CheckCloudAccountStatusWithOptions(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号验证激活结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCloudAccountStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCloudAccountStatusResponse
        /// </returns>
        public async Task<CheckCloudAccountStatusResponse> CheckCloudAccountStatusAsync(string callerUid, CheckCloudAccountStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckCloudAccountStatusHeaders headers = new CheckCloudAccountStatusHeaders();
            return await CheckCloudAccountStatusWithOptionsAsync(callerUid, request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/insertOrUpdate",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/insertOrUpdate",
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
        /// <para>删除表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFormDataRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFormDataResponse
        /// </returns>
        public DeleteFormDataResponse DeleteFormDataWithOptions(DeleteFormDataRequest request, DeleteFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
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
                Action = "DeleteFormData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFormDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFormDataRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFormDataResponse
        /// </returns>
        public async Task<DeleteFormDataResponse> DeleteFormDataWithOptionsAsync(DeleteFormDataRequest request, DeleteFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                query["formInstanceId"] = request.FormInstanceId;
            }
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
                Action = "DeleteFormData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFormDataResponse
        /// </returns>
        public DeleteFormDataResponse DeleteFormData(DeleteFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFormDataHeaders headers = new DeleteFormDataHeaders();
            return DeleteFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表单实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFormDataResponse
        /// </returns>
        public async Task<DeleteFormDataResponse> DeleteFormDataAsync(DeleteFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFormDataHeaders headers = new DeleteFormDataHeaders();
            return await DeleteFormDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, DeleteInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "DeleteInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, DeleteInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "DeleteInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
            return DeleteInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
            return await DeleteInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deleteSequence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSequenceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSequenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSequenceResponse
        /// </returns>
        public DeleteSequenceResponse DeleteSequenceWithOptions(DeleteSequenceRequest request, DeleteSequenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sequence))
            {
                query["sequence"] = request.Sequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "DeleteSequence",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/deleteSequence",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSequenceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deleteSequence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSequenceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSequenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSequenceResponse
        /// </returns>
        public async Task<DeleteSequenceResponse> DeleteSequenceWithOptionsAsync(DeleteSequenceRequest request, DeleteSequenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sequence))
            {
                query["sequence"] = request.Sequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "DeleteSequence",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/deleteSequence",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSequenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deleteSequence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSequenceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSequenceResponse
        /// </returns>
        public DeleteSequenceResponse DeleteSequence(DeleteSequenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSequenceHeaders headers = new DeleteSequenceHeaders();
            return DeleteSequenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deleteSequence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSequenceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSequenceResponse
        /// </returns>
        public async Task<DeleteSequenceResponse> DeleteSequenceAsync(DeleteSequenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSequenceHeaders headers = new DeleteSequenceHeaders();
            return await DeleteSequenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云开发平台函数计算部署完成回调宜搭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployFunctionCallbackRequest
        /// </param>
        /// <param name="headers">
        /// DeployFunctionCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployFunctionCallbackResponse
        /// </returns>
        public DeployFunctionCallbackResponse DeployFunctionCallbackWithOptions(DeployFunctionCallbackRequest request, DeployFunctionCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomain))
            {
                body["customDomain"] = request.CustomDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStage))
            {
                body["deployStage"] = request.DeployStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayAppKey))
            {
                body["gateWayAppKey"] = request.GateWayAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayAppSecret))
            {
                body["gateWayAppSecret"] = request.GateWayAppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayDomain))
            {
                body["gateWayDomain"] = request.GateWayDomain;
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
                Action = "DeployFunctionCallback",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/functionComputeConnectors/completeDeployments/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployFunctionCallbackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云开发平台函数计算部署完成回调宜搭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployFunctionCallbackRequest
        /// </param>
        /// <param name="headers">
        /// DeployFunctionCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployFunctionCallbackResponse
        /// </returns>
        public async Task<DeployFunctionCallbackResponse> DeployFunctionCallbackWithOptionsAsync(DeployFunctionCallbackRequest request, DeployFunctionCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomain))
            {
                body["customDomain"] = request.CustomDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStage))
            {
                body["deployStage"] = request.DeployStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayAppKey))
            {
                body["gateWayAppKey"] = request.GateWayAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayAppSecret))
            {
                body["gateWayAppSecret"] = request.GateWayAppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GateWayDomain))
            {
                body["gateWayDomain"] = request.GateWayDomain;
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
                Action = "DeployFunctionCallback",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/functionComputeConnectors/completeDeployments/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployFunctionCallbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云开发平台函数计算部署完成回调宜搭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployFunctionCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployFunctionCallbackResponse
        /// </returns>
        public DeployFunctionCallbackResponse DeployFunctionCallback(DeployFunctionCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployFunctionCallbackHeaders headers = new DeployFunctionCallbackHeaders();
            return DeployFunctionCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云开发平台函数计算部署完成回调宜搭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployFunctionCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployFunctionCallbackResponse
        /// </returns>
        public async Task<DeployFunctionCallbackResponse> DeployFunctionCallbackAsync(DeployFunctionCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployFunctionCallbackHeaders headers = new DeployFunctionCallbackHeaders();
            return await DeployFunctionCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBatchTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteBatchTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBatchTaskResponse
        /// </returns>
        public ExecuteBatchTaskResponse ExecuteBatchTaskWithOptions(ExecuteBatchTaskRequest request, ExecuteBatchTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInformationList))
            {
                body["taskInformationList"] = request.TaskInformationList;
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
                Action = "ExecuteBatchTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/batches/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteBatchTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBatchTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteBatchTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBatchTaskResponse
        /// </returns>
        public async Task<ExecuteBatchTaskResponse> ExecuteBatchTaskWithOptionsAsync(ExecuteBatchTaskRequest request, ExecuteBatchTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInformationList))
            {
                body["taskInformationList"] = request.TaskInformationList;
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
                Action = "ExecuteBatchTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/batches/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteBatchTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBatchTaskResponse
        /// </returns>
        public ExecuteBatchTaskResponse ExecuteBatchTask(ExecuteBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteBatchTaskHeaders headers = new ExecuteBatchTaskHeaders();
            return ExecuteBatchTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBatchTaskResponse
        /// </returns>
        public async Task<ExecuteBatchTaskResponse> ExecuteBatchTaskAsync(ExecuteBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteBatchTaskHeaders headers = new ExecuteBatchTaskHeaders();
            return await ExecuteBatchTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行用户自定义的API接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteCustomApiRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteCustomApiHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCustomApiResponse
        /// </returns>
        public ExecuteCustomApiResponse ExecuteCustomApiWithOptions(ExecuteCustomApiRequest request, ExecuteCustomApiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "ExecuteCustomApi",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/customApi/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteCustomApiResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行用户自定义的API接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteCustomApiRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteCustomApiHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCustomApiResponse
        /// </returns>
        public async Task<ExecuteCustomApiResponse> ExecuteCustomApiWithOptionsAsync(ExecuteCustomApiRequest request, ExecuteCustomApiHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "ExecuteCustomApi",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/customApi/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteCustomApiResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行用户自定义的API接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteCustomApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCustomApiResponse
        /// </returns>
        public ExecuteCustomApiResponse ExecuteCustomApi(ExecuteCustomApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteCustomApiHeaders headers = new ExecuteCustomApiHeaders();
            return ExecuteCustomApiWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行用户自定义的API接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteCustomApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCustomApiResponse
        /// </returns>
        public async Task<ExecuteCustomApiResponse> ExecuteCustomApiAsync(ExecuteCustomApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteCustomApiHeaders headers = new ExecuteCustomApiHeaders();
            return await ExecuteCustomApiWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行宜搭平台的审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePlatformTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecutePlatformTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecutePlatformTaskResponse
        /// </returns>
        public ExecutePlatformTaskResponse ExecutePlatformTaskWithOptions(ExecutePlatformTaskRequest request, ExecutePlatformTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpressions))
            {
                body["noExecuteExpressions"] = request.NoExecuteExpressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ExecutePlatformTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/platformTasks/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ExecutePlatformTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行宜搭平台的审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePlatformTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecutePlatformTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecutePlatformTaskResponse
        /// </returns>
        public async Task<ExecutePlatformTaskResponse> ExecutePlatformTaskWithOptionsAsync(ExecutePlatformTaskRequest request, ExecutePlatformTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpressions))
            {
                body["noExecuteExpressions"] = request.NoExecuteExpressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ExecutePlatformTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/platformTasks/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ExecutePlatformTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行宜搭平台的审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePlatformTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecutePlatformTaskResponse
        /// </returns>
        public ExecutePlatformTaskResponse ExecutePlatformTask(ExecutePlatformTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecutePlatformTaskHeaders headers = new ExecutePlatformTaskHeaders();
            return ExecutePlatformTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行宜搭平台的审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePlatformTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecutePlatformTaskResponse
        /// </returns>
        public async Task<ExecutePlatformTaskResponse> ExecutePlatformTaskAsync(ExecutePlatformTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecutePlatformTaskHeaders headers = new ExecutePlatformTaskHeaders();
            return await ExecutePlatformTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTaskResponse
        /// </returns>
        public ExecuteTaskResponse ExecuteTaskWithOptions(ExecuteTaskRequest request, ExecuteTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalSignUrl))
            {
                body["digitalSignUrl"] = request.DigitalSignUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpressions))
            {
                body["noExecuteExpressions"] = request.NoExecuteExpressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "ExecuteTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ExecuteTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTaskRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTaskResponse
        /// </returns>
        public async Task<ExecuteTaskResponse> ExecuteTaskWithOptionsAsync(ExecuteTaskRequest request, ExecuteTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalSignUrl))
            {
                body["digitalSignUrl"] = request.DigitalSignUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpressions))
            {
                body["noExecuteExpressions"] = request.NoExecuteExpressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutResult))
            {
                body["outResult"] = request.OutResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "ExecuteTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ExecuteTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTaskResponse
        /// </returns>
        public ExecuteTaskResponse ExecuteTask(ExecuteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteTaskHeaders headers = new ExecuteTaskHeaders();
            return ExecuteTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行审批任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTaskResponse
        /// </returns>
        public async Task<ExecuteTaskResponse> ExecuteTaskAsync(ExecuteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteTaskHeaders headers = new ExecuteTaskHeaders();
            return await ExecuteTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道到期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpireCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ExpireCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExpireCommodityResponse
        /// </returns>
        public ExpireCommodityResponse ExpireCommodityWithOptions(ExpireCommodityRequest request, ExpireCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ExpireCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/expire",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpireCommodityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道到期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpireCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ExpireCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExpireCommodityResponse
        /// </returns>
        public async Task<ExpireCommodityResponse> ExpireCommodityWithOptionsAsync(ExpireCommodityRequest request, ExpireCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ExpireCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/expire",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpireCommodityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道到期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpireCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExpireCommodityResponse
        /// </returns>
        public ExpireCommodityResponse ExpireCommodity(ExpireCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExpireCommodityHeaders headers = new ExpireCommodityHeaders();
            return ExpireCommodityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道到期</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpireCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExpireCommodityResponse
        /// </returns>
        public async Task<ExpireCommodityResponse> ExpireCommodityAsync(ExpireCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExpireCommodityHeaders headers = new ExpireCommodityHeaders();
            return await ExpireCommodityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号获取激活码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivationCodeByCallerUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetActivationCodeByCallerUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivationCodeByCallerUnionIdResponse
        /// </returns>
        public GetActivationCodeByCallerUnionIdResponse GetActivationCodeByCallerUnionIdWithOptions(string callerUid, GetActivationCodeByCallerUnionIdRequest request, GetActivationCodeByCallerUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "GetActivationCodeByCallerUnionId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/activationCodes/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivationCodeByCallerUnionIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号获取激活码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivationCodeByCallerUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetActivationCodeByCallerUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivationCodeByCallerUnionIdResponse
        /// </returns>
        public async Task<GetActivationCodeByCallerUnionIdResponse> GetActivationCodeByCallerUnionIdWithOptionsAsync(string callerUid, GetActivationCodeByCallerUnionIdRequest request, GetActivationCodeByCallerUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "GetActivationCodeByCallerUnionId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/activationCodes/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivationCodeByCallerUnionIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号获取激活码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivationCodeByCallerUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivationCodeByCallerUnionIdResponse
        /// </returns>
        public GetActivationCodeByCallerUnionIdResponse GetActivationCodeByCallerUnionId(string callerUid, GetActivationCodeByCallerUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivationCodeByCallerUnionIdHeaders headers = new GetActivationCodeByCallerUnionIdHeaders();
            return GetActivationCodeByCallerUnionIdWithOptions(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据阿里云账号获取激活码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivationCodeByCallerUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivationCodeByCallerUnionIdResponse
        /// </returns>
        public async Task<GetActivationCodeByCallerUnionIdResponse> GetActivationCodeByCallerUnionIdAsync(string callerUid, GetActivationCodeByCallerUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivationCodeByCallerUnionIdHeaders headers = new GetActivationCodeByCallerUnionIdHeaders();
            return await GetActivationCodeByCallerUnionIdWithOptionsAsync(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例可操作功能列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityButtonListRequest
        /// </param>
        /// <param name="headers">
        /// GetActivityButtonListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivityButtonListResponse
        /// </returns>
        public GetActivityButtonListResponse GetActivityButtonListWithOptions(string appType, string processCode, string activityId, GetActivityButtonListRequest request, GetActivityButtonListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetActivityButtonList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processDefinitions/buttons/" + appType + "/" + processCode + "/" + activityId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityButtonListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例可操作功能列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityButtonListRequest
        /// </param>
        /// <param name="headers">
        /// GetActivityButtonListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivityButtonListResponse
        /// </returns>
        public async Task<GetActivityButtonListResponse> GetActivityButtonListWithOptionsAsync(string appType, string processCode, string activityId, GetActivityButtonListRequest request, GetActivityButtonListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetActivityButtonList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processDefinitions/buttons/" + appType + "/" + processCode + "/" + activityId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityButtonListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例可操作功能列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityButtonListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivityButtonListResponse
        /// </returns>
        public GetActivityButtonListResponse GetActivityButtonList(string appType, string processCode, string activityId, GetActivityButtonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivityButtonListHeaders headers = new GetActivityButtonListHeaders();
            return GetActivityButtonListWithOptions(appType, processCode, activityId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程实例可操作功能列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityButtonListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivityButtonListResponse
        /// </returns>
        public async Task<GetActivityButtonListResponse> GetActivityButtonListAsync(string appType, string processCode, string activityId, GetActivityButtonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivityButtonListHeaders headers = new GetActivityButtonListHeaders();
            return await GetActivityButtonListWithOptionsAsync(appType, processCode, activityId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程设计的节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityListRequest
        /// </param>
        /// <param name="headers">
        /// GetActivityListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivityListResponse
        /// </returns>
        public GetActivityListResponse GetActivityListWithOptions(GetActivityListRequest request, GetActivityListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetActivityList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/activities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程设计的节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityListRequest
        /// </param>
        /// <param name="headers">
        /// GetActivityListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActivityListResponse
        /// </returns>
        public async Task<GetActivityListResponse> GetActivityListWithOptionsAsync(GetActivityListRequest request, GetActivityListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                query["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetActivityList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/activities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程设计的节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivityListResponse
        /// </returns>
        public GetActivityListResponse GetActivityList(GetActivityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivityListHeaders headers = new GetActivityListHeaders();
            return GetActivityListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程设计的节点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActivityListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetActivityListResponse
        /// </returns>
        public async Task<GetActivityListResponse> GetActivityListAsync(GetActivityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActivityListHeaders headers = new GetActivityListHeaders();
            return await GetActivityListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的接口，支持分页、表单名称模糊查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllAuthCubesRequest
        /// </param>
        /// <param name="headers">
        /// GetAllAuthCubesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllAuthCubesResponse
        /// </returns>
        public GetAllAuthCubesResponse GetAllAuthCubesWithOptions(GetAllAuthCubesRequest request, GetAllAuthCubesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "GetAllAuthCubes",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/allAuthCubes/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllAuthCubesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的接口，支持分页、表单名称模糊查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllAuthCubesRequest
        /// </param>
        /// <param name="headers">
        /// GetAllAuthCubesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllAuthCubesResponse
        /// </returns>
        public async Task<GetAllAuthCubesResponse> GetAllAuthCubesWithOptionsAsync(GetAllAuthCubesRequest request, GetAllAuthCubesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "GetAllAuthCubes",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/allAuthCubes/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllAuthCubesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的接口，支持分页、表单名称模糊查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllAuthCubesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllAuthCubesResponse
        /// </returns>
        public GetAllAuthCubesResponse GetAllAuthCubes(GetAllAuthCubesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllAuthCubesHeaders headers = new GetAllAuthCubesHeaders();
            return GetAllAuthCubesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的接口，支持分页、表单名称模糊查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllAuthCubesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllAuthCubesResponse
        /// </returns>
        public async Task<GetAllAuthCubesResponse> GetAllAuthCubesAsync(GetAllAuthCubesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllAuthCubesHeaders headers = new GetAllAuthCubesHeaders();
            return await GetAllAuthCubesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationAuthorizationServicePlatformResourceRequest
        /// </param>
        /// <param name="headers">
        /// GetApplicationAuthorizationServicePlatformResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationAuthorizationServicePlatformResourceResponse
        /// </returns>
        public GetApplicationAuthorizationServicePlatformResourceResponse GetApplicationAuthorizationServicePlatformResourceWithOptions(GetApplicationAuthorizationServicePlatformResourceRequest request, GetApplicationAuthorizationServicePlatformResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "GetApplicationAuthorizationServicePlatformResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorization/platformResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationAuthorizationServicePlatformResourceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationAuthorizationServicePlatformResourceRequest
        /// </param>
        /// <param name="headers">
        /// GetApplicationAuthorizationServicePlatformResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationAuthorizationServicePlatformResourceResponse
        /// </returns>
        public async Task<GetApplicationAuthorizationServicePlatformResourceResponse> GetApplicationAuthorizationServicePlatformResourceWithOptionsAsync(GetApplicationAuthorizationServicePlatformResourceRequest request, GetApplicationAuthorizationServicePlatformResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "GetApplicationAuthorizationServicePlatformResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorization/platformResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationAuthorizationServicePlatformResourceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationAuthorizationServicePlatformResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationAuthorizationServicePlatformResourceResponse
        /// </returns>
        public GetApplicationAuthorizationServicePlatformResourceResponse GetApplicationAuthorizationServicePlatformResource(GetApplicationAuthorizationServicePlatformResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationAuthorizationServicePlatformResourceHeaders headers = new GetApplicationAuthorizationServicePlatformResourceHeaders();
            return GetApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationAuthorizationServicePlatformResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationAuthorizationServicePlatformResourceResponse
        /// </returns>
        public async Task<GetApplicationAuthorizationServicePlatformResourceResponse> GetApplicationAuthorizationServicePlatformResourceAsync(GetApplicationAuthorizationServicePlatformResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationAuthorizationServicePlatformResourceHeaders headers = new GetApplicationAuthorizationServicePlatformResourceHeaders();
            return await GetApplicationAuthorizationServicePlatformResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自动化流日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoFlowLogDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetAutoFlowLogDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoFlowLogDetailResponse
        /// </returns>
        public GetAutoFlowLogDetailResponse GetAutoFlowLogDetailWithOptions(GetAutoFlowLogDetailRequest request, GetAutoFlowLogDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcInstanceId))
            {
                query["procInstanceId"] = request.ProcInstanceId;
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
                Action = "GetAutoFlowLogDetail",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/logs/automations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoFlowLogDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自动化流日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoFlowLogDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetAutoFlowLogDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoFlowLogDetailResponse
        /// </returns>
        public async Task<GetAutoFlowLogDetailResponse> GetAutoFlowLogDetailWithOptionsAsync(GetAutoFlowLogDetailRequest request, GetAutoFlowLogDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcInstanceId))
            {
                query["procInstanceId"] = request.ProcInstanceId;
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
                Action = "GetAutoFlowLogDetail",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/logs/automations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoFlowLogDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自动化流日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoFlowLogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoFlowLogDetailResponse
        /// </returns>
        public GetAutoFlowLogDetailResponse GetAutoFlowLogDetail(GetAutoFlowLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAutoFlowLogDetailHeaders headers = new GetAutoFlowLogDetailHeaders();
            return GetAutoFlowLogDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自动化流日志详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoFlowLogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoFlowLogDetailResponse
        /// </returns>
        public async Task<GetAutoFlowLogDetailResponse> GetAutoFlowLogDetailAsync(GetAutoFlowLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAutoFlowLogDetailHeaders headers = new GetAutoFlowLogDetailHeaders();
            return await GetAutoFlowLogDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已完成任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccomplishmentTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpAccomplishmentTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccomplishmentTasksResponse
        /// </returns>
        public GetCorpAccomplishmentTasksResponse GetCorpAccomplishmentTasksWithOptions(string corpId, string userId, GetCorpAccomplishmentTasksRequest request, GetCorpAccomplishmentTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetCorpAccomplishmentTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/completedTasks/" + corpId + "/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpAccomplishmentTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已完成任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccomplishmentTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpAccomplishmentTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccomplishmentTasksResponse
        /// </returns>
        public async Task<GetCorpAccomplishmentTasksResponse> GetCorpAccomplishmentTasksWithOptionsAsync(string corpId, string userId, GetCorpAccomplishmentTasksRequest request, GetCorpAccomplishmentTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetCorpAccomplishmentTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/completedTasks/" + corpId + "/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpAccomplishmentTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已完成任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccomplishmentTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccomplishmentTasksResponse
        /// </returns>
        public GetCorpAccomplishmentTasksResponse GetCorpAccomplishmentTasks(string corpId, string userId, GetCorpAccomplishmentTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpAccomplishmentTasksHeaders headers = new GetCorpAccomplishmentTasksHeaders();
            return GetCorpAccomplishmentTasksWithOptions(corpId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已完成任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccomplishmentTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccomplishmentTasksResponse
        /// </returns>
        public async Task<GetCorpAccomplishmentTasksResponse> GetCorpAccomplishmentTasksAsync(string corpId, string userId, GetCorpAccomplishmentTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpAccomplishmentTasksHeaders headers = new GetCorpAccomplishmentTasksHeaders();
            return await GetCorpAccomplishmentTasksWithOptionsAsync(corpId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据accountId获取企业等级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpLevelByAccountIdRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpLevelByAccountIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpLevelByAccountIdResponse
        /// </returns>
        public GetCorpLevelByAccountIdResponse GetCorpLevelByAccountIdWithOptions(GetCorpLevelByAccountIdRequest request, GetCorpLevelByAccountIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
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
                Action = "GetCorpLevelByAccountId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/corpLevel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpLevelByAccountIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据accountId获取企业等级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpLevelByAccountIdRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpLevelByAccountIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpLevelByAccountIdResponse
        /// </returns>
        public async Task<GetCorpLevelByAccountIdResponse> GetCorpLevelByAccountIdWithOptionsAsync(GetCorpLevelByAccountIdRequest request, GetCorpLevelByAccountIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
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
                Action = "GetCorpLevelByAccountId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/corpLevel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpLevelByAccountIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据accountId获取企业等级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpLevelByAccountIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpLevelByAccountIdResponse
        /// </returns>
        public GetCorpLevelByAccountIdResponse GetCorpLevelByAccountId(GetCorpLevelByAccountIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpLevelByAccountIdHeaders headers = new GetCorpLevelByAccountIdHeaders();
            return GetCorpLevelByAccountIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据accountId获取企业等级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpLevelByAccountIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpLevelByAccountIdResponse
        /// </returns>
        public async Task<GetCorpLevelByAccountIdResponse> GetCorpLevelByAccountIdAsync(GetCorpLevelByAccountIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpLevelByAccountIdHeaders headers = new GetCorpLevelByAccountIdHeaders();
            return await GetCorpLevelByAccountIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpTasksResponse
        /// </returns>
        public GetCorpTasksResponse GetCorpTasksWithOptions(GetCorpTasksRequest request, GetCorpTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
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
                Action = "GetCorpTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/corpTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetCorpTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpTasksResponse
        /// </returns>
        public async Task<GetCorpTasksResponse> GetCorpTasksWithOptionsAsync(GetCorpTasksRequest request, GetCorpTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
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
                Action = "GetCorpTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/corpTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpTasksResponse
        /// </returns>
        public GetCorpTasksResponse GetCorpTasks(GetCorpTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpTasksHeaders headers = new GetCorpTasksHeaders();
            return GetCorpTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpTasksResponse
        /// </returns>
        public async Task<GetCorpTasksResponse> GetCorpTasksAsync(GetCorpTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpTasksHeaders headers = new GetCorpTasksHeaders();
            return await GetCorpTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库连接串信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDbConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetDbConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDbConfigResponse
        /// </returns>
        public GetDbConfigResponse GetDbConfigWithOptions(GetDbConfigRequest request, GetDbConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetDbConfig",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/dbConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库连接串信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDbConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetDbConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDbConfigResponse
        /// </returns>
        public async Task<GetDbConfigResponse> GetDbConfigWithOptionsAsync(GetDbConfigRequest request, GetDbConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetDbConfig",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/dbConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库连接串信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDbConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDbConfigResponse
        /// </returns>
        public GetDbConfigResponse GetDbConfig(GetDbConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDbConfigHeaders headers = new GetDbConfigHeaders();
            return GetDbConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库连接串信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDbConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDbConfigResponse
        /// </returns>
        public async Task<GetDbConfigResponse> GetDbConfigAsync(GetDbConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDbConfigHeaders headers = new GetDbConfigHeaders();
            return await GetDbConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单ID获取字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldDefByUuidRequest
        /// </param>
        /// <param name="headers">
        /// GetFieldDefByUuidHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFieldDefByUuidResponse
        /// </returns>
        public GetFieldDefByUuidResponse GetFieldDefByUuidWithOptions(GetFieldDefByUuidRequest request, GetFieldDefByUuidHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetFieldDefByUuid",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/formFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFieldDefByUuidResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单ID获取字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldDefByUuidRequest
        /// </param>
        /// <param name="headers">
        /// GetFieldDefByUuidHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFieldDefByUuidResponse
        /// </returns>
        public async Task<GetFieldDefByUuidResponse> GetFieldDefByUuidWithOptionsAsync(GetFieldDefByUuidRequest request, GetFieldDefByUuidHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetFieldDefByUuid",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/formFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFieldDefByUuidResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单ID获取字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldDefByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFieldDefByUuidResponse
        /// </returns>
        public GetFieldDefByUuidResponse GetFieldDefByUuid(GetFieldDefByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldDefByUuidHeaders headers = new GetFieldDefByUuidHeaders();
            return GetFieldDefByUuidWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据表单ID获取字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFieldDefByUuidRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFieldDefByUuidResponse
        /// </returns>
        public async Task<GetFieldDefByUuidResponse> GetFieldDefByUuidAsync(GetFieldDefByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFieldDefByUuidHeaders headers = new GetFieldDefByUuidHeaders();
            return await GetFieldDefByUuidWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentDefinitionListRequest
        /// </param>
        /// <param name="headers">
        /// GetFormComponentDefinitionListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentDefinitionListResponse
        /// </returns>
        public GetFormComponentDefinitionListResponse GetFormComponentDefinitionListWithOptions(string appType, string formUuid, GetFormComponentDefinitionListRequest request, GetFormComponentDefinitionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFormComponentDefinitionList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/definitions/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentDefinitionListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentDefinitionListRequest
        /// </param>
        /// <param name="headers">
        /// GetFormComponentDefinitionListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentDefinitionListResponse
        /// </returns>
        public async Task<GetFormComponentDefinitionListResponse> GetFormComponentDefinitionListWithOptionsAsync(string appType, string formUuid, GetFormComponentDefinitionListRequest request, GetFormComponentDefinitionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFormComponentDefinitionList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/definitions/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentDefinitionListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentDefinitionListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentDefinitionListResponse
        /// </returns>
        public GetFormComponentDefinitionListResponse GetFormComponentDefinitionList(string appType, string formUuid, GetFormComponentDefinitionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentDefinitionListHeaders headers = new GetFormComponentDefinitionListHeaders();
            return GetFormComponentDefinitionListWithOptions(appType, formUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表单定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormComponentDefinitionListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormComponentDefinitionListResponse
        /// </returns>
        public async Task<GetFormComponentDefinitionListResponse> GetFormComponentDefinitionListAsync(string appType, string formUuid, GetFormComponentDefinitionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentDefinitionListHeaders headers = new GetFormComponentDefinitionListHeaders();
            return await GetFormComponentDefinitionListWithOptionsAsync(appType, formUuid, request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/" + id,
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/" + id,
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
        /// <para>获取应用内表单列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormListInAppRequest
        /// </param>
        /// <param name="headers">
        /// GetFormListInAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormListInAppResponse
        /// </returns>
        public GetFormListInAppResponse GetFormListInAppWithOptions(GetFormListInAppRequest request, GetFormListInAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormTypes))
            {
                query["formTypes"] = request.FormTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetFormListInApp",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormListInAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用内表单列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormListInAppRequest
        /// </param>
        /// <param name="headers">
        /// GetFormListInAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormListInAppResponse
        /// </returns>
        public async Task<GetFormListInAppResponse> GetFormListInAppWithOptionsAsync(GetFormListInAppRequest request, GetFormListInAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormTypes))
            {
                query["formTypes"] = request.FormTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetFormListInApp",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormListInAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用内表单列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormListInAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormListInAppResponse
        /// </returns>
        public GetFormListInAppResponse GetFormListInApp(GetFormListInAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormListInAppHeaders headers = new GetFormListInAppHeaders();
            return GetFormListInAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用内表单列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFormListInAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFormListInAppResponse
        /// </returns>
        public async Task<GetFormListInAppResponse> GetFormListInAppAsync(GetFormListInAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormListInAppHeaders headers = new GetFormListInAppHeaders();
            return await GetFormListInAppWithOptionsAsync(request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instancesInfos/" + id,
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instancesInfos/" + id,
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instanceIds",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instanceIds",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
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
        /// <para>根据实例 ID 列表批量获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesByIdListRequest
        /// </param>
        /// <param name="headers">
        /// GetInstancesByIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesByIdListResponse
        /// </returns>
        public GetInstancesByIdListResponse GetInstancesByIdListWithOptions(GetInstancesByIdListRequest request, GetInstancesByIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceIds))
            {
                query["processInstanceIds"] = request.ProcessInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetInstancesByIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/searchWithIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesByIdListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 列表批量获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesByIdListRequest
        /// </param>
        /// <param name="headers">
        /// GetInstancesByIdListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesByIdListResponse
        /// </returns>
        public async Task<GetInstancesByIdListResponse> GetInstancesByIdListWithOptionsAsync(GetInstancesByIdListRequest request, GetInstancesByIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceIds))
            {
                query["processInstanceIds"] = request.ProcessInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetInstancesByIdList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/searchWithIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesByIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 列表批量获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesByIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesByIdListResponse
        /// </returns>
        public GetInstancesByIdListResponse GetInstancesByIdList(GetInstancesByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesByIdListHeaders headers = new GetInstancesByIdListHeaders();
            return GetInstancesByIdListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例 ID 列表批量获取流程实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancesByIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancesByIdListResponse
        /// </returns>
        public async Task<GetInstancesByIdListResponse> GetInstancesByIdListAsync(GetInstancesByIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesByIdListHeaders headers = new GetInstancesByIdListHeaders();
            return await GetInstancesByIdListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已提交任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeCorpSubmissionRequest
        /// </param>
        /// <param name="headers">
        /// GetMeCorpSubmissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMeCorpSubmissionResponse
        /// </returns>
        public GetMeCorpSubmissionResponse GetMeCorpSubmissionWithOptions(string userId, GetMeCorpSubmissionRequest request, GetMeCorpSubmissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetMeCorpSubmission",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/myCorpSubmission/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeCorpSubmissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已提交任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeCorpSubmissionRequest
        /// </param>
        /// <param name="headers">
        /// GetMeCorpSubmissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMeCorpSubmissionResponse
        /// </returns>
        public async Task<GetMeCorpSubmissionResponse> GetMeCorpSubmissionWithOptionsAsync(string userId, GetMeCorpSubmissionRequest request, GetMeCorpSubmissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetMeCorpSubmission",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/myCorpSubmission/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeCorpSubmissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已提交任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeCorpSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMeCorpSubmissionResponse
        /// </returns>
        public GetMeCorpSubmissionResponse GetMeCorpSubmission(string userId, GetMeCorpSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeCorpSubmissionHeaders headers = new GetMeCorpSubmissionHeaders();
            return GetMeCorpSubmissionWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已提交任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMeCorpSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMeCorpSubmissionResponse
        /// </returns>
        public async Task<GetMeCorpSubmissionResponse> GetMeCorpSubmissionAsync(string userId, GetMeCorpSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMeCorpSubmissionHeaders headers = new GetMeCorpSubmissionHeaders();
            return await GetMeCorpSubmissionWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（企业维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotifyMeRequest
        /// </param>
        /// <param name="headers">
        /// GetNotifyMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotifyMeResponse
        /// </returns>
        public GetNotifyMeResponse GetNotifyMeWithOptions(string userId, GetNotifyMeRequest request, GetNotifyMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCreateFromTimeGMT))
            {
                query["instanceCreateFromTimeGMT"] = request.InstanceCreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCreateToTimeGMT))
            {
                query["instanceCreateToTimeGMT"] = request.InstanceCreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetNotifyMe",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/corpNotifications/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotifyMeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（企业维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotifyMeRequest
        /// </param>
        /// <param name="headers">
        /// GetNotifyMeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotifyMeResponse
        /// </returns>
        public async Task<GetNotifyMeResponse> GetNotifyMeWithOptionsAsync(string userId, GetNotifyMeRequest request, GetNotifyMeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppTypes))
            {
                query["appTypes"] = request.AppTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCreateFromTimeGMT))
            {
                query["instanceCreateFromTimeGMT"] = request.InstanceCreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCreateToTimeGMT))
            {
                query["instanceCreateToTimeGMT"] = request.InstanceCreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
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
                Action = "GetNotifyMe",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/corpNotifications/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotifyMeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（企业维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotifyMeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotifyMeResponse
        /// </returns>
        public GetNotifyMeResponse GetNotifyMe(string userId, GetNotifyMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNotifyMeHeaders headers = new GetNotifyMeHeaders();
            return GetNotifyMeWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（企业维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotifyMeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotifyMeResponse
        /// </returns>
        public async Task<GetNotifyMeResponse> GetNotifyMeAsync(string userId, GetNotifyMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNotifyMeHeaders headers = new GetNotifyMeHeaders();
            return await GetNotifyMeWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>附件地址转临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetOpenUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpenUrlResponse
        /// </returns>
        public GetOpenUrlResponse GetOpenUrlWithOptions(string appType, GetOpenUrlRequest request, GetOpenUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
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
                Action = "GetOpenUrl",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/temporaryUrls/" + appType,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>附件地址转临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetOpenUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpenUrlResponse
        /// </returns>
        public async Task<GetOpenUrlResponse> GetOpenUrlWithOptionsAsync(string appType, GetOpenUrlRequest request, GetOpenUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
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
                Action = "GetOpenUrl",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/temporaryUrls/" + appType,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>附件地址转临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpenUrlResponse
        /// </returns>
        public GetOpenUrlResponse GetOpenUrl(string appType, GetOpenUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenUrlHeaders headers = new GetOpenUrlHeaders();
            return GetOpenUrlWithOptions(appType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>附件地址转临时免登地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpenUrlResponse
        /// </returns>
        public async Task<GetOpenUrlResponse> GetOpenUrlAsync(string appType, GetOpenUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOpenUrlHeaders headers = new GetOpenUrlHeaders();
            return await GetOpenUrlWithOptionsAsync(appType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetOperationRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationRecordsResponse
        /// </returns>
        public GetOperationRecordsResponse GetOperationRecordsWithOptions(GetOperationRecordsRequest request, GetOperationRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetOperationRecords",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/operationRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetOperationRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationRecordsResponse
        /// </returns>
        public async Task<GetOperationRecordsResponse> GetOperationRecordsWithOptionsAsync(GetOperationRecordsRequest request, GetOperationRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetOperationRecords",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/operationRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationRecordsResponse
        /// </returns>
        public GetOperationRecordsResponse GetOperationRecords(GetOperationRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOperationRecordsHeaders headers = new GetOperationRecordsHeaders();
            return GetOperationRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审批记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationRecordsResponse
        /// </returns>
        public async Task<GetOperationRecordsResponse> GetOperationRecordsAsync(GetOperationRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOperationRecordsHeaders headers = new GetOperationRecordsHeaders();
            return await GetOperationRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlatformResourceRequest
        /// </param>
        /// <param name="headers">
        /// GetPlatformResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPlatformResourceResponse
        /// </returns>
        public GetPlatformResourceResponse GetPlatformResourceWithOptions(GetPlatformResourceRequest request, GetPlatformResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "GetPlatformResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/platformResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlatformResourceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlatformResourceRequest
        /// </param>
        /// <param name="headers">
        /// GetPlatformResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPlatformResourceResponse
        /// </returns>
        public async Task<GetPlatformResourceResponse> GetPlatformResourceWithOptionsAsync(GetPlatformResourceRequest request, GetPlatformResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "GetPlatformResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/platformResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlatformResourceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlatformResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPlatformResourceResponse
        /// </returns>
        public GetPlatformResourceResponse GetPlatformResource(GetPlatformResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPlatformResourceHeaders headers = new GetPlatformResourceHeaders();
            return GetPlatformResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道平台概览接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlatformResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPlatformResourceResponse
        /// </returns>
        public async Task<GetPlatformResourceResponse> GetPlatformResourceAsync(GetPlatformResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPlatformResourceHeaders headers = new GetPlatformResourceHeaders();
            return await GetPlatformResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通打印模板的应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintAppInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPrintAppInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrintAppInfoResponse
        /// </returns>
        public GetPrintAppInfoResponse GetPrintAppInfoWithOptions(GetPrintAppInfoRequest request, GetPrintAppInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "GetPrintAppInfo",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printAppInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrintAppInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通打印模板的应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintAppInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPrintAppInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrintAppInfoResponse
        /// </returns>
        public async Task<GetPrintAppInfoResponse> GetPrintAppInfoWithOptionsAsync(GetPrintAppInfoRequest request, GetPrintAppInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "GetPrintAppInfo",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printAppInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrintAppInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通打印模板的应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrintAppInfoResponse
        /// </returns>
        public GetPrintAppInfoResponse GetPrintAppInfo(GetPrintAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrintAppInfoHeaders headers = new GetPrintAppInfoHeaders();
            return GetPrintAppInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通打印模板的应用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrintAppInfoResponse
        /// </returns>
        public async Task<GetPrintAppInfoResponse> GetPrintAppInfoAsync(GetPrintAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrintAppInfoHeaders headers = new GetPrintAppInfoHeaders();
            return await GetPrintAppInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取打印所需的表单与流程节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintDictionaryRequest
        /// </param>
        /// <param name="headers">
        /// GetPrintDictionaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrintDictionaryResponse
        /// </returns>
        public GetPrintDictionaryResponse GetPrintDictionaryWithOptions(GetPrintDictionaryRequest request, GetPrintDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPrintDictionary",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printDictionaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrintDictionaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取打印所需的表单与流程节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintDictionaryRequest
        /// </param>
        /// <param name="headers">
        /// GetPrintDictionaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrintDictionaryResponse
        /// </returns>
        public async Task<GetPrintDictionaryResponse> GetPrintDictionaryWithOptionsAsync(GetPrintDictionaryRequest request, GetPrintDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPrintDictionary",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printDictionaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrintDictionaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取打印所需的表单与流程节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintDictionaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrintDictionaryResponse
        /// </returns>
        public GetPrintDictionaryResponse GetPrintDictionary(GetPrintDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrintDictionaryHeaders headers = new GetPrintDictionaryHeaders();
            return GetPrintDictionaryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取打印所需的表单与流程节点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrintDictionaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrintDictionaryResponse
        /// </returns>
        public async Task<GetPrintDictionaryResponse> GetPrintDictionaryAsync(GetPrintDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrintDictionaryHeaders headers = new GetPrintDictionaryHeaders();
            return await GetPrintDictionaryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDefinitionRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessDefinitionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDefinitionResponse
        /// </returns>
        public GetProcessDefinitionResponse GetProcessDefinitionWithOptions(string processInstanceId, GetProcessDefinitionRequest request, GetProcessDefinitionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpace))
            {
                query["nameSpace"] = request.NameSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                query["orderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                query["systemType"] = request.SystemType;
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
                Action = "GetProcessDefinition",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/definitions/" + processInstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessDefinitionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDefinitionRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessDefinitionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDefinitionResponse
        /// </returns>
        public async Task<GetProcessDefinitionResponse> GetProcessDefinitionWithOptionsAsync(string processInstanceId, GetProcessDefinitionRequest request, GetProcessDefinitionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpace))
            {
                query["nameSpace"] = request.NameSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                query["orderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                query["systemType"] = request.SystemType;
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
                Action = "GetProcessDefinition",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/definitions/" + processInstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessDefinitionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDefinitionResponse
        /// </returns>
        public GetProcessDefinitionResponse GetProcessDefinition(string processInstanceId, GetProcessDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessDefinitionHeaders headers = new GetProcessDefinitionHeaders();
            return GetProcessDefinitionWithOptions(processInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDefinitionResponse
        /// </returns>
        public async Task<GetProcessDefinitionResponse> GetProcessDefinitionAsync(string processInstanceId, GetProcessDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessDefinitionHeaders headers = new GetProcessDefinitionHeaders();
            return await GetProcessDefinitionWithOptionsAsync(processInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取流程设计结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDesignRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessDesignHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDesignResponse
        /// </returns>
        public GetProcessDesignResponse GetProcessDesignWithOptions(string processId, GetProcessDesignRequest request, GetProcessDesignHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetProcessDesign",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/" + processId + "definitions/designs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessDesignResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取流程设计结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDesignRequest
        /// </param>
        /// <param name="headers">
        /// GetProcessDesignHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDesignResponse
        /// </returns>
        public async Task<GetProcessDesignResponse> GetProcessDesignWithOptionsAsync(string processId, GetProcessDesignRequest request, GetProcessDesignHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetProcessDesign",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/" + processId + "definitions/designs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessDesignResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取流程设计结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDesignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDesignResponse
        /// </returns>
        public GetProcessDesignResponse GetProcessDesign(string processId, GetProcessDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessDesignHeaders headers = new GetProcessDesignHeaders();
            return GetProcessDesignWithOptions(processId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取流程设计结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProcessDesignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProcessDesignResponse
        /// </returns>
        public async Task<GetProcessDesignResponse> GetProcessDesignAsync(string processId, GetProcessDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessDesignHeaders headers = new GetProcessDesignHeaders();
            return await GetProcessDesignWithOptionsAsync(processId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例id批量获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTaskListRequest
        /// </param>
        /// <param name="headers">
        /// GetRunningTaskListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTaskListResponse
        /// </returns>
        public GetRunningTaskListResponse GetRunningTaskListWithOptions(GetRunningTaskListRequest request, GetRunningTaskListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceIdList))
            {
                body["processInstanceIdList"] = request.ProcessInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpId))
            {
                body["userCorpId"] = request.UserCorpId;
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
                Action = "GetRunningTaskList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/runningTasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningTaskListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例id批量获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTaskListRequest
        /// </param>
        /// <param name="headers">
        /// GetRunningTaskListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTaskListResponse
        /// </returns>
        public async Task<GetRunningTaskListResponse> GetRunningTaskListWithOptionsAsync(GetRunningTaskListRequest request, GetRunningTaskListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceIdList))
            {
                body["processInstanceIdList"] = request.ProcessInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpId))
            {
                body["userCorpId"] = request.UserCorpId;
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
                Action = "GetRunningTaskList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/runningTasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningTaskListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例id批量获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTaskListResponse
        /// </returns>
        public GetRunningTaskListResponse GetRunningTaskList(GetRunningTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRunningTaskListHeaders headers = new GetRunningTaskListHeaders();
            return GetRunningTaskListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例id批量获取待办任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTaskListResponse
        /// </returns>
        public async Task<GetRunningTaskListResponse> GetRunningTaskListAsync(GetRunningTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRunningTaskListHeaders headers = new GetRunningTaskListHeaders();
            return await GetRunningTaskListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程运行任务（vpc）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetRunningTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTasksResponse
        /// </returns>
        public GetRunningTasksResponse GetRunningTasksWithOptions(GetRunningTasksRequest request, GetRunningTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetRunningTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/tasks/getRunningTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程运行任务（vpc）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTasksRequest
        /// </param>
        /// <param name="headers">
        /// GetRunningTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTasksResponse
        /// </returns>
        public async Task<GetRunningTasksResponse> GetRunningTasksWithOptionsAsync(GetRunningTasksRequest request, GetRunningTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetRunningTasks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/tasks/getRunningTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程运行任务（vpc）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTasksResponse
        /// </returns>
        public GetRunningTasksResponse GetRunningTasks(GetRunningTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRunningTasksHeaders headers = new GetRunningTasksHeaders();
            return GetRunningTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程运行任务（vpc）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningTasksResponse
        /// </returns>
        public async Task<GetRunningTasksResponse> GetRunningTasksAsync(GetRunningTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRunningTasksHeaders headers = new GetRunningTasksHeaders();
            return await GetRunningTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户employeeCode获取所在企业信息(包含售卖版本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSaleUserInfoByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// GetSaleUserInfoByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSaleUserInfoByUserIdResponse
        /// </returns>
        public GetSaleUserInfoByUserIdResponse GetSaleUserInfoByUserIdWithOptions(GetSaleUserInfoByUserIdRequest request, GetSaleUserInfoByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
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
                Action = "GetSaleUserInfoByUserId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/saleUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaleUserInfoByUserIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户employeeCode获取所在企业信息(包含售卖版本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSaleUserInfoByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// GetSaleUserInfoByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSaleUserInfoByUserIdResponse
        /// </returns>
        public async Task<GetSaleUserInfoByUserIdResponse> GetSaleUserInfoByUserIdWithOptionsAsync(GetSaleUserInfoByUserIdRequest request, GetSaleUserInfoByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
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
                Action = "GetSaleUserInfoByUserId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/saleUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaleUserInfoByUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户employeeCode获取所在企业信息(包含售卖版本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSaleUserInfoByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSaleUserInfoByUserIdResponse
        /// </returns>
        public GetSaleUserInfoByUserIdResponse GetSaleUserInfoByUserId(GetSaleUserInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSaleUserInfoByUserIdHeaders headers = new GetSaleUserInfoByUserIdHeaders();
            return GetSaleUserInfoByUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户employeeCode获取所在企业信息(包含售卖版本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSaleUserInfoByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSaleUserInfoByUserIdResponse
        /// </returns>
        public async Task<GetSaleUserInfoByUserIdResponse> GetSaleUserInfoByUserIdAsync(GetSaleUserInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSaleUserInfoByUserIdHeaders headers = new GetSaleUserInfoByUserIdHeaders();
            return await GetSaleUserInfoByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单的元数据(字段)查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSimpleCubeModelListRequest
        /// </param>
        /// <param name="headers">
        /// GetSimpleCubeModelListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSimpleCubeModelListResponse
        /// </returns>
        public GetSimpleCubeModelListResponse GetSimpleCubeModelListWithOptions(GetSimpleCubeModelListRequest request, GetSimpleCubeModelListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeCode))
            {
                query["cubeCode"] = request.CubeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeTenantId))
            {
                query["cubeTenantId"] = request.CubeTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetSimpleCubeModelList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/simpleCubeModelLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleCubeModelListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单的元数据(字段)查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSimpleCubeModelListRequest
        /// </param>
        /// <param name="headers">
        /// GetSimpleCubeModelListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSimpleCubeModelListResponse
        /// </returns>
        public async Task<GetSimpleCubeModelListResponse> GetSimpleCubeModelListWithOptionsAsync(GetSimpleCubeModelListRequest request, GetSimpleCubeModelListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeCode))
            {
                query["cubeCode"] = request.CubeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeTenantId))
            {
                query["cubeTenantId"] = request.CubeTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetSimpleCubeModelList",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/metadata/simpleCubeModelLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimpleCubeModelListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单的元数据(字段)查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSimpleCubeModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSimpleCubeModelListResponse
        /// </returns>
        public GetSimpleCubeModelListResponse GetSimpleCubeModelList(GetSimpleCubeModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleCubeModelListHeaders headers = new GetSimpleCubeModelListHeaders();
            return GetSimpleCubeModelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单的元数据(字段)查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSimpleCubeModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSimpleCubeModelListResponse
        /// </returns>
        public async Task<GetSimpleCubeModelListResponse> GetSimpleCubeModelListAsync(GetSimpleCubeModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSimpleCubeModelListHeaders headers = new GetSimpleCubeModelListHeaders();
            return await GetSimpleCubeModelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（应用维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskCopiesRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskCopiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskCopiesResponse
        /// </returns>
        public GetTaskCopiesResponse GetTaskCopiesWithOptions(GetTaskCopiesRequest request, GetTaskCopiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetTaskCopies",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/taskCopies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskCopiesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（应用维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskCopiesRequest
        /// </param>
        /// <param name="headers">
        /// GetTaskCopiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskCopiesResponse
        /// </returns>
        public async Task<GetTaskCopiesResponse> GetTaskCopiesWithOptionsAsync(GetTaskCopiesRequest request, GetTaskCopiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                query["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                query["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCodes))
            {
                query["processCodes"] = request.ProcessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "GetTaskCopies",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/taskCopies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskCopiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（应用维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskCopiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskCopiesResponse
        /// </returns>
        public GetTaskCopiesResponse GetTaskCopies(GetTaskCopiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskCopiesHeaders headers = new GetTaskCopiesHeaders();
            return GetTaskCopiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询抄送我的任务列表（应用维度）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskCopiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskCopiesResponse
        /// </returns>
        public async Task<GetTaskCopiesResponse> GetTaskCopiesAsync(GetTaskCopiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskCopiesHeaders headers = new GetTaskCopiesHeaders();
            return await GetTaskCopiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的宜搭应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationResponse
        /// </returns>
        public ListApplicationResponse ListApplicationWithOptions(ListApplicationRequest request, ListApplicationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppFilter))
            {
                query["appFilter"] = request.AppFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppNameSearchKeyword))
            {
                query["appNameSearchKeyword"] = request.AppNameSearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
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
                Action = "ListApplication",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/organizations/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的宜搭应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationResponse
        /// </returns>
        public async Task<ListApplicationResponse> ListApplicationWithOptionsAsync(ListApplicationRequest request, ListApplicationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppFilter))
            {
                query["appFilter"] = request.AppFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppNameSearchKeyword))
            {
                query["appNameSearchKeyword"] = request.AppNameSearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["env"] = request.Env;
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
                Action = "ListApplication",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/organizations/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的宜搭应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationResponse
        /// </returns>
        public ListApplicationResponse ListApplication(ListApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationHeaders headers = new ListApplicationHeaders();
            return ListApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下的宜搭应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationResponse
        /// </returns>
        public async Task<ListApplicationResponse> ListApplicationAsync(ListApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationHeaders headers = new ListApplicationHeaders();
            return await ListApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceApplicationInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationAuthorizationServiceApplicationInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceApplicationInformationResponse
        /// </returns>
        public ListApplicationAuthorizationServiceApplicationInformationResponse ListApplicationAuthorizationServiceApplicationInformationWithOptions(string instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request, ListApplicationAuthorizationServiceApplicationInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                query["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationAuthorizationServiceApplicationInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/applicationInfos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationAuthorizationServiceApplicationInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceApplicationInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationAuthorizationServiceApplicationInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceApplicationInformationResponse
        /// </returns>
        public async Task<ListApplicationAuthorizationServiceApplicationInformationResponse> ListApplicationAuthorizationServiceApplicationInformationWithOptionsAsync(string instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request, ListApplicationAuthorizationServiceApplicationInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                query["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationAuthorizationServiceApplicationInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/applicationInfos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationAuthorizationServiceApplicationInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceApplicationInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceApplicationInformationResponse
        /// </returns>
        public ListApplicationAuthorizationServiceApplicationInformationResponse ListApplicationAuthorizationServiceApplicationInformation(string instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationAuthorizationServiceApplicationInformationHeaders headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders();
            return ListApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceApplicationInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceApplicationInformationResponse
        /// </returns>
        public async Task<ListApplicationAuthorizationServiceApplicationInformationResponse> ListApplicationAuthorizationServiceApplicationInformationAsync(string instanceId, ListApplicationAuthorizationServiceApplicationInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationAuthorizationServiceApplicationInformationHeaders headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders();
            return await ListApplicationAuthorizationServiceApplicationInformationWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceConnectorInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationAuthorizationServiceConnectorInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceConnectorInformationResponse
        /// </returns>
        public ListApplicationAuthorizationServiceConnectorInformationResponse ListApplicationAuthorizationServiceConnectorInformationWithOptions(string instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request, ListApplicationAuthorizationServiceConnectorInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationAuthorizationServiceConnectorInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/plugs/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationAuthorizationServiceConnectorInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceConnectorInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationAuthorizationServiceConnectorInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceConnectorInformationResponse
        /// </returns>
        public async Task<ListApplicationAuthorizationServiceConnectorInformationResponse> ListApplicationAuthorizationServiceConnectorInformationWithOptionsAsync(string instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request, ListApplicationAuthorizationServiceConnectorInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationAuthorizationServiceConnectorInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/plugs/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationAuthorizationServiceConnectorInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceConnectorInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceConnectorInformationResponse
        /// </returns>
        public ListApplicationAuthorizationServiceConnectorInformationResponse ListApplicationAuthorizationServiceConnectorInformation(string instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationAuthorizationServiceConnectorInformationHeaders headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders();
            return ListApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAuthorizationServiceConnectorInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAuthorizationServiceConnectorInformationResponse
        /// </returns>
        public async Task<ListApplicationAuthorizationServiceConnectorInformationResponse> ListApplicationAuthorizationServiceConnectorInformationAsync(string instanceId, ListApplicationAuthorizationServiceConnectorInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationAuthorizationServiceConnectorInformationHeaders headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders();
            return await ListApplicationAuthorizationServiceConnectorInformationWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationInformationResponse
        /// </returns>
        public ListApplicationInformationResponse ListApplicationInformationWithOptions(string instanceId, ListApplicationInformationRequest request, ListApplicationInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/infos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListApplicationInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationInformationResponse
        /// </returns>
        public async Task<ListApplicationInformationResponse> ListApplicationInformationWithOptionsAsync(string instanceId, ListApplicationInformationRequest request, ListApplicationInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApplicationInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/infos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationInformationResponse
        /// </returns>
        public ListApplicationInformationResponse ListApplicationInformation(string instanceId, ListApplicationInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationInformationHeaders headers = new ListApplicationInformationHeaders();
            return ListApplicationInformationWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道应用概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationInformationResponse
        /// </returns>
        public async Task<ListApplicationInformationResponse> ListApplicationInformationAsync(string instanceId, ListApplicationInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListApplicationInformationHeaders headers = new ListApplicationInformationHeaders();
            return await ListApplicationInformationWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道列出商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ListCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommodityResponse
        /// </returns>
        public ListCommodityResponse ListCommodityWithOptions(ListCommodityRequest request, ListCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommodityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道列出商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ListCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommodityResponse
        /// </returns>
        public async Task<ListCommodityResponse> ListCommodityWithOptionsAsync(ListCommodityRequest request, ListCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommodityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道列出商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommodityResponse
        /// </returns>
        public ListCommodityResponse ListCommodity(ListCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommodityHeaders headers = new ListCommodityHeaders();
            return ListCommodityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道列出商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommodityResponse
        /// </returns>
        public async Task<ListCommodityResponse> ListCommodityAsync(ListCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommodityHeaders headers = new ListCommodityHeaders();
            return await ListCommodityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListConnectorInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorInformationResponse
        /// </returns>
        public ListConnectorInformationResponse ListConnectorInformationWithOptions(string instanceId, ListConnectorInformationRequest request, ListConnectorInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListConnectorInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/plugins/infos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectorInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorInformationRequest
        /// </param>
        /// <param name="headers">
        /// ListConnectorInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorInformationResponse
        /// </returns>
        public async Task<ListConnectorInformationResponse> ListConnectorInformationWithOptionsAsync(string instanceId, ListConnectorInformationRequest request, ListConnectorInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListConnectorInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/plugins/infos/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectorInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorInformationResponse
        /// </returns>
        public ListConnectorInformationResponse ListConnectorInformation(string instanceId, ListConnectorInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListConnectorInformationHeaders headers = new ListConnectorInformationHeaders();
            return ListConnectorInformationWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道插件概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorInformationResponse
        /// </returns>
        public async Task<ListConnectorInformationResponse> ListConnectorInformationAsync(string instanceId, ListConnectorInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListConnectorInformationHeaders headers = new ListConnectorInformationHeaders();
            return await ListConnectorInformationWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFormRemarksRequest
        /// </param>
        /// <param name="headers">
        /// ListFormRemarksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFormRemarksResponse
        /// </returns>
        public ListFormRemarksResponse ListFormRemarksWithOptions(ListFormRemarksRequest request, ListFormRemarksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ListFormRemarks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/remarks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFormRemarksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFormRemarksRequest
        /// </param>
        /// <param name="headers">
        /// ListFormRemarksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFormRemarksResponse
        /// </returns>
        public async Task<ListFormRemarksResponse> ListFormRemarksWithOptionsAsync(ListFormRemarksRequest request, ListFormRemarksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ListFormRemarks",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/remarks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFormRemarksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFormRemarksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFormRemarksResponse
        /// </returns>
        public ListFormRemarksResponse ListFormRemarks(ListFormRemarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFormRemarksHeaders headers = new ListFormRemarksHeaders();
            return ListFormRemarksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFormRemarksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFormRemarksResponse
        /// </returns>
        public async Task<ListFormRemarksResponse> ListFormRemarksAsync(ListFormRemarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFormRemarksHeaders headers = new ListFormRemarksHeaders();
            return await ListFormRemarksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用下的页面列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNavigationByFormTypeRequest
        /// </param>
        /// <param name="headers">
        /// ListNavigationByFormTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNavigationByFormTypeResponse
        /// </returns>
        public ListNavigationByFormTypeResponse ListNavigationByFormTypeWithOptions(ListNavigationByFormTypeRequest request, ListNavigationByFormTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormType))
            {
                query["formType"] = request.FormType;
            }
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
                Action = "ListNavigationByFormType",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/navigations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNavigationByFormTypeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用下的页面列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNavigationByFormTypeRequest
        /// </param>
        /// <param name="headers">
        /// ListNavigationByFormTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNavigationByFormTypeResponse
        /// </returns>
        public async Task<ListNavigationByFormTypeResponse> ListNavigationByFormTypeWithOptionsAsync(ListNavigationByFormTypeRequest request, ListNavigationByFormTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormType))
            {
                query["formType"] = request.FormType;
            }
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
                Action = "ListNavigationByFormType",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/navigations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNavigationByFormTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用下的页面列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNavigationByFormTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNavigationByFormTypeResponse
        /// </returns>
        public ListNavigationByFormTypeResponse ListNavigationByFormType(ListNavigationByFormTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNavigationByFormTypeHeaders headers = new ListNavigationByFormTypeHeaders();
            return ListNavigationByFormTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用下的页面列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNavigationByFormTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNavigationByFormTypeResponse
        /// </returns>
        public async Task<ListNavigationByFormTypeResponse> ListNavigationByFormTypeAsync(ListNavigationByFormTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNavigationByFormTypeHeaders headers = new ListNavigationByFormTypeHeaders();
            return await ListNavigationByFormTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationLogsRequest
        /// </param>
        /// <param name="headers">
        /// ListOperationLogsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationLogsResponse
        /// </returns>
        public ListOperationLogsResponse ListOperationLogsWithOptions(ListOperationLogsRequest request, ListOperationLogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ListOperationLogs",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/operationsLogs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationLogsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationLogsRequest
        /// </param>
        /// <param name="headers">
        /// ListOperationLogsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOperationLogsResponse
        /// </returns>
        public async Task<ListOperationLogsResponse> ListOperationLogsWithOptionsAsync(ListOperationLogsRequest request, ListOperationLogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceIdList))
            {
                body["formInstanceIdList"] = request.FormInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "ListOperationLogs",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/operationsLogs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationLogsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationLogsResponse
        /// </returns>
        public ListOperationLogsResponse ListOperationLogs(ListOperationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOperationLogsHeaders headers = new ListOperationLogsHeaders();
            return ListOperationLogsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单的变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOperationLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOperationLogsResponse
        /// </returns>
        public async Task<ListOperationLogsResponse> ListOperationLogsAsync(ListOperationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOperationLogsHeaders headers = new ListOperationLogsHeaders();
            return await ListOperationLogsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDataByFormInstanceIdTableIdRequest
        /// </param>
        /// <param name="headers">
        /// ListTableDataByFormInstanceIdTableIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableDataByFormInstanceIdTableIdResponse
        /// </returns>
        public ListTableDataByFormInstanceIdTableIdResponse ListTableDataByFormInstanceIdTableIdWithOptions(string formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request, ListTableDataByFormInstanceIdTableIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFieldId))
            {
                query["tableFieldId"] = request.TableFieldId;
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
                Action = "ListTableDataByFormInstanceIdTableId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/innerTables/" + formInstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableDataByFormInstanceIdTableIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDataByFormInstanceIdTableIdRequest
        /// </param>
        /// <param name="headers">
        /// ListTableDataByFormInstanceIdTableIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableDataByFormInstanceIdTableIdResponse
        /// </returns>
        public async Task<ListTableDataByFormInstanceIdTableIdResponse> ListTableDataByFormInstanceIdTableIdWithOptionsAsync(string formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request, ListTableDataByFormInstanceIdTableIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFieldId))
            {
                query["tableFieldId"] = request.TableFieldId;
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
                Action = "ListTableDataByFormInstanceIdTableId",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/innerTables/" + formInstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableDataByFormInstanceIdTableIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDataByFormInstanceIdTableIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableDataByFormInstanceIdTableIdResponse
        /// </returns>
        public ListTableDataByFormInstanceIdTableIdResponse ListTableDataByFormInstanceIdTableId(string formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTableDataByFormInstanceIdTableIdHeaders headers = new ListTableDataByFormInstanceIdTableIdHeaders();
            return ListTableDataByFormInstanceIdTableIdWithOptions(formInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取子表单数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDataByFormInstanceIdTableIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableDataByFormInstanceIdTableIdResponse
        /// </returns>
        public async Task<ListTableDataByFormInstanceIdTableIdResponse> ListTableDataByFormInstanceIdTableIdAsync(string formInstanceId, ListTableDataByFormInstanceIdTableIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTableDataByFormInstanceIdTableIdHeaders headers = new ListTableDataByFormInstanceIdTableIdHeaders();
            return await ListTableDataByFormInstanceIdTableIdWithOptionsAsync(formInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成宜搭登录态穿透用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoginCodeGenRequest
        /// </param>
        /// <param name="headers">
        /// LoginCodeGenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoginCodeGenResponse
        /// </returns>
        public LoginCodeGenResponse LoginCodeGenWithOptions(LoginCodeGenRequest request, LoginCodeGenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "LoginCodeGen",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/loginCodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginCodeGenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成宜搭登录态穿透用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoginCodeGenRequest
        /// </param>
        /// <param name="headers">
        /// LoginCodeGenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoginCodeGenResponse
        /// </returns>
        public async Task<LoginCodeGenResponse> LoginCodeGenWithOptionsAsync(LoginCodeGenRequest request, LoginCodeGenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "LoginCodeGen",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/authorizations/loginCodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginCodeGenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成宜搭登录态穿透用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoginCodeGenRequest
        /// </param>
        /// 
        /// <returns>
        /// LoginCodeGenResponse
        /// </returns>
        public LoginCodeGenResponse LoginCodeGen(LoginCodeGenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoginCodeGenHeaders headers = new LoginCodeGenHeaders();
            return LoginCodeGenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成宜搭登录态穿透用的code</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LoginCodeGenRequest
        /// </param>
        /// 
        /// <returns>
        /// LoginCodeGenResponse
        /// </returns>
        public async Task<LoginCodeGenResponse> LoginCodeGenAsync(LoginCodeGenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoginCodeGenHeaders headers = new LoginCodeGenHeaders();
            return await LoginCodeGenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知宜搭授权(购买)结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyAuthorizationResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyAuthorizationResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyAuthorizationResultResponse
        /// </returns>
        public NotifyAuthorizationResultResponse NotifyAuthorizationResultWithOptions(NotifyAuthorizationResultRequest request, NotifyAuthorizationResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "NotifyAuthorizationResult",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/authorizationResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyAuthorizationResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知宜搭授权(购买)结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyAuthorizationResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyAuthorizationResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyAuthorizationResultResponse
        /// </returns>
        public async Task<NotifyAuthorizationResultResponse> NotifyAuthorizationResultWithOptionsAsync(NotifyAuthorizationResultRequest request, NotifyAuthorizationResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeGMT))
            {
                body["beginTimeGMT"] = request.BeginTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommerceType))
            {
                body["commerceType"] = request.CommerceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceCode))
            {
                body["produceCode"] = request.ProduceCode;
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
                Action = "NotifyAuthorizationResult",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/authorizationResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyAuthorizationResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知宜搭授权(购买)结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyAuthorizationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyAuthorizationResultResponse
        /// </returns>
        public NotifyAuthorizationResultResponse NotifyAuthorizationResult(NotifyAuthorizationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyAuthorizationResultHeaders headers = new NotifyAuthorizationResultHeaders();
            return NotifyAuthorizationResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知宜搭授权(购买)结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyAuthorizationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyAuthorizationResultResponse
        /// </returns>
        public async Task<NotifyAuthorizationResultResponse> NotifyAuthorizationResultAsync(NotifyAuthorizationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyAuthorizationResultHeaders headers = new NotifyAuthorizationResultHeaders();
            return await NotifyAuthorizationResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询宜搭流程自动化运行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageAutoFlowLogRequest
        /// </param>
        /// <param name="headers">
        /// PageAutoFlowLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageAutoFlowLogResponse
        /// </returns>
        public PageAutoFlowLogResponse PageAutoFlowLogWithOptions(PageAutoFlowLogRequest request, PageAutoFlowLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeGMT))
            {
                body["startTimeGMT"] = request.StartTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "PageAutoFlowLog",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/logs/automations/paginationQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageAutoFlowLogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询宜搭流程自动化运行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageAutoFlowLogRequest
        /// </param>
        /// <param name="headers">
        /// PageAutoFlowLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageAutoFlowLogResponse
        /// </returns>
        public async Task<PageAutoFlowLogResponse> PageAutoFlowLogWithOptionsAsync(PageAutoFlowLogRequest request, PageAutoFlowLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                body["env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeGMT))
            {
                body["startTimeGMT"] = request.StartTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "PageAutoFlowLog",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/logs/automations/paginationQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageAutoFlowLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询宜搭流程自动化运行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageAutoFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// PageAutoFlowLogResponse
        /// </returns>
        public PageAutoFlowLogResponse PageAutoFlowLog(PageAutoFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageAutoFlowLogHeaders headers = new PageAutoFlowLogHeaders();
            return PageAutoFlowLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询宜搭流程自动化运行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageAutoFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// PageAutoFlowLogResponse
        /// </returns>
        public async Task<PageAutoFlowLogResponse> PageAutoFlowLogAsync(PageAutoFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageAutoFlowLogHeaders headers = new PageAutoFlowLogHeaders();
            return await PageAutoFlowLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取应用下表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageFormBaseInfosRequest
        /// </param>
        /// <param name="headers">
        /// PageFormBaseInfosHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageFormBaseInfosResponse
        /// </returns>
        public PageFormBaseInfosResponse PageFormBaseInfosWithOptions(PageFormBaseInfosRequest request, PageFormBaseInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormTypeList))
            {
                body["formTypeList"] = request.FormTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "PageFormBaseInfos",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/forms/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageFormBaseInfosResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取应用下表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageFormBaseInfosRequest
        /// </param>
        /// <param name="headers">
        /// PageFormBaseInfosHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageFormBaseInfosResponse
        /// </returns>
        public async Task<PageFormBaseInfosResponse> PageFormBaseInfosWithOptionsAsync(PageFormBaseInfosRequest request, PageFormBaseInfosHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormTypeList))
            {
                body["formTypeList"] = request.FormTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "PageFormBaseInfos",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/forms/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageFormBaseInfosResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取应用下表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageFormBaseInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// PageFormBaseInfosResponse
        /// </returns>
        public PageFormBaseInfosResponse PageFormBaseInfos(PageFormBaseInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageFormBaseInfosHeaders headers = new PageFormBaseInfosHeaders();
            return PageFormBaseInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取应用下表单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageFormBaseInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// PageFormBaseInfosResponse
        /// </returns>
        public async Task<PageFormBaseInfosResponse> PageFormBaseInfosAsync(PageFormBaseInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageFormBaseInfosHeaders headers = new PageFormBaseInfosHeaders();
            return await PageFormBaseInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewPublishedProcessRequest
        /// </param>
        /// <param name="headers">
        /// PreviewPublishedProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewPublishedProcessResponse
        /// </returns>
        public PreviewPublishedProcessResponse PreviewPublishedProcessWithOptions(PreviewPublishedProcessRequest request, PreviewPublishedProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "PreviewPublishedProcess",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewPublishedProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewPublishedProcessRequest
        /// </param>
        /// <param name="headers">
        /// PreviewPublishedProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewPublishedProcessResponse
        /// </returns>
        public async Task<PreviewPublishedProcessResponse> PreviewPublishedProcessWithOptionsAsync(PreviewPublishedProcessRequest request, PreviewPublishedProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "PreviewPublishedProcess",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewPublishedProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewPublishedProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewPublishedProcessResponse
        /// </returns>
        public PreviewPublishedProcessResponse PreviewPublishedProcess(PreviewPublishedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviewPublishedProcessHeaders headers = new PreviewPublishedProcessHeaders();
            return PreviewPublishedProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewPublishedProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewPublishedProcessResponse
        /// </returns>
        public async Task<PreviewPublishedProcessResponse> PreviewPublishedProcessAsync(PreviewPublishedProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviewPublishedProcessHeaders headers = new PreviewPublishedProcessHeaders();
            return await PreviewPublishedProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryServiceRecordRequest
        /// </param>
        /// <param name="headers">
        /// QueryServiceRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryServiceRecordResponse
        /// </returns>
        public QueryServiceRecordResponse QueryServiceRecordWithOptions(QueryServiceRecordRequest request, QueryServiceRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HookType))
            {
                query["hookType"] = request.HookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HookUuid))
            {
                query["hookUuid"] = request.HookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeAfterDateGMT))
            {
                query["invokeAfterDateGMT"] = request.InvokeAfterDateGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeBeforeDateGMT))
            {
                query["invokeBeforeDateGMT"] = request.InvokeBeforeDateGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeStatus))
            {
                query["invokeStatus"] = request.InvokeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUrl))
            {
                query["requestUrl"] = request.RequestUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUuid))
            {
                query["sourceUuid"] = request.SourceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "QueryServiceRecord",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/services/invocationRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServiceRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryServiceRecordRequest
        /// </param>
        /// <param name="headers">
        /// QueryServiceRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryServiceRecordResponse
        /// </returns>
        public async Task<QueryServiceRecordResponse> QueryServiceRecordWithOptionsAsync(QueryServiceRecordRequest request, QueryServiceRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HookType))
            {
                query["hookType"] = request.HookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HookUuid))
            {
                query["hookUuid"] = request.HookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeAfterDateGMT))
            {
                query["invokeAfterDateGMT"] = request.InvokeAfterDateGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeBeforeDateGMT))
            {
                query["invokeBeforeDateGMT"] = request.InvokeBeforeDateGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeStatus))
            {
                query["invokeStatus"] = request.InvokeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUrl))
            {
                query["requestUrl"] = request.RequestUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUuid))
            {
                query["sourceUuid"] = request.SourceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "QueryServiceRecord",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/services/invocationRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServiceRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryServiceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryServiceRecordResponse
        /// </returns>
        public QueryServiceRecordResponse QueryServiceRecord(QueryServiceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryServiceRecordHeaders headers = new QueryServiceRecordHeaders();
            return QueryServiceRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryServiceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryServiceRecordResponse
        /// </returns>
        public async Task<QueryServiceRecordResponse> QueryServiceRecordAsync(QueryServiceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryServiceRecordHeaders headers = new QueryServiceRecordHeaders();
            return await QueryServiceRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行转交任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectTaskRequest
        /// </param>
        /// <param name="headers">
        /// RedirectTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedirectTaskResponse
        /// </returns>
        public RedirectTaskResponse RedirectTaskWithOptions(RedirectTaskRequest request, RedirectTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByManager))
            {
                body["byManager"] = request.ByManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NowActionExecutorId))
            {
                body["nowActionExecutorId"] = request.NowActionExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "RedirectTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/redirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RedirectTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行转交任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectTaskRequest
        /// </param>
        /// <param name="headers">
        /// RedirectTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedirectTaskResponse
        /// </returns>
        public async Task<RedirectTaskResponse> RedirectTaskWithOptionsAsync(RedirectTaskRequest request, RedirectTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByManager))
            {
                body["byManager"] = request.ByManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NowActionExecutorId))
            {
                body["nowActionExecutorId"] = request.NowActionExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "RedirectTask",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/tasks/redirect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RedirectTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行转交任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RedirectTaskResponse
        /// </returns>
        public RedirectTaskResponse RedirectTask(RedirectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectTaskHeaders headers = new RedirectTaskHeaders();
            return RedirectTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行转交任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RedirectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RedirectTaskResponse
        /// </returns>
        public async Task<RedirectTaskResponse> RedirectTaskAsync(RedirectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RedirectTaskHeaders headers = new RedirectTaskHeaders();
            return await RedirectTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundCommodityRequest
        /// </param>
        /// <param name="headers">
        /// RefundCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundCommodityResponse
        /// </returns>
        public RefundCommodityResponse RefundCommodityWithOptions(RefundCommodityRequest request, RefundCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "RefundCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundCommodityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundCommodityRequest
        /// </param>
        /// <param name="headers">
        /// RefundCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundCommodityResponse
        /// </returns>
        public async Task<RefundCommodityResponse> RefundCommodityWithOptionsAsync(RefundCommodityRequest request, RefundCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "RefundCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundCommodityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundCommodityResponse
        /// </returns>
        public RefundCommodityResponse RefundCommodity(RefundCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundCommodityHeaders headers = new RefundCommodityHeaders();
            return RefundCommodityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundCommodityResponse
        /// </returns>
        public async Task<RefundCommodityResponse> RefundCommodityAsync(RefundCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundCommodityHeaders headers = new RefundCommodityHeaders();
            return await RefundCommodityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountsRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAccountsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountsResponse
        /// </returns>
        public RegisterAccountsResponse RegisterAccountsWithOptions(RegisterAccountsRequest request, RegisterAccountsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveCode))
            {
                body["activeCode"] = request.ActiveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
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
                Action = "RegisterAccounts",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/accounts/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAccountsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountsRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAccountsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountsResponse
        /// </returns>
        public async Task<RegisterAccountsResponse> RegisterAccountsWithOptionsAsync(RegisterAccountsRequest request, RegisterAccountsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveCode))
            {
                body["activeCode"] = request.ActiveCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
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
                Action = "RegisterAccounts",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/accounts/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAccountsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountsResponse
        /// </returns>
        public RegisterAccountsResponse RegisterAccounts(RegisterAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAccountsHeaders headers = new RegisterAccountsHeaders();
            return RegisterAccountsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountsResponse
        /// </returns>
        public async Task<RegisterAccountsResponse> RegisterAccountsAsync(RegisterAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAccountsHeaders headers = new RegisterAccountsHeaders();
            return await RegisterAccountsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道释放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseCommodityResponse
        /// </returns>
        public ReleaseCommodityResponse ReleaseCommodityWithOptions(ReleaseCommodityRequest request, ReleaseCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ReleaseCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/release",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCommodityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道释放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseCommodityRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseCommodityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseCommodityResponse
        /// </returns>
        public async Task<ReleaseCommodityResponse> ReleaseCommodityWithOptionsAsync(ReleaseCommodityRequest request, ReleaseCommodityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ReleaseCommodity",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appAuth/commodities/release",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCommodityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道释放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseCommodityResponse
        /// </returns>
        public ReleaseCommodityResponse ReleaseCommodity(ReleaseCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseCommodityHeaders headers = new ReleaseCommodityHeaders();
            return ReleaseCommodityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道释放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseCommodityResponse
        /// </returns>
        public async Task<ReleaseCommodityResponse> ReleaseCommodityAsync(ReleaseCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseCommodityHeaders headers = new ReleaseCommodityHeaders();
            return await ReleaseCommodityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户到期30天后, 删除租户关联的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantResourceRequest
        /// </param>
        /// <param name="headers">
        /// RemoveTenantResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantResourceResponse
        /// </returns>
        public RemoveTenantResourceResponse RemoveTenantResourceWithOptions(string callerUid, RemoveTenantResourceRequest request, RemoveTenantResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "RemoveTenantResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/tenantRelatedResources/" + callerUid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTenantResourceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户到期30天后, 删除租户关联的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantResourceRequest
        /// </param>
        /// <param name="headers">
        /// RemoveTenantResourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantResourceResponse
        /// </returns>
        public async Task<RemoveTenantResourceResponse> RemoveTenantResourceWithOptionsAsync(string callerUid, RemoveTenantResourceRequest request, RemoveTenantResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "RemoveTenantResource",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/tenantRelatedResources/" + callerUid,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTenantResourceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户到期30天后, 删除租户关联的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantResourceResponse
        /// </returns>
        public RemoveTenantResourceResponse RemoveTenantResource(string callerUid, RemoveTenantResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveTenantResourceHeaders headers = new RemoveTenantResourceHeaders();
            return RemoveTenantResourceWithOptions(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>租户到期30天后, 删除租户关联的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantResourceResponse
        /// </returns>
        public async Task<RemoveTenantResourceResponse> RemoveTenantResourceAsync(string callerUid, RemoveTenantResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveTenantResourceHeaders headers = new RemoveTenantResourceHeaders();
            return await RemoveTenantResourceWithOptionsAsync(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>宜搭vpc批量打印回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderBatchCallbackRequest
        /// </param>
        /// <param name="headers">
        /// RenderBatchCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderBatchCallbackResponse
        /// </returns>
        public RenderBatchCallbackResponse RenderBatchCallbackWithOptions(RenderBatchCallbackRequest request, RenderBatchCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["ossUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceId))
            {
                body["sequenceId"] = request.SequenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["timeZone"] = request.TimeZone;
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
                Action = "RenderBatchCallback",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printings/callbacks/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderBatchCallbackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>宜搭vpc批量打印回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderBatchCallbackRequest
        /// </param>
        /// <param name="headers">
        /// RenderBatchCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderBatchCallbackResponse
        /// </returns>
        public async Task<RenderBatchCallbackResponse> RenderBatchCallbackWithOptionsAsync(RenderBatchCallbackRequest request, RenderBatchCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["ossUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceId))
            {
                body["sequenceId"] = request.SequenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["timeZone"] = request.TimeZone;
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
                Action = "RenderBatchCallback",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printings/callbacks/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderBatchCallbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>宜搭vpc批量打印回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderBatchCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderBatchCallbackResponse
        /// </returns>
        public RenderBatchCallbackResponse RenderBatchCallback(RenderBatchCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenderBatchCallbackHeaders headers = new RenderBatchCallbackHeaders();
            return RenderBatchCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>宜搭vpc批量打印回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderBatchCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderBatchCallbackResponse
        /// </returns>
        public async Task<RenderBatchCallbackResponse> RenderBatchCallbackAsync(RenderBatchCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenderBatchCallbackHeaders headers = new RenderBatchCallbackHeaders();
            return await RenderBatchCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// <param name="headers">
        /// RenewApplicationAuthorizationServiceOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public RenewApplicationAuthorizationServiceOrderResponse RenewApplicationAuthorizationServiceOrderWithOptions(RenewApplicationAuthorizationServiceOrderRequest request, RenewApplicationAuthorizationServiceOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "RenewApplicationAuthorizationServiceOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/orders/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewApplicationAuthorizationServiceOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// <param name="headers">
        /// RenewApplicationAuthorizationServiceOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public async Task<RenewApplicationAuthorizationServiceOrderResponse> RenewApplicationAuthorizationServiceOrderWithOptionsAsync(RenewApplicationAuthorizationServiceOrderRequest request, RenewApplicationAuthorizationServiceOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "RenewApplicationAuthorizationServiceOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationAuthorizations/orders/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewApplicationAuthorizationServiceOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public RenewApplicationAuthorizationServiceOrderResponse RenewApplicationAuthorizationServiceOrder(RenewApplicationAuthorizationServiceOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenewApplicationAuthorizationServiceOrderHeaders headers = new RenewApplicationAuthorizationServiceOrderHeaders();
            return RenewApplicationAuthorizationServiceOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public async Task<RenewApplicationAuthorizationServiceOrderResponse> RenewApplicationAuthorizationServiceOrderAsync(RenewApplicationAuthorizationServiceOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenewApplicationAuthorizationServiceOrderHeaders headers = new RenewApplicationAuthorizationServiceOrderHeaders();
            return await RenewApplicationAuthorizationServiceOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费租户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewTenantOrderRequest
        /// </param>
        /// <param name="headers">
        /// RenewTenantOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewTenantOrderResponse
        /// </returns>
        public RenewTenantOrderResponse RenewTenantOrderWithOptions(RenewTenantOrderRequest request, RenewTenantOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
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
                Action = "RenewTenantOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/tenants/reorder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewTenantOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费租户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewTenantOrderRequest
        /// </param>
        /// <param name="headers">
        /// RenewTenantOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewTenantOrderResponse
        /// </returns>
        public async Task<RenewTenantOrderResponse> RenewTenantOrderWithOptionsAsync(RenewTenantOrderRequest request, RenewTenantOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeGMT))
            {
                body["endTimeGMT"] = request.EndTimeGMT;
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
                Action = "RenewTenantOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/tenants/reorder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewTenantOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费租户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewTenantOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewTenantOrderResponse
        /// </returns>
        public RenewTenantOrderResponse RenewTenantOrder(RenewTenantOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenewTenantOrderHeaders headers = new RenewTenantOrderHeaders();
            return RenewTenantOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费租户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewTenantOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewTenantOrderResponse
        /// </returns>
        public async Task<RenewTenantOrderResponse> RenewTenantOrderAsync(RenewTenantOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RenewTenantOrderHeaders headers = new RenewTenantOrderHeaders();
            return await RenewTenantOrderWithOptionsAsync(request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
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
        /// <para>提交表单/流程实例下的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormRemarkRequest
        /// </param>
        /// <param name="headers">
        /// SaveFormRemarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveFormRemarkResponse
        /// </returns>
        public SaveFormRemarkResponse SaveFormRemarkWithOptions(SaveFormRemarkRequest request, SaveFormRemarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUserId))
            {
                body["atUserId"] = request.AtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyId))
            {
                body["replyId"] = request.ReplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "SaveFormRemark",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/remarks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormRemarkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交表单/流程实例下的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormRemarkRequest
        /// </param>
        /// <param name="headers">
        /// SaveFormRemarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveFormRemarkResponse
        /// </returns>
        public async Task<SaveFormRemarkResponse> SaveFormRemarkWithOptionsAsync(SaveFormRemarkRequest request, SaveFormRemarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUserId))
            {
                body["atUserId"] = request.AtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyId))
            {
                body["replyId"] = request.ReplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "SaveFormRemark",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/remarks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormRemarkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交表单/流程实例下的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveFormRemarkResponse
        /// </returns>
        public SaveFormRemarkResponse SaveFormRemark(SaveFormRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormRemarkHeaders headers = new SaveFormRemarkHeaders();
            return SaveFormRemarkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交表单/流程实例下的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveFormRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveFormRemarkResponse
        /// </returns>
        public async Task<SaveFormRemarkResponse> SaveFormRemarkAsync(SaveFormRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormRemarkHeaders headers = new SaveFormRemarkHeaders();
            return await SaveFormRemarkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户设计的模板结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePrintTplDetailInfoRequest
        /// </param>
        /// <param name="headers">
        /// SavePrintTplDetailInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SavePrintTplDetailInfoResponse
        /// </returns>
        public SavePrintTplDetailInfoResponse SavePrintTplDetailInfoWithOptions(SavePrintTplDetailInfoRequest request, SavePrintTplDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameConfig))
            {
                body["fileNameConfig"] = request.FileNameConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormVersion))
            {
                body["formVersion"] = request.FormVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Setting))
            {
                body["setting"] = request.Setting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vm))
            {
                body["vm"] = request.Vm;
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
                Action = "SavePrintTplDetailInfo",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printTplDetailInfos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SavePrintTplDetailInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户设计的模板结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePrintTplDetailInfoRequest
        /// </param>
        /// <param name="headers">
        /// SavePrintTplDetailInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SavePrintTplDetailInfoResponse
        /// </returns>
        public async Task<SavePrintTplDetailInfoResponse> SavePrintTplDetailInfoWithOptionsAsync(SavePrintTplDetailInfoRequest request, SavePrintTplDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameConfig))
            {
                body["fileNameConfig"] = request.FileNameConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormVersion))
            {
                body["formVersion"] = request.FormVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Setting))
            {
                body["setting"] = request.Setting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vm))
            {
                body["vm"] = request.Vm;
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
                Action = "SavePrintTplDetailInfo",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/printTemplates/printTplDetailInfos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SavePrintTplDetailInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户设计的模板结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePrintTplDetailInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SavePrintTplDetailInfoResponse
        /// </returns>
        public SavePrintTplDetailInfoResponse SavePrintTplDetailInfo(SavePrintTplDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SavePrintTplDetailInfoHeaders headers = new SavePrintTplDetailInfoHeaders();
            return SavePrintTplDetailInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户设计的模板结构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePrintTplDetailInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SavePrintTplDetailInfoResponse
        /// </returns>
        public async Task<SavePrintTplDetailInfoResponse> SavePrintTplDetailInfoAsync(SavePrintTplDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SavePrintTplDetailInfoHeaders headers = new SavePrintTplDetailInfoHeaders();
            return await SavePrintTplDetailInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取阿里云账号购买宜搭的账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchActivationCodeRequest
        /// </param>
        /// <param name="headers">
        /// SearchActivationCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchActivationCodeResponse
        /// </returns>
        public SearchActivationCodeResponse SearchActivationCodeWithOptions(SearchActivationCodeRequest request, SearchActivationCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "SearchActivationCode",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/activationCode/information",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchActivationCodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取阿里云账号购买宜搭的账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchActivationCodeRequest
        /// </param>
        /// <param name="headers">
        /// SearchActivationCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchActivationCodeResponse
        /// </returns>
        public async Task<SearchActivationCodeResponse> SearchActivationCodeWithOptionsAsync(SearchActivationCodeRequest request, SearchActivationCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "SearchActivationCode",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/activationCode/information",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchActivationCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取阿里云账号购买宜搭的账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchActivationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchActivationCodeResponse
        /// </returns>
        public SearchActivationCodeResponse SearchActivationCode(SearchActivationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActivationCodeHeaders headers = new SearchActivationCodeHeaders();
            return SearchActivationCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取阿里云账号购买宜搭的账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchActivationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchActivationCodeResponse
        /// </returns>
        public async Task<SearchActivationCodeResponse> SearchActivationCodeAsync(SearchActivationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActivationCodeHeaders headers = new SearchActivationCodeHeaders();
            return await SearchActivationCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索表单中指定人员组件的值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchEmployeeFieldValuesRequest
        /// </param>
        /// <param name="headers">
        /// SearchEmployeeFieldValuesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchEmployeeFieldValuesResponse
        /// </returns>
        public SearchEmployeeFieldValuesResponse SearchEmployeeFieldValuesWithOptions(SearchEmployeeFieldValuesRequest request, SearchEmployeeFieldValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFieldJson))
            {
                body["targetFieldJson"] = request.TargetFieldJson;
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
                Action = "SearchEmployeeFieldValues",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/employeeFields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchEmployeeFieldValuesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索表单中指定人员组件的值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchEmployeeFieldValuesRequest
        /// </param>
        /// <param name="headers">
        /// SearchEmployeeFieldValuesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchEmployeeFieldValuesResponse
        /// </returns>
        public async Task<SearchEmployeeFieldValuesResponse> SearchEmployeeFieldValuesWithOptionsAsync(SearchEmployeeFieldValuesRequest request, SearchEmployeeFieldValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFieldJson))
            {
                body["targetFieldJson"] = request.TargetFieldJson;
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
                Action = "SearchEmployeeFieldValues",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/employeeFields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchEmployeeFieldValuesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索表单中指定人员组件的值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchEmployeeFieldValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchEmployeeFieldValuesResponse
        /// </returns>
        public SearchEmployeeFieldValuesResponse SearchEmployeeFieldValues(SearchEmployeeFieldValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchEmployeeFieldValuesHeaders headers = new SearchEmployeeFieldValuesHeaders();
            return SearchEmployeeFieldValuesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索表单中指定人员组件的值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchEmployeeFieldValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchEmployeeFieldValuesResponse
        /// </returns>
        public async Task<SearchEmployeeFieldValuesResponse> SearchEmployeeFieldValuesAsync(SearchEmployeeFieldValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchEmployeeFieldValuesHeaders headers = new SearchEmployeeFieldValuesHeaders();
            return await SearchEmployeeFieldValuesWithOptionsAsync(request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
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
        /// <para>查询表单实例数据(不返回表单的子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataRemovalTableDataRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataRemovalTableDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataRemovalTableDataResponse
        /// </returns>
        public SearchFormDataRemovalTableDataResponse SearchFormDataRemovalTableDataWithOptions(SearchFormDataRemovalTableDataRequest request, SearchFormDataRemovalTableDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "SearchFormDataRemovalTableData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataRemovalTableDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例数据(不返回表单的子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataRemovalTableDataRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataRemovalTableDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataRemovalTableDataResponse
        /// </returns>
        public async Task<SearchFormDataRemovalTableDataResponse> SearchFormDataRemovalTableDataWithOptionsAsync(SearchFormDataRemovalTableDataRequest request, SearchFormDataRemovalTableDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "SearchFormDataRemovalTableData",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataRemovalTableDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例数据(不返回表单的子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataRemovalTableDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataRemovalTableDataResponse
        /// </returns>
        public SearchFormDataRemovalTableDataResponse SearchFormDataRemovalTableData(SearchFormDataRemovalTableDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataRemovalTableDataHeaders headers = new SearchFormDataRemovalTableDataHeaders();
            return SearchFormDataRemovalTableDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单实例数据(不返回表单的子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataRemovalTableDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataRemovalTableDataResponse
        /// </returns>
        public async Task<SearchFormDataRemovalTableDataResponse> SearchFormDataRemovalTableDataAsync(SearchFormDataRemovalTableDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataRemovalTableDataHeaders headers = new SearchFormDataRemovalTableDataHeaders();
            return await SearchFormDataRemovalTableDataWithOptionsAsync(request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/advances/queryAll",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/advances/queryAll",
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
        /// <para>通过高级查询条件查询表单实例数据(不返回子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationNoTableFieldRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataSecondGenerationNoTableFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationNoTableFieldResponse
        /// </returns>
        public SearchFormDataSecondGenerationNoTableFieldResponse SearchFormDataSecondGenerationNoTableFieldWithOptions(SearchFormDataSecondGenerationNoTableFieldRequest request, SearchFormDataSecondGenerationNoTableFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SearchFormDataSecondGenerationNoTableField",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/advances/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationNoTableFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级查询条件查询表单实例数据(不返回子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationNoTableFieldRequest
        /// </param>
        /// <param name="headers">
        /// SearchFormDataSecondGenerationNoTableFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationNoTableFieldResponse
        /// </returns>
        public async Task<SearchFormDataSecondGenerationNoTableFieldResponse> SearchFormDataSecondGenerationNoTableFieldWithOptionsAsync(SearchFormDataSecondGenerationNoTableFieldRequest request, SearchFormDataSecondGenerationNoTableFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SearchFormDataSecondGenerationNoTableField",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/advances/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationNoTableFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级查询条件查询表单实例数据(不返回子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationNoTableFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationNoTableFieldResponse
        /// </returns>
        public SearchFormDataSecondGenerationNoTableFieldResponse SearchFormDataSecondGenerationNoTableField(SearchFormDataSecondGenerationNoTableFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationNoTableFieldHeaders headers = new SearchFormDataSecondGenerationNoTableFieldHeaders();
            return SearchFormDataSecondGenerationNoTableFieldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过高级查询条件查询表单实例数据(不返回子表单组件数据)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchFormDataSecondGenerationNoTableFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchFormDataSecondGenerationNoTableFieldResponse
        /// </returns>
        public async Task<SearchFormDataSecondGenerationNoTableFieldResponse> SearchFormDataSecondGenerationNoTableFieldAsync(SearchFormDataSecondGenerationNoTableFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationNoTableFieldHeaders headers = new SearchFormDataSecondGenerationNoTableFieldHeaders();
            return await SearchFormDataSecondGenerationNoTableFieldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件搜索表单实例详情列表,对应原searchFormDatas</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicOperator))
            {
                body["logicOperator"] = request.LogicOperator;
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/search",
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
        /// <para>根据条件搜索表单实例详情列表,对应原searchFormDatas</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicOperator))
            {
                body["logicOperator"] = request.LogicOperator;
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances/search",
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
        /// <para>根据条件搜索表单实例详情列表,对应原searchFormDatas</para>
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
        /// <para>根据条件搜索表单实例详情列表,对应原searchFormDatas</para>
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/start",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/start",
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
        /// <para>阿里云合同到期终止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateCloudAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// TerminateCloudAuthorizationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateCloudAuthorizationResponse
        /// </returns>
        public TerminateCloudAuthorizationResponse TerminateCloudAuthorizationWithOptions(TerminateCloudAuthorizationRequest request, TerminateCloudAuthorizationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "TerminateCloudAuthorization",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAuthorizations/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateCloudAuthorizationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云合同到期终止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateCloudAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// TerminateCloudAuthorizationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateCloudAuthorizationResponse
        /// </returns>
        public async Task<TerminateCloudAuthorizationResponse> TerminateCloudAuthorizationWithOptionsAsync(TerminateCloudAuthorizationRequest request, TerminateCloudAuthorizationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "TerminateCloudAuthorization",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAuthorizations/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateCloudAuthorizationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云合同到期终止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateCloudAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateCloudAuthorizationResponse
        /// </returns>
        public TerminateCloudAuthorizationResponse TerminateCloudAuthorization(TerminateCloudAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateCloudAuthorizationHeaders headers = new TerminateCloudAuthorizationHeaders();
            return TerminateCloudAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云合同到期终止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateCloudAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateCloudAuthorizationResponse
        /// </returns>
        public async Task<TerminateCloudAuthorizationResponse> TerminateCloudAuthorizationAsync(TerminateCloudAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateCloudAuthorizationHeaders headers = new TerminateCloudAuthorizationHeaders();
            return await TerminateCloudAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// TerminateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateInstanceResponse
        /// </returns>
        public TerminateInstanceResponse TerminateInstanceWithOptions(TerminateInstanceRequest request, TerminateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "TerminateInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/terminate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TerminateInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// TerminateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateInstanceResponse
        /// </returns>
        public async Task<TerminateInstanceResponse> TerminateInstanceWithOptionsAsync(TerminateInstanceRequest request, TerminateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
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
                Action = "TerminateInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances/terminate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TerminateInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateInstanceResponse
        /// </returns>
        public TerminateInstanceResponse TerminateInstance(TerminateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateInstanceHeaders headers = new TerminateInstanceHeaders();
            return TerminateInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateInstanceResponse
        /// </returns>
        public async Task<TerminateInstanceResponse> TerminateInstanceAsync(TerminateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TerminateInstanceHeaders headers = new TerminateInstanceHeaders();
            return await TerminateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudAccountInformationRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCloudAccountInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudAccountInformationResponse
        /// </returns>
        public UpdateCloudAccountInformationResponse UpdateCloudAccountInformationWithOptions(UpdateCloudAccountInformationRequest request, UpdateCloudAccountInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
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
                Action = "UpdateCloudAccountInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAccountInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloudAccountInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudAccountInformationRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCloudAccountInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudAccountInformationResponse
        /// </returns>
        public async Task<UpdateCloudAccountInformationResponse> UpdateCloudAccountInformationWithOptionsAsync(UpdateCloudAccountInformationRequest request, UpdateCloudAccountInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
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
                Action = "UpdateCloudAccountInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/cloudAccountInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloudAccountInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudAccountInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudAccountInformationResponse
        /// </returns>
        public UpdateCloudAccountInformationResponse UpdateCloudAccountInformation(UpdateCloudAccountInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCloudAccountInformationHeaders headers = new UpdateCloudAccountInformationHeaders();
            return UpdateCloudAccountInformationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudAccountInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudAccountInformationResponse
        /// </returns>
        public async Task<UpdateCloudAccountInformationResponse> UpdateCloudAccountInformationAsync(UpdateCloudAccountInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCloudAccountInformationHeaders headers = new UpdateCloudAccountInformationHeaders();
            return await UpdateCloudAccountInformationWithOptionsAsync(request, headers, runtime);
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
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
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/instances",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, UpdateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
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
                Action = "UpdateInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, UpdateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
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
                Action = "UpdateInstance",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/processes/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
            return UpdateInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
            return await UpdateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>未知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStatusResponse
        /// </returns>
        public UpdateStatusResponse UpdateStatusWithOptions(UpdateStatusRequest request, UpdateStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorLines))
            {
                body["errorLines"] = request.ErrorLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSequence))
            {
                body["importSequence"] = request.ImportSequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "UpdateStatus",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>未知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStatusResponse
        /// </returns>
        public async Task<UpdateStatusResponse> UpdateStatusWithOptionsAsync(UpdateStatusRequest request, UpdateStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorLines))
            {
                body["errorLines"] = request.ErrorLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSequence))
            {
                body["importSequence"] = request.ImportSequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
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
                Action = "UpdateStatus",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/forms/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>未知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStatusResponse
        /// </returns>
        public UpdateStatusResponse UpdateStatus(UpdateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStatusHeaders headers = new UpdateStatusHeaders();
            return UpdateStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>未知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStatusResponse
        /// </returns>
        public async Task<UpdateStatusResponse> UpdateStatusAsync(UpdateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStatusHeaders headers = new UpdateStatusHeaders();
            return await UpdateStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTenantInformationRequest
        /// </param>
        /// <param name="headers">
        /// UpgradeTenantInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTenantInformationResponse
        /// </returns>
        public UpgradeTenantInformationResponse UpgradeTenantInformationWithOptions(UpgradeTenantInformationRequest request, UpgradeTenantInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
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
                Action = "UpgradeTenantInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/tenantInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTenantInformationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTenantInformationRequest
        /// </param>
        /// <param name="headers">
        /// UpgradeTenantInformationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTenantInformationResponse
        /// </returns>
        public async Task<UpgradeTenantInformationResponse> UpgradeTenantInformationWithOptionsAsync(UpgradeTenantInformationRequest request, UpgradeTenantInformationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                body["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNumber))
            {
                body["accountNumber"] = request.AccountNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                body["callerUnionId"] = request.CallerUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["commodityType"] = request.CommodityType;
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
                Action = "UpgradeTenantInformation",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/tenantInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTenantInformationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTenantInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTenantInformationResponse
        /// </returns>
        public UpgradeTenantInformationResponse UpgradeTenantInformation(UpgradeTenantInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeTenantInformationHeaders headers = new UpgradeTenantInformationHeaders();
            return UpgradeTenantInformationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变配阿里云账号对应的租户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTenantInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTenantInformationResponse
        /// </returns>
        public async Task<UpgradeTenantInformationResponse> UpgradeTenantInformationAsync(UpgradeTenantInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeTenantInformationHeaders headers = new UpgradeTenantInformationHeaders();
            return await UpgradeTenantInformationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationOrderRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationAuthorizationOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationOrderResponse
        /// </returns>
        public ValidateApplicationAuthorizationOrderResponse ValidateApplicationAuthorizationOrderWithOptions(string instanceId, ValidateApplicationAuthorizationOrderRequest request, ValidateApplicationAuthorizationOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                query["callerUnionId"] = request.CallerUnionId;
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
                Action = "ValidateApplicationAuthorizationOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationOrderUpdateAuthorizations/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationAuthorizationOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationOrderRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationAuthorizationOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationOrderResponse
        /// </returns>
        public async Task<ValidateApplicationAuthorizationOrderResponse> ValidateApplicationAuthorizationOrderWithOptionsAsync(string instanceId, ValidateApplicationAuthorizationOrderRequest request, ValidateApplicationAuthorizationOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUnionId))
            {
                query["callerUnionId"] = request.CallerUnionId;
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
                Action = "ValidateApplicationAuthorizationOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applicationOrderUpdateAuthorizations/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationAuthorizationOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationOrderResponse
        /// </returns>
        public ValidateApplicationAuthorizationOrderResponse ValidateApplicationAuthorizationOrder(string instanceId, ValidateApplicationAuthorizationOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationAuthorizationOrderHeaders headers = new ValidateApplicationAuthorizationOrderHeaders();
            return ValidateApplicationAuthorizationOrderWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationOrderResponse
        /// </returns>
        public async Task<ValidateApplicationAuthorizationOrderResponse> ValidateApplicationAuthorizationOrderAsync(string instanceId, ValidateApplicationAuthorizationOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationAuthorizationOrderHeaders headers = new ValidateApplicationAuthorizationOrderHeaders();
            return await ValidateApplicationAuthorizationOrderWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationAuthorizationServiceOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public ValidateApplicationAuthorizationServiceOrderResponse ValidateApplicationAuthorizationServiceOrderWithOptions(string callerUid, ValidateApplicationAuthorizationServiceOrderRequest request, ValidateApplicationAuthorizationServiceOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "ValidateApplicationAuthorizationServiceOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationAuthorizationServiceOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationAuthorizationServiceOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public async Task<ValidateApplicationAuthorizationServiceOrderResponse> ValidateApplicationAuthorizationServiceOrderWithOptionsAsync(string callerUid, ValidateApplicationAuthorizationServiceOrderRequest request, ValidateApplicationAuthorizationServiceOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "ValidateApplicationAuthorizationServiceOrder",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/" + callerUid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationAuthorizationServiceOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public ValidateApplicationAuthorizationServiceOrderResponse ValidateApplicationAuthorizationServiceOrder(string callerUid, ValidateApplicationAuthorizationServiceOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationAuthorizationServiceOrderHeaders headers = new ValidateApplicationAuthorizationServiceOrderHeaders();
            return ValidateApplicationAuthorizationServiceOrderWithOptions(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationAuthorizationServiceOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationAuthorizationServiceOrderResponse
        /// </returns>
        public async Task<ValidateApplicationAuthorizationServiceOrderResponse> ValidateApplicationAuthorizationServiceOrderAsync(string callerUid, ValidateApplicationAuthorizationServiceOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationAuthorizationServiceOrderHeaders headers = new ValidateApplicationAuthorizationServiceOrderHeaders();
            return await ValidateApplicationAuthorizationServiceOrderWithOptionsAsync(callerUid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationServiceOrderUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationServiceOrderUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationServiceOrderUpgradeResponse
        /// </returns>
        public ValidateApplicationServiceOrderUpgradeResponse ValidateApplicationServiceOrderUpgradeWithOptions(string callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request, ValidateApplicationServiceOrderUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "ValidateApplicationServiceOrderUpgrade",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/orderValidations/" + callerUnionid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationServiceOrderUpgradeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationServiceOrderUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ValidateApplicationServiceOrderUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationServiceOrderUpgradeResponse
        /// </returns>
        public async Task<ValidateApplicationServiceOrderUpgradeResponse> ValidateApplicationServiceOrderUpgradeWithOptionsAsync(string callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request, ValidateApplicationServiceOrderUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
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
                Action = "ValidateApplicationServiceOrderUpgrade",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/applications/orderValidations/" + callerUnionid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateApplicationServiceOrderUpgradeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationServiceOrderUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationServiceOrderUpgradeResponse
        /// </returns>
        public ValidateApplicationServiceOrderUpgradeResponse ValidateApplicationServiceOrderUpgrade(string callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationServiceOrderUpgradeHeaders headers = new ValidateApplicationServiceOrderUpgradeHeaders();
            return ValidateApplicationServiceOrderUpgradeWithOptions(callerUnionid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateApplicationServiceOrderUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateApplicationServiceOrderUpgradeResponse
        /// </returns>
        public async Task<ValidateApplicationServiceOrderUpgradeResponse> ValidateApplicationServiceOrderUpgradeAsync(string callerUnionid, ValidateApplicationServiceOrderUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateApplicationServiceOrderUpgradeHeaders headers = new ValidateApplicationServiceOrderUpgradeHeaders();
            return await ValidateApplicationServiceOrderUpgradeWithOptionsAsync(callerUnionid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderBuyRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderBuyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderBuyResponse
        /// </returns>
        public ValidateOrderBuyResponse ValidateOrderBuyWithOptions(ValidateOrderBuyRequest request, ValidateOrderBuyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "ValidateOrderBuy",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/orderBuy/validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderBuyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderBuyRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderBuyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderBuyResponse
        /// </returns>
        public async Task<ValidateOrderBuyResponse> ValidateOrderBuyWithOptionsAsync(ValidateOrderBuyRequest request, ValidateOrderBuyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "ValidateOrderBuy",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/orderBuy/validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderBuyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderBuyRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderBuyResponse
        /// </returns>
        public ValidateOrderBuyResponse ValidateOrderBuy(ValidateOrderBuyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderBuyHeaders headers = new ValidateOrderBuyHeaders();
            return ValidateOrderBuyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道新购校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderBuyRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderBuyResponse
        /// </returns>
        public async Task<ValidateOrderBuyResponse> ValidateOrderBuyAsync(ValidateOrderBuyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderBuyHeaders headers = new ValidateOrderBuyHeaders();
            return await ValidateOrderBuyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpdateRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpdateResponse
        /// </returns>
        public ValidateOrderUpdateResponse ValidateOrderUpdateWithOptions(string instanceId, ValidateOrderUpdateRequest request, ValidateOrderUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "ValidateOrderUpdate",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/orders/renewalReviews/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpdateRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpdateResponse
        /// </returns>
        public async Task<ValidateOrderUpdateResponse> ValidateOrderUpdateWithOptionsAsync(string instanceId, ValidateOrderUpdateRequest request, ValidateOrderUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
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
                Action = "ValidateOrderUpdate",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/orders/renewalReviews/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpdateResponse
        /// </returns>
        public ValidateOrderUpdateResponse ValidateOrderUpdate(string instanceId, ValidateOrderUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderUpdateHeaders headers = new ValidateOrderUpdateHeaders();
            return ValidateOrderUpdateWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道续费前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpdateResponse
        /// </returns>
        public async Task<ValidateOrderUpdateResponse> ValidateOrderUpdateAsync(string instanceId, ValidateOrderUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderUpdateHeaders headers = new ValidateOrderUpdateHeaders();
            return await ValidateOrderUpdateWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道升配前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpgradeResponse
        /// </returns>
        public ValidateOrderUpgradeResponse ValidateOrderUpgradeWithOptions(ValidateOrderUpgradeRequest request, ValidateOrderUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ValidateOrderUpgrade",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/orderUpgrade/validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderUpgradeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道升配前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ValidateOrderUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpgradeResponse
        /// </returns>
        public async Task<ValidateOrderUpgradeResponse> ValidateOrderUpgradeWithOptionsAsync(ValidateOrderUpgradeRequest request, ValidateOrderUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                query["callerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
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
                Action = "ValidateOrderUpgrade",
                Version = "yida_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yida/apps/orderUpgrade/validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateOrderUpgradeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道升配前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpgradeResponse
        /// </returns>
        public ValidateOrderUpgradeResponse ValidateOrderUpgrade(ValidateOrderUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderUpgradeHeaders headers = new ValidateOrderUpgradeHeaders();
            return ValidateOrderUpgradeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多渠道升配前校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateOrderUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateOrderUpgradeResponse
        /// </returns>
        public async Task<ValidateOrderUpgradeResponse> ValidateOrderUpgradeAsync(ValidateOrderUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateOrderUpgradeHeaders headers = new ValidateOrderUpgradeHeaders();
            return await ValidateOrderUpgradeWithOptionsAsync(request, headers, runtime);
        }

    }
}
