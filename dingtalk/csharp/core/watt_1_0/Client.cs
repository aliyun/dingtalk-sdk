// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkwatt_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0
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


        public CheckInCrowdsByMobileResponse CheckInCrowdsByMobile(CheckInCrowdsByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInCrowdsByMobileWithOptions(request, headers, runtime);
        }

        public async Task<CheckInCrowdsByMobileResponse> CheckInCrowdsByMobileAsync(CheckInCrowdsByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInCrowdsByMobileWithOptionsAsync(request, headers, runtime);
        }

        public CheckInCrowdsByMobileResponse CheckInCrowdsByMobileWithOptions(CheckInCrowdsByMobileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                query["crowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CheckInCrowdsByMobileResponse>(DoROARequest("CheckInCrowdsByMobile", "watt_1.0", "HTTP", "POST", "AK", "/v1.0/watt/crowdIdentifications/query", "json", req, runtime));
        }

        public async Task<CheckInCrowdsByMobileResponse> CheckInCrowdsByMobileWithOptionsAsync(CheckInCrowdsByMobileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                query["crowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CheckInCrowdsByMobileResponse>(await DoROARequestAsync("CheckInCrowdsByMobile", "watt_1.0", "HTTP", "POST", "AK", "/v1.0/watt/crowdIdentifications/query", "json", req, runtime));
        }

    }
}
