// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkproject_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0
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


        public GetTbProjectSourceResponse GetTbProjectSource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return GetTbProjectSourceWithOptions(headers, runtime);
        }

        public async Task<GetTbProjectSourceResponse> GetTbProjectSourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return await GetTbProjectSourceWithOptionsAsync(headers, runtime);
        }

        public GetTbProjectSourceResponse GetTbProjectSourceWithOptions(GetTbProjectSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = headers.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = headers.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = headers.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTbProjectSourceResponse>(DoROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/source", "json", req, runtime));
        }

        public async Task<GetTbProjectSourceResponse> GetTbProjectSourceWithOptionsAsync(GetTbProjectSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = headers.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = headers.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = headers.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTbProjectSourceResponse>(await DoROARequestAsync("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/source", "json", req, runtime));
        }

        public GetTbProjectGrayResponse GetTbProjectGray(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return GetTbProjectGrayWithOptions(request, headers, runtime);
        }

        public async Task<GetTbProjectGrayResponse> GetTbProjectGrayAsync(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return await GetTbProjectGrayWithOptionsAsync(request, headers, runtime);
        }

        public GetTbProjectGrayResponse GetTbProjectGrayWithOptions(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["label"] = request.Label;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = headers.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = headers.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = headers.DingCorpId;
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
            return TeaModel.ToObject<GetTbProjectGrayResponse>(DoROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/gray", "json", req, runtime));
        }

        public async Task<GetTbProjectGrayResponse> GetTbProjectGrayWithOptionsAsync(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["label"] = request.Label;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = headers.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = headers.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = headers.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = headers.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = headers.DingCorpId;
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
            return TeaModel.ToObject<GetTbProjectGrayResponse>(await DoROARequestAsync("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/gray", "json", req, runtime));
        }

    }
}
