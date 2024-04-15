// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkamdp_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0
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


        public AmdpEmployeeDataPushResponse AmdpEmployeeDataPushWithOptions(AmdpEmployeeDataPushRequest request, AmdpEmployeeDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmployeeDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employees/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmployeeDataPushResponse>(Execute(params_, req, runtime));
        }

        public async Task<AmdpEmployeeDataPushResponse> AmdpEmployeeDataPushWithOptionsAsync(AmdpEmployeeDataPushRequest request, AmdpEmployeeDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpEmployeeDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/employees/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpEmployeeDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AmdpEmployeeDataPushResponse AmdpEmployeeDataPush(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return AmdpEmployeeDataPushWithOptions(request, headers, runtime);
        }

        public async Task<AmdpEmployeeDataPushResponse> AmdpEmployeeDataPushAsync(AmdpEmployeeDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
            return await AmdpEmployeeDataPushWithOptionsAsync(request, headers, runtime);
        }

        public AmdpJobPositionDataPushResponse AmdpJobPositionDataPushWithOptions(AmdpJobPositionDataPushRequest request, AmdpJobPositionDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpJobPositionDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/empJobs/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpJobPositionDataPushResponse>(Execute(params_, req, runtime));
        }

        public async Task<AmdpJobPositionDataPushResponse> AmdpJobPositionDataPushWithOptionsAsync(AmdpJobPositionDataPushRequest request, AmdpJobPositionDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpJobPositionDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/empJobs/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpJobPositionDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AmdpJobPositionDataPushResponse AmdpJobPositionDataPush(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return AmdpJobPositionDataPushWithOptions(request, headers, runtime);
        }

        public async Task<AmdpJobPositionDataPushResponse> AmdpJobPositionDataPushAsync(AmdpJobPositionDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
            return await AmdpJobPositionDataPushWithOptionsAsync(request, headers, runtime);
        }

        public AmdpOrganizationDataPushResponse AmdpOrganizationDataPushWithOptions(AmdpOrganizationDataPushRequest request, AmdpOrganizationDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpOrganizationDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/organizations/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpOrganizationDataPushResponse>(Execute(params_, req, runtime));
        }

        public async Task<AmdpOrganizationDataPushResponse> AmdpOrganizationDataPushWithOptionsAsync(AmdpOrganizationDataPushRequest request, AmdpOrganizationDataPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "AmdpOrganizationDataPush",
                Version = "amdp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/amdp/organizations/datas/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AmdpOrganizationDataPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AmdpOrganizationDataPushResponse AmdpOrganizationDataPush(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return AmdpOrganizationDataPushWithOptions(request, headers, runtime);
        }

        public async Task<AmdpOrganizationDataPushResponse> AmdpOrganizationDataPushAsync(AmdpOrganizationDataPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
            return await AmdpOrganizationDataPushWithOptionsAsync(request, headers, runtime);
        }

    }
}
