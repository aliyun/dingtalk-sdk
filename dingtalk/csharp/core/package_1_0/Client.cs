// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkpackage_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0
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


        public GetUploadTokenResponse GetUploadToken(GetUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
            return GetUploadTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetUploadTokenResponse> GetUploadTokenAsync(GetUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
            return await GetUploadTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetUploadTokenResponse GetUploadTokenWithOptions(GetUploadTokenRequest request, GetUploadTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetUploadTokenResponse>(DoROARequest("GetUploadToken", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/uploadTokens", "json", req, runtime));
        }

        public async Task<GetUploadTokenResponse> GetUploadTokenWithOptionsAsync(GetUploadTokenRequest request, GetUploadTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetUploadTokenResponse>(await DoROARequestAsync("GetUploadToken", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/uploadTokens", "json", req, runtime));
        }

        public HPublishPackageResponse HPublishPackage(HPublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPublishPackageHeaders headers = new HPublishPackageHeaders();
            return HPublishPackageWithOptions(request, headers, runtime);
        }

        public async Task<HPublishPackageResponse> HPublishPackageAsync(HPublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPublishPackageHeaders headers = new HPublishPackageHeaders();
            return await HPublishPackageWithOptionsAsync(request, headers, runtime);
        }

        public HPublishPackageResponse HPublishPackageWithOptions(HPublishPackageRequest request, HPublishPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
            return TeaModel.ToObject<HPublishPackageResponse>(DoROARequest("HPublishPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/publish", "json", req, runtime));
        }

        public async Task<HPublishPackageResponse> HPublishPackageWithOptionsAsync(HPublishPackageRequest request, HPublishPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
            return TeaModel.ToObject<HPublishPackageResponse>(await DoROARequestAsync("HPublishPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/publish", "json", req, runtime));
        }

        public HUploadPackageResponse HUploadPackage(HUploadPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageHeaders headers = new HUploadPackageHeaders();
            return HUploadPackageWithOptions(request, headers, runtime);
        }

        public async Task<HUploadPackageResponse> HUploadPackageAsync(HUploadPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageHeaders headers = new HUploadPackageHeaders();
            return await HUploadPackageWithOptionsAsync(request, headers, runtime);
        }

        public HUploadPackageResponse HUploadPackageWithOptions(HUploadPackageRequest request, HUploadPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectKey))
            {
                body["ossObjectKey"] = request.OssObjectKey;
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
            return TeaModel.ToObject<HUploadPackageResponse>(DoROARequest("HUploadPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/asyncUpload", "json", req, runtime));
        }

        public async Task<HUploadPackageResponse> HUploadPackageWithOptionsAsync(HUploadPackageRequest request, HUploadPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectKey))
            {
                body["ossObjectKey"] = request.OssObjectKey;
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
            return TeaModel.ToObject<HUploadPackageResponse>(await DoROARequestAsync("HUploadPackage", "package_1.0", "HTTP", "POST", "AK", "/v1.0/package/h5/asyncUpload", "json", req, runtime));
        }

        public HUploadPackageStatusResponse HUploadPackageStatus(HUploadPackageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
            return HUploadPackageStatusWithOptions(request, headers, runtime);
        }

        public async Task<HUploadPackageStatusResponse> HUploadPackageStatusAsync(HUploadPackageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
            return await HUploadPackageStatusWithOptionsAsync(request, headers, runtime);
        }

        public HUploadPackageStatusResponse HUploadPackageStatusWithOptions(HUploadPackageStatusRequest request, HUploadPackageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<HUploadPackageStatusResponse>(DoROARequest("HUploadPackageStatus", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/h5/uploadStatus", "json", req, runtime));
        }

        public async Task<HUploadPackageStatusResponse> HUploadPackageStatusWithOptionsAsync(HUploadPackageStatusRequest request, HUploadPackageStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<HUploadPackageStatusResponse>(await DoROARequestAsync("HUploadPackageStatus", "package_1.0", "HTTP", "GET", "AK", "/v1.0/package/h5/uploadStatus", "json", req, runtime));
        }

    }
}
