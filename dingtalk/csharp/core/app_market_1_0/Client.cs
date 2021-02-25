// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0
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


        public UserTaskReportResponse UserTaskReport(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return UserTaskReportWithOptions(request, headers, runtime);
        }

        public async Task<UserTaskReportResponse> UserTaskReportAsync(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return await UserTaskReportWithOptionsAsync(request, headers, runtime);
        }

        public UserTaskReportResponse UserTaskReportWithOptions(UserTaskReportRequest request, UserTaskReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                body["taskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateDate))
            {
                body["operateDate"] = request.OperateDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                body["bizNo"] = request.BizNo;
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
            return TeaModel.ToObject<UserTaskReportResponse>(DoROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime));
        }

        public async Task<UserTaskReportResponse> UserTaskReportWithOptionsAsync(UserTaskReportRequest request, UserTaskReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                body["taskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateDate))
            {
                body["operateDate"] = request.OperateDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                body["bizNo"] = request.BizNo;
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
            return TeaModel.ToObject<UserTaskReportResponse>(await DoROARequestAsync("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime));
        }

    }
}
