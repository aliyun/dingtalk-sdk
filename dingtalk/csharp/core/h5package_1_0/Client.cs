// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkh5package_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkh5package_1_0
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


        public CreatePackageResponse CreatePackage(CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePackageHeaders headers = new CreatePackageHeaders();
            return CreatePackageWithOptions(request, headers, runtime);
        }

        public async Task<CreatePackageResponse> CreatePackageAsync(CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePackageHeaders headers = new CreatePackageHeaders();
            return await CreatePackageWithOptionsAsync(request, headers, runtime);
        }

        public CreatePackageResponse CreatePackageWithOptions(CreatePackageRequest request, CreatePackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
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
            return TeaModel.ToObject<CreatePackageResponse>(DoROARequest("CreatePackage", "h5package_1.0", "HTTP", "POST", "AK", "/v1.0/h5package/asyncUpload", "json", req, runtime));
        }

        public async Task<CreatePackageResponse> CreatePackageWithOptionsAsync(CreatePackageRequest request, CreatePackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
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
            return TeaModel.ToObject<CreatePackageResponse>(await DoROARequestAsync("CreatePackage", "h5package_1.0", "HTTP", "POST", "AK", "/v1.0/h5package/asyncUpload", "json", req, runtime));
        }

        public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccessTokenHeaders headers = new GetAccessTokenHeaders();
            return GetAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccessTokenHeaders headers = new GetAccessTokenHeaders();
            return await GetAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetAccessTokenResponse GetAccessTokenWithOptions(GetAccessTokenRequest request, GetAccessTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
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
            return TeaModel.ToObject<GetAccessTokenResponse>(DoROARequest("GetAccessToken", "h5package_1.0", "HTTP", "GET", "AK", "/v1.0/h5package/uploadTokens", "json", req, runtime));
        }

        public async Task<GetAccessTokenResponse> GetAccessTokenWithOptionsAsync(GetAccessTokenRequest request, GetAccessTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
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
            return TeaModel.ToObject<GetAccessTokenResponse>(await DoROARequestAsync("GetAccessToken", "h5package_1.0", "HTTP", "GET", "AK", "/v1.0/h5package/uploadTokens", "json", req, runtime));
        }

        public GetCreateStatusResponse GetCreateStatus(GetCreateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCreateStatusHeaders headers = new GetCreateStatusHeaders();
            return GetCreateStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetCreateStatusResponse> GetCreateStatusAsync(GetCreateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCreateStatusHeaders headers = new GetCreateStatusHeaders();
            return await GetCreateStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetCreateStatusResponse GetCreateStatusWithOptions(GetCreateStatusRequest request, GetCreateStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<GetCreateStatusResponse>(DoROARequest("GetCreateStatus", "h5package_1.0", "HTTP", "GET", "AK", "/v1.0/h5package/uploadStatus", "json", req, runtime));
        }

        public async Task<GetCreateStatusResponse> GetCreateStatusWithOptionsAsync(GetCreateStatusRequest request, GetCreateStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<GetCreateStatusResponse>(await DoROARequestAsync("GetCreateStatus", "h5package_1.0", "HTTP", "GET", "AK", "/v1.0/h5package/uploadStatus", "json", req, runtime));
        }

        public PublishPackageResponse PublishPackage(PublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishPackageHeaders headers = new PublishPackageHeaders();
            return PublishPackageWithOptions(request, headers, runtime);
        }

        public async Task<PublishPackageResponse> PublishPackageAsync(PublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishPackageHeaders headers = new PublishPackageHeaders();
            return await PublishPackageWithOptionsAsync(request, headers, runtime);
        }

        public PublishPackageResponse PublishPackageWithOptions(PublishPackageRequest request, PublishPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
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
            return TeaModel.ToObject<PublishPackageResponse>(DoROARequest("PublishPackage", "h5package_1.0", "HTTP", "POST", "AK", "/v1.0/h5package/publish", "json", req, runtime));
        }

        public async Task<PublishPackageResponse> PublishPackageWithOptionsAsync(PublishPackageRequest request, PublishPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
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
            return TeaModel.ToObject<PublishPackageResponse>(await DoROARequestAsync("PublishPackage", "h5package_1.0", "HTTP", "POST", "AK", "/v1.0/h5package/publish", "json", req, runtime));
        }

    }
}
