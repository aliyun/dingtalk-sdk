// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0
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


        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return QueryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoAsync(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return await QueryDigitalDistrictOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfoWithOptions(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KpiGroupId))
            {
                body["kpiGroupId"] = request.KpiGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgIds))
            {
                body["orgIds"] = request.OrgIds;
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
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(DoROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime));
        }

        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoWithOptionsAsync(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KpiGroupId))
            {
                body["kpiGroupId"] = request.KpiGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgIds))
            {
                body["orgIds"] = request.OrgIds;
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
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(await DoROARequestAsync("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime));
        }

    }
}
