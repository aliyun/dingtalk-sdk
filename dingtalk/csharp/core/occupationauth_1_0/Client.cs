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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CheckUserTaskStatusResponse CheckUserTaskStatus(CheckUserTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
            return CheckUserTaskStatusWithOptions(request, headers, runtime);
        }

        public async Task<CheckUserTaskStatusResponse> CheckUserTaskStatusAsync(CheckUserTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
            return await CheckUserTaskStatusWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckUserTaskStatusResponse>(DoROARequest("CheckUserTaskStatus", "occupationauth_1.0", "HTTP", "POST", "AK", "/v1.0/occupationauth/auths/userTasks", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CheckUserTaskStatusResponse>(await DoROARequestAsync("CheckUserTaskStatus", "occupationauth_1.0", "HTTP", "POST", "AK", "/v1.0/occupationauth/auths/userTasks", "json", req, runtime));
        }

    }
}
