// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkoccupationauth_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkoccupationauth_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTaskStatusRequest
         * @param headers CheckUserTaskStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserTaskStatusResponse
         */
        public CheckUserTaskStatusResponse CheckUserTaskStatusWithOptions(CheckUserTaskStatusRequest request, CheckUserTaskStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceCode))
            {
                body["provinceCode"] = request.ProvinceCode;
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
                Action = "CheckUserTaskStatus",
                Version = "occupationauth_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/occupationauth/auths/userTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTaskStatusRequest
         * @param headers CheckUserTaskStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserTaskStatusResponse
         */
        public async Task<CheckUserTaskStatusResponse> CheckUserTaskStatusWithOptionsAsync(CheckUserTaskStatusRequest request, CheckUserTaskStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceCode))
            {
                body["provinceCode"] = request.ProvinceCode;
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
                Action = "CheckUserTaskStatus",
                Version = "occupationauth_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/occupationauth/auths/userTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTaskStatusRequest
         * @return CheckUserTaskStatusResponse
         */
        public CheckUserTaskStatusResponse CheckUserTaskStatus(CheckUserTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
            return CheckUserTaskStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTaskStatusRequest
         * @return CheckUserTaskStatusResponse
         */
        public async Task<CheckUserTaskStatusResponse> CheckUserTaskStatusAsync(CheckUserTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
            return await CheckUserTaskStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTasksStatusRequest
         * @param headers CheckUserTasksStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserTasksStatusResponse
         */
        public CheckUserTasksStatusResponse CheckUserTasksStatusWithOptions(CheckUserTasksStatusRequest request, CheckUserTasksStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceCode))
            {
                query["provinceCode"] = request.ProvinceCode;
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
                Action = "CheckUserTasksStatus",
                Version = "occupationauth_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/occupationauth/userTasks/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserTasksStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTasksStatusRequest
         * @param headers CheckUserTasksStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserTasksStatusResponse
         */
        public async Task<CheckUserTasksStatusResponse> CheckUserTasksStatusWithOptionsAsync(CheckUserTasksStatusRequest request, CheckUserTasksStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceCode))
            {
                query["provinceCode"] = request.ProvinceCode;
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
                Action = "CheckUserTasksStatus",
                Version = "occupationauth_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/occupationauth/userTasks/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserTasksStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTasksStatusRequest
         * @return CheckUserTasksStatusResponse
         */
        public CheckUserTasksStatusResponse CheckUserTasksStatus(CheckUserTasksStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTasksStatusHeaders headers = new CheckUserTasksStatusHeaders();
            return CheckUserTasksStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 检查用户任务状态
         *
         * @param request CheckUserTasksStatusRequest
         * @return CheckUserTasksStatusResponse
         */
        public async Task<CheckUserTasksStatusResponse> CheckUserTasksStatusAsync(CheckUserTasksStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTasksStatusHeaders headers = new CheckUserTasksStatusHeaders();
            return await CheckUserTasksStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
