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
        /// <para>关闭企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseHPackageRequest
        /// </param>
        /// <param name="headers">
        /// CloseHPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseHPackageResponse
        /// </returns>
        public CloseHPackageResponse CloseHPackageWithOptions(CloseHPackageRequest request, CloseHPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
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
                Action = "CloseHPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/microApps/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseHPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseHPackageRequest
        /// </param>
        /// <param name="headers">
        /// CloseHPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseHPackageResponse
        /// </returns>
        public async Task<CloseHPackageResponse> CloseHPackageWithOptionsAsync(CloseHPackageRequest request, CloseHPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
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
                Action = "CloseHPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/microApps/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseHPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseHPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseHPackageResponse
        /// </returns>
        public CloseHPackageResponse CloseHPackage(CloseHPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseHPackageHeaders headers = new CloseHPackageHeaders();
            return CloseHPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseHPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseHPackageResponse
        /// </returns>
        public async Task<CloseHPackageResponse> CloseHPackageAsync(CloseHPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseHPackageHeaders headers = new CloseHPackageHeaders();
            return await CloseHPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线包上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetUploadTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTokenResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadToken",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/uploadTokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线包上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetUploadTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTokenResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadToken",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/uploadTokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线包上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTokenResponse
        /// </returns>
        public GetUploadTokenResponse GetUploadToken(GetUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
            return GetUploadTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线包上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadTokenResponse
        /// </returns>
        public async Task<GetUploadTokenResponse> GetUploadTokenAsync(GetUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadTokenHeaders headers = new GetUploadTokenHeaders();
            return await GetUploadTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取H5离线包版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPackageListGetRequest
        /// </param>
        /// <param name="headers">
        /// HPackageListGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HPackageListGetResponse
        /// </returns>
        public HPackageListGetResponse HPackageListGetWithOptions(HPackageListGetRequest request, HPackageListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "HPackageListGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HPackageListGetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取H5离线包版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPackageListGetRequest
        /// </param>
        /// <param name="headers">
        /// HPackageListGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HPackageListGetResponse
        /// </returns>
        public async Task<HPackageListGetResponse> HPackageListGetWithOptionsAsync(HPackageListGetRequest request, HPackageListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "HPackageListGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HPackageListGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取H5离线包版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPackageListGetRequest
        /// </param>
        /// 
        /// <returns>
        /// HPackageListGetResponse
        /// </returns>
        public HPackageListGetResponse HPackageListGet(HPackageListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPackageListGetHeaders headers = new HPackageListGetHeaders();
            return HPackageListGetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取H5离线包版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPackageListGetRequest
        /// </param>
        /// 
        /// <returns>
        /// HPackageListGetResponse
        /// </returns>
        public async Task<HPackageListGetResponse> HPackageListGetAsync(HPackageListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPackageListGetHeaders headers = new HPackageListGetHeaders();
            return await HPackageListGetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPublishPackageRequest
        /// </param>
        /// <param name="headers">
        /// HPublishPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HPublishPackageResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HPublishPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HPublishPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPublishPackageRequest
        /// </param>
        /// <param name="headers">
        /// HPublishPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HPublishPackageResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HPublishPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HPublishPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPublishPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// HPublishPackageResponse
        /// </returns>
        public HPublishPackageResponse HPublishPackage(HPublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPublishPackageHeaders headers = new HPublishPackageHeaders();
            return HPublishPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HPublishPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// HPublishPackageResponse
        /// </returns>
        public async Task<HPublishPackageResponse> HPublishPackageAsync(HPublishPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HPublishPackageHeaders headers = new HPublishPackageHeaders();
            return await HPublishPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageRequest
        /// </param>
        /// <param name="headers">
        /// HUploadPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HUploadPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/asyncUpload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HUploadPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageRequest
        /// </param>
        /// <param name="headers">
        /// HUploadPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HUploadPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/asyncUpload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HUploadPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageResponse
        /// </returns>
        public HUploadPackageResponse HUploadPackage(HUploadPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageHeaders headers = new HUploadPackageHeaders();
            return HUploadPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageResponse
        /// </returns>
        public async Task<HUploadPackageResponse> HUploadPackageAsync(HUploadPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageHeaders headers = new HUploadPackageHeaders();
            return await HUploadPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageStatusRequest
        /// </param>
        /// <param name="headers">
        /// HUploadPackageStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageStatusResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HUploadPackageStatus",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/uploadStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HUploadPackageStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageStatusRequest
        /// </param>
        /// <param name="headers">
        /// HUploadPackageStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageStatusResponse
        /// </returns>
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HUploadPackageStatus",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/uploadStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HUploadPackageStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageStatusResponse
        /// </returns>
        public HUploadPackageStatusResponse HUploadPackageStatus(HUploadPackageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
            return HUploadPackageStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传H5离线包进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HUploadPackageStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// HUploadPackageStatusResponse
        /// </returns>
        public async Task<HUploadPackageStatusResponse> HUploadPackageStatusAsync(HUploadPackageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HUploadPackageStatusHeaders headers = new HUploadPackageStatusHeaders();
            return await HUploadPackageStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenMicroAppPackageRequest
        /// </param>
        /// <param name="headers">
        /// OpenMicroAppPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenMicroAppPackageResponse
        /// </returns>
        public OpenMicroAppPackageResponse OpenMicroAppPackageWithOptions(OpenMicroAppPackageRequest request, OpenMicroAppPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "OpenMicroAppPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/microApps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenMicroAppPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenMicroAppPackageRequest
        /// </param>
        /// <param name="headers">
        /// OpenMicroAppPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenMicroAppPackageResponse
        /// </returns>
        public async Task<OpenMicroAppPackageResponse> OpenMicroAppPackageWithOptionsAsync(OpenMicroAppPackageRequest request, OpenMicroAppPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
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
                Action = "OpenMicroAppPackage",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/h5/microApps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenMicroAppPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenMicroAppPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenMicroAppPackageResponse
        /// </returns>
        public OpenMicroAppPackageResponse OpenMicroAppPackage(OpenMicroAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenMicroAppPackageHeaders headers = new OpenMicroAppPackageHeaders();
            return OpenMicroAppPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启企业自建应用H5离线包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenMicroAppPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenMicroAppPackageResponse
        /// </returns>
        public async Task<OpenMicroAppPackageResponse> OpenMicroAppPackageAsync(OpenMicroAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenMicroAppPackageHeaders headers = new OpenMicroAppPackageHeaders();
            return await OpenMicroAppPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包到灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayDeployRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayDeployHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayDeployResponse
        /// </returns>
        public ReleaseGrayDeployResponse ReleaseGrayDeployWithOptions(ReleaseGrayDeployRequest request, ReleaseGrayDeployHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayDeploy",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayDeployResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包到灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayDeployRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayDeployHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayDeployResponse
        /// </returns>
        public async Task<ReleaseGrayDeployResponse> ReleaseGrayDeployWithOptionsAsync(ReleaseGrayDeployRequest request, ReleaseGrayDeployHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayDeploy",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayDeployResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包到灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayDeployResponse
        /// </returns>
        public ReleaseGrayDeployResponse ReleaseGrayDeploy(ReleaseGrayDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayDeployHeaders headers = new ReleaseGrayDeployHeaders();
            return ReleaseGrayDeployWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布离线包到灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayDeployResponse
        /// </returns>
        public async Task<ReleaseGrayDeployResponse> ReleaseGrayDeployAsync(ReleaseGrayDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayDeployHeaders headers = new ReleaseGrayDeployHeaders();
            return await ReleaseGrayDeployWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退出灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayExitRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayExitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayExitResponse
        /// </returns>
        public ReleaseGrayExitResponse ReleaseGrayExitWithOptions(ReleaseGrayExitRequest request, ReleaseGrayExitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayExit",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/exit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayExitResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退出灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayExitRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayExitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayExitResponse
        /// </returns>
        public async Task<ReleaseGrayExitResponse> ReleaseGrayExitWithOptionsAsync(ReleaseGrayExitRequest request, ReleaseGrayExitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayExit",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/exit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayExitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退出灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayExitRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayExitResponse
        /// </returns>
        public ReleaseGrayExitResponse ReleaseGrayExit(ReleaseGrayExitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayExitHeaders headers = new ReleaseGrayExitHeaders();
            return ReleaseGrayExitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退出灰度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayExitRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayExitResponse
        /// </returns>
        public async Task<ReleaseGrayExitResponse> ReleaseGrayExitAsync(ReleaseGrayExitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayExitHeaders headers = new ReleaseGrayExitHeaders();
            return await ReleaseGrayExitWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayOrgGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgGetResponse
        /// </returns>
        public ReleaseGrayOrgGetResponse ReleaseGrayOrgGetWithOptions(ReleaseGrayOrgGetRequest request, ReleaseGrayOrgGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayOrgGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayOrgGetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayOrgGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgGetResponse
        /// </returns>
        public async Task<ReleaseGrayOrgGetResponse> ReleaseGrayOrgGetWithOptionsAsync(ReleaseGrayOrgGetRequest request, ReleaseGrayOrgGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayOrgGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayOrgGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgGetResponse
        /// </returns>
        public ReleaseGrayOrgGetResponse ReleaseGrayOrgGet(ReleaseGrayOrgGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayOrgGetHeaders headers = new ReleaseGrayOrgGetHeaders();
            return ReleaseGrayOrgGetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgGetResponse
        /// </returns>
        public async Task<ReleaseGrayOrgGetResponse> ReleaseGrayOrgGetAsync(ReleaseGrayOrgGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayOrgGetHeaders headers = new ReleaseGrayOrgGetHeaders();
            return await ReleaseGrayOrgGetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgSetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayOrgSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgSetResponse
        /// </returns>
        public ReleaseGrayOrgSetResponse ReleaseGrayOrgSetWithOptions(ReleaseGrayOrgSetRequest request, ReleaseGrayOrgSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayOrgSet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/organizations/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayOrgSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgSetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayOrgSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgSetResponse
        /// </returns>
        public async Task<ReleaseGrayOrgSetResponse> ReleaseGrayOrgSetWithOptionsAsync(ReleaseGrayOrgSetRequest request, ReleaseGrayOrgSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayOrgSet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/organizations/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayOrgSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgSetResponse
        /// </returns>
        public ReleaseGrayOrgSetResponse ReleaseGrayOrgSet(ReleaseGrayOrgSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayOrgSetHeaders headers = new ReleaseGrayOrgSetHeaders();
            return ReleaseGrayOrgSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置企业灰度白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayOrgSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayOrgSetResponse
        /// </returns>
        public async Task<ReleaseGrayOrgSetResponse> ReleaseGrayOrgSetAsync(ReleaseGrayOrgSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayOrgSetHeaders headers = new ReleaseGrayOrgSetHeaders();
            return await ReleaseGrayOrgSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayPercentGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentGetResponse
        /// </returns>
        public ReleaseGrayPercentGetResponse ReleaseGrayPercentGetWithOptions(ReleaseGrayPercentGetRequest request, ReleaseGrayPercentGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayPercentGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users/percents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayPercentGetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayPercentGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentGetResponse
        /// </returns>
        public async Task<ReleaseGrayPercentGetResponse> ReleaseGrayPercentGetWithOptionsAsync(ReleaseGrayPercentGetRequest request, ReleaseGrayPercentGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayPercentGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users/percents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayPercentGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentGetResponse
        /// </returns>
        public ReleaseGrayPercentGetResponse ReleaseGrayPercentGet(ReleaseGrayPercentGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayPercentGetHeaders headers = new ReleaseGrayPercentGetHeaders();
            return ReleaseGrayPercentGetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentGetResponse
        /// </returns>
        public async Task<ReleaseGrayPercentGetResponse> ReleaseGrayPercentGetAsync(ReleaseGrayPercentGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayPercentGetHeaders headers = new ReleaseGrayPercentGetHeaders();
            return await ReleaseGrayPercentGetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentSetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayPercentSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentSetResponse
        /// </returns>
        public ReleaseGrayPercentSetResponse ReleaseGrayPercentSetWithOptions(ReleaseGrayPercentSetRequest request, ReleaseGrayPercentSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayPercentSet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users/percents/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayPercentSetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentSetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayPercentSetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentSetResponse
        /// </returns>
        public async Task<ReleaseGrayPercentSetResponse> ReleaseGrayPercentSetWithOptionsAsync(ReleaseGrayPercentSetRequest request, ReleaseGrayPercentSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGrayPercentSet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users/percents/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayPercentSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentSetResponse
        /// </returns>
        public ReleaseGrayPercentSetResponse ReleaseGrayPercentSet(ReleaseGrayPercentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayPercentSetHeaders headers = new ReleaseGrayPercentSetHeaders();
            return ReleaseGrayPercentSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置灰度离线包百分比值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayPercentSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayPercentSetResponse
        /// </returns>
        public async Task<ReleaseGrayPercentSetResponse> ReleaseGrayPercentSetAsync(ReleaseGrayPercentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayPercentSetHeaders headers = new ReleaseGrayPercentSetHeaders();
            return await ReleaseGrayPercentSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户灰度名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayUserIdGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayUserIdGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayUserIdGetResponse
        /// </returns>
        public ReleaseGrayUserIdGetResponse ReleaseGrayUserIdGetWithOptions(ReleaseGrayUserIdGetRequest request, ReleaseGrayUserIdGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayUserIdGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayUserIdGetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户灰度名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayUserIdGetRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseGrayUserIdGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayUserIdGetResponse
        /// </returns>
        public async Task<ReleaseGrayUserIdGetResponse> ReleaseGrayUserIdGetWithOptionsAsync(ReleaseGrayUserIdGetRequest request, ReleaseGrayUserIdGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Action = "ReleaseGrayUserIdGet",
                Version = "package_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/package/greys/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseGrayUserIdGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户灰度名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayUserIdGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayUserIdGetResponse
        /// </returns>
        public ReleaseGrayUserIdGetResponse ReleaseGrayUserIdGet(ReleaseGrayUserIdGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayUserIdGetHeaders headers = new ReleaseGrayUserIdGetHeaders();
            return ReleaseGrayUserIdGetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户灰度名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseGrayUserIdGetRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseGrayUserIdGetResponse
        /// </returns>
        public async Task<ReleaseGrayUserIdGetResponse> ReleaseGrayUserIdGetAsync(ReleaseGrayUserIdGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGrayUserIdGetHeaders headers = new ReleaseGrayUserIdGetHeaders();
            return await ReleaseGrayUserIdGetWithOptionsAsync(request, headers, runtime);
        }

    }
}
