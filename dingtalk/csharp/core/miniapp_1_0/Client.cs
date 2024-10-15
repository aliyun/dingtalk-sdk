// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppRequest
        /// </param>
        /// <param name="headers">
        /// CreateMiniAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppResponse
        /// </returns>
        public CreateMiniAppResponse CreateMiniAppWithOptions(CreateMiniAppRequest request, CreateMiniAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateMiniApp",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiniAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppRequest
        /// </param>
        /// <param name="headers">
        /// CreateMiniAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppResponse
        /// </returns>
        public async Task<CreateMiniAppResponse> CreateMiniAppWithOptionsAsync(CreateMiniAppRequest request, CreateMiniAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateMiniApp",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiniAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppResponse
        /// </returns>
        public CreateMiniAppResponse CreateMiniApp(CreateMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMiniAppHeaders headers = new CreateMiniAppHeaders();
            return CreateMiniAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppResponse
        /// </returns>
        public async Task<CreateMiniAppResponse> CreateMiniAppAsync(CreateMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMiniAppHeaders headers = new CreateMiniAppHeaders();
            return await CreateMiniAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppPluginRequest
        /// </param>
        /// <param name="headers">
        /// CreateMiniAppPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppPluginResponse
        /// </returns>
        public CreateMiniAppPluginResponse CreateMiniAppPluginWithOptions(CreateMiniAppPluginRequest request, CreateMiniAppPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateMiniAppPlugin",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/plugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiniAppPluginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppPluginRequest
        /// </param>
        /// <param name="headers">
        /// CreateMiniAppPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppPluginResponse
        /// </returns>
        public async Task<CreateMiniAppPluginResponse> CreateMiniAppPluginWithOptionsAsync(CreateMiniAppPluginRequest request, CreateMiniAppPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateMiniAppPlugin",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/plugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiniAppPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppPluginResponse
        /// </returns>
        public CreateMiniAppPluginResponse CreateMiniAppPlugin(CreateMiniAppPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMiniAppPluginHeaders headers = new CreateMiniAppPluginHeaders();
            return CreateMiniAppPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建小程序组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiniAppPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiniAppPluginResponse
        /// </returns>
        public async Task<CreateMiniAppPluginResponse> CreateMiniAppPluginAsync(CreateMiniAppPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMiniAppPluginHeaders headers = new CreateMiniAppPluginHeaders();
            return await CreateMiniAppPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序多端发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVersionAcrossBundleRequest
        /// </param>
        /// <param name="headers">
        /// CreateVersionAcrossBundleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVersionAcrossBundleResponse
        /// </returns>
        public CreateVersionAcrossBundleResponse CreateVersionAcrossBundleWithOptions(CreateVersionAcrossBundleRequest request, CreateVersionAcrossBundleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBundleId))
            {
                body["sourceBundleId"] = request.SourceBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVersion))
            {
                body["sourceVersion"] = request.SourceVersion;
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
                Action = "CreateVersionAcrossBundle",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/createAcrossBundle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVersionAcrossBundleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序多端发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVersionAcrossBundleRequest
        /// </param>
        /// <param name="headers">
        /// CreateVersionAcrossBundleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVersionAcrossBundleResponse
        /// </returns>
        public async Task<CreateVersionAcrossBundleResponse> CreateVersionAcrossBundleWithOptionsAsync(CreateVersionAcrossBundleRequest request, CreateVersionAcrossBundleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBundleId))
            {
                body["sourceBundleId"] = request.SourceBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVersion))
            {
                body["sourceVersion"] = request.SourceVersion;
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
                Action = "CreateVersionAcrossBundle",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/createAcrossBundle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVersionAcrossBundleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序多端发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVersionAcrossBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVersionAcrossBundleResponse
        /// </returns>
        public CreateVersionAcrossBundleResponse CreateVersionAcrossBundle(CreateVersionAcrossBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVersionAcrossBundleHeaders headers = new CreateVersionAcrossBundleHeaders();
            return CreateVersionAcrossBundleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序多端发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVersionAcrossBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVersionAcrossBundleResponse
        /// </returns>
        public async Task<CreateVersionAcrossBundleResponse> CreateVersionAcrossBundleAsync(CreateVersionAcrossBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVersionAcrossBundleHeaders headers = new CreateVersionAcrossBundleHeaders();
            return await CreateVersionAcrossBundleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序最大的构建版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxVersionRequest
        /// </param>
        /// <param name="headers">
        /// GetMaxVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaxVersionResponse
        /// </returns>
        public GetMaxVersionResponse GetMaxVersionWithOptions(GetMaxVersionRequest request, GetMaxVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["bundleId"] = request.BundleId;
            }
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
                Action = "GetMaxVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/maxVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaxVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序最大的构建版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxVersionRequest
        /// </param>
        /// <param name="headers">
        /// GetMaxVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaxVersionResponse
        /// </returns>
        public async Task<GetMaxVersionResponse> GetMaxVersionWithOptionsAsync(GetMaxVersionRequest request, GetMaxVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["bundleId"] = request.BundleId;
            }
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
                Action = "GetMaxVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/maxVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaxVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序最大的构建版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaxVersionResponse
        /// </returns>
        public GetMaxVersionResponse GetMaxVersion(GetMaxVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMaxVersionHeaders headers = new GetMaxVersionHeaders();
            return GetMaxVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序最大的构建版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaxVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaxVersionResponse
        /// </returns>
        public async Task<GetMaxVersionResponse> GetMaxVersionAsync(GetMaxVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMaxVersionHeaders headers = new GetMaxVersionHeaders();
            return await GetMaxVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步小程序元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiniAppMetaDataRequest
        /// </param>
        /// <param name="headers">
        /// GetMiniAppMetaDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMiniAppMetaDataResponse
        /// </returns>
        public GetMiniAppMetaDataResponse GetMiniAppMetaDataWithOptions(GetMiniAppMetaDataRequest request, GetMiniAppMetaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleIdTableGmtModified))
            {
                body["bundleIdTableGmtModified"] = request.BundleIdTableGmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAppName))
            {
                body["fromAppName"] = request.FromAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppIdTableGmtModified))
            {
                body["miniAppIdTableGmtModified"] = request.MiniAppIdTableGmtModified;
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
                Action = "GetMiniAppMetaData",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/metadata",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMiniAppMetaDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步小程序元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiniAppMetaDataRequest
        /// </param>
        /// <param name="headers">
        /// GetMiniAppMetaDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMiniAppMetaDataResponse
        /// </returns>
        public async Task<GetMiniAppMetaDataResponse> GetMiniAppMetaDataWithOptionsAsync(GetMiniAppMetaDataRequest request, GetMiniAppMetaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleIdTableGmtModified))
            {
                body["bundleIdTableGmtModified"] = request.BundleIdTableGmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAppName))
            {
                body["fromAppName"] = request.FromAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppIdTableGmtModified))
            {
                body["miniAppIdTableGmtModified"] = request.MiniAppIdTableGmtModified;
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
                Action = "GetMiniAppMetaData",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/metadata",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMiniAppMetaDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步小程序元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiniAppMetaDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMiniAppMetaDataResponse
        /// </returns>
        public GetMiniAppMetaDataResponse GetMiniAppMetaData(GetMiniAppMetaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMiniAppMetaDataHeaders headers = new GetMiniAppMetaDataHeaders();
            return GetMiniAppMetaDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步小程序元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiniAppMetaDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMiniAppMetaDataResponse
        /// </returns>
        public async Task<GetMiniAppMetaDataResponse> GetMiniAppMetaDataAsync(GetMiniAppMetaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMiniAppMetaDataHeaders headers = new GetMiniAppMetaDataHeaders();
            return await GetMiniAppMetaDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小程序配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSettingByMiniAppIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSettingByMiniAppIdResponse
        /// </returns>
        public GetSettingByMiniAppIdResponse GetSettingByMiniAppIdWithOptions(string miniAppId, GetSettingByMiniAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSettingByMiniAppId",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSettingByMiniAppIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小程序配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSettingByMiniAppIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSettingByMiniAppIdResponse
        /// </returns>
        public async Task<GetSettingByMiniAppIdResponse> GetSettingByMiniAppIdWithOptionsAsync(string miniAppId, GetSettingByMiniAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSettingByMiniAppId",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSettingByMiniAppIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小程序配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSettingByMiniAppIdResponse
        /// </returns>
        public GetSettingByMiniAppIdResponse GetSettingByMiniAppId(string miniAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSettingByMiniAppIdHeaders headers = new GetSettingByMiniAppIdHeaders();
            return GetSettingByMiniAppIdWithOptions(miniAppId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询小程序配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSettingByMiniAppIdResponse
        /// </returns>
        public async Task<GetSettingByMiniAppIdResponse> GetSettingByMiniAppIdAsync(string miniAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSettingByMiniAppIdHeaders headers = new GetSettingByMiniAppIdHeaders();
            return await GetSettingByMiniAppIdWithOptionsAsync(miniAppId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建H5Bundle</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeHtmlBundleBuildRequest
        /// </param>
        /// <param name="headers">
        /// InvokeHtmlBundleBuildHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeHtmlBundleBuildResponse
        /// </returns>
        public InvokeHtmlBundleBuildResponse InvokeHtmlBundleBuildWithOptions(InvokeHtmlBundleBuildRequest request, InvokeHtmlBundleBuildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
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
                Action = "InvokeHtmlBundleBuild",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/h5Bundles/build",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeHtmlBundleBuildResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建H5Bundle</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeHtmlBundleBuildRequest
        /// </param>
        /// <param name="headers">
        /// InvokeHtmlBundleBuildHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeHtmlBundleBuildResponse
        /// </returns>
        public async Task<InvokeHtmlBundleBuildResponse> InvokeHtmlBundleBuildWithOptionsAsync(InvokeHtmlBundleBuildRequest request, InvokeHtmlBundleBuildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
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
                Action = "InvokeHtmlBundleBuild",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/h5Bundles/build",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeHtmlBundleBuildResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建H5Bundle</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeHtmlBundleBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeHtmlBundleBuildResponse
        /// </returns>
        public InvokeHtmlBundleBuildResponse InvokeHtmlBundleBuild(InvokeHtmlBundleBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeHtmlBundleBuildHeaders headers = new InvokeHtmlBundleBuildHeaders();
            return InvokeHtmlBundleBuildWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建H5Bundle</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeHtmlBundleBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeHtmlBundleBuildResponse
        /// </returns>
        public async Task<InvokeHtmlBundleBuildResponse> InvokeHtmlBundleBuildAsync(InvokeHtmlBundleBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeHtmlBundleBuildHeaders headers = new InvokeHtmlBundleBuildHeaders();
            return await InvokeHtmlBundleBuildWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvaiableVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListAvaiableVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvaiableVersionResponse
        /// </returns>
        public ListAvaiableVersionResponse ListAvaiableVersionWithOptions(ListAvaiableVersionRequest request, ListAvaiableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
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
                Action = "ListAvaiableVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvaiableVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvaiableVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListAvaiableVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvaiableVersionResponse
        /// </returns>
        public async Task<ListAvaiableVersionResponse> ListAvaiableVersionWithOptionsAsync(ListAvaiableVersionRequest request, ListAvaiableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
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
                Action = "ListAvaiableVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvaiableVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvaiableVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvaiableVersionResponse
        /// </returns>
        public ListAvaiableVersionResponse ListAvaiableVersion(ListAvaiableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAvaiableVersionHeaders headers = new ListAvaiableVersionHeaders();
            return ListAvaiableVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvaiableVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvaiableVersionResponse
        /// </returns>
        public async Task<ListAvaiableVersionResponse> ListAvaiableVersionAsync(ListAvaiableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAvaiableVersionHeaders headers = new ListAvaiableVersionHeaders();
            return await ListAvaiableVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询H5构建结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHtmlBundleBuildRequest
        /// </param>
        /// <param name="headers">
        /// QueryHtmlBundleBuildHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHtmlBundleBuildResponse
        /// </returns>
        public QueryHtmlBundleBuildResponse QueryHtmlBundleBuildWithOptions(QueryHtmlBundleBuildRequest request, QueryHtmlBundleBuildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["bundleId"] = request.BundleId;
            }
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
                Action = "QueryHtmlBundleBuild",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/h5Bundles/buildResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHtmlBundleBuildResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询H5构建结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHtmlBundleBuildRequest
        /// </param>
        /// <param name="headers">
        /// QueryHtmlBundleBuildHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHtmlBundleBuildResponse
        /// </returns>
        public async Task<QueryHtmlBundleBuildResponse> QueryHtmlBundleBuildWithOptionsAsync(QueryHtmlBundleBuildRequest request, QueryHtmlBundleBuildHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["bundleId"] = request.BundleId;
            }
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
                Action = "QueryHtmlBundleBuild",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/h5Bundles/buildResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHtmlBundleBuildResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询H5构建结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHtmlBundleBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHtmlBundleBuildResponse
        /// </returns>
        public QueryHtmlBundleBuildResponse QueryHtmlBundleBuild(QueryHtmlBundleBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHtmlBundleBuildHeaders headers = new QueryHtmlBundleBuildHeaders();
            return QueryHtmlBundleBuildWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询H5构建结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHtmlBundleBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHtmlBundleBuildResponse
        /// </returns>
        public async Task<QueryHtmlBundleBuildResponse> QueryHtmlBundleBuildAsync(QueryHtmlBundleBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHtmlBundleBuildHeaders headers = new QueryHtmlBundleBuildHeaders();
            return await QueryHtmlBundleBuildWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollBackVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollBackVersionResponse
        /// </returns>
        public RollBackVersionResponse RollBackVersionWithOptions(RollBackVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollBackVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/rollback",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollBackVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollBackVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollBackVersionResponse
        /// </returns>
        public async Task<RollBackVersionResponse> RollBackVersionWithOptionsAsync(RollBackVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollBackVersion",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/rollback",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollBackVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollBackVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RollBackVersionResponse
        /// </returns>
        public RollBackVersionResponse RollBackVersion(RollBackVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollBackVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollBackVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RollBackVersionResponse
        /// </returns>
        public async Task<RollBackVersionResponse> RollBackVersionAsync(RollBackVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollBackVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改小程序配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExtendSettingRequest
        /// </param>
        /// <param name="headers">
        /// SetExtendSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExtendSettingResponse
        /// </returns>
        public SetExtendSettingResponse SetExtendSettingWithOptions(SetExtendSettingRequest request, SetExtendSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildH5Bundle))
            {
                body["buildH5Bundle"] = request.BuildH5Bundle;
            }
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
                Action = "SetExtendSetting",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExtendSettingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改小程序配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExtendSettingRequest
        /// </param>
        /// <param name="headers">
        /// SetExtendSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExtendSettingResponse
        /// </returns>
        public async Task<SetExtendSettingResponse> SetExtendSettingWithOptionsAsync(SetExtendSettingRequest request, SetExtendSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildH5Bundle))
            {
                body["buildH5Bundle"] = request.BuildH5Bundle;
            }
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
                Action = "SetExtendSetting",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/apps/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExtendSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改小程序配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExtendSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExtendSettingResponse
        /// </returns>
        public SetExtendSettingResponse SetExtendSetting(SetExtendSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetExtendSettingHeaders headers = new SetExtendSettingHeaders();
            return SetExtendSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改小程序配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExtendSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExtendSettingResponse
        /// </returns>
        public async Task<SetExtendSettingResponse> SetExtendSettingAsync(SetExtendSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetExtendSettingHeaders headers = new SetExtendSettingHeaders();
            return await SetExtendSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVersionStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVersionStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVersionStatusResponse
        /// </returns>
        public UpdateVersionStatusResponse UpdateVersionStatusWithOptions(UpdateVersionStatusRequest request, UpdateVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
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
                Action = "UpdateVersionStatus",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVersionStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVersionStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVersionStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVersionStatusResponse
        /// </returns>
        public async Task<UpdateVersionStatusResponse> UpdateVersionStatusWithOptionsAsync(UpdateVersionStatusRequest request, UpdateVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["bundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
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
                Action = "UpdateVersionStatus",
                Version = "miniapp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/miniapp/versions/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVersionStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVersionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVersionStatusResponse
        /// </returns>
        public UpdateVersionStatusResponse UpdateVersionStatus(UpdateVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVersionStatusHeaders headers = new UpdateVersionStatusHeaders();
            return UpdateVersionStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVersionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVersionStatusResponse
        /// </returns>
        public async Task<UpdateVersionStatusResponse> UpdateVersionStatusAsync(UpdateVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVersionStatusHeaders headers = new UpdateVersionStatusHeaders();
            return await UpdateVersionStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
