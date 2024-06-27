// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalklink_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalklink_1_0
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


        /**
         * @summary 发送用户授权信息申请
         *
         * @param request ApplyFollowerAuthInfoRequest
         * @param headers ApplyFollowerAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyFollowerAuthInfoResponse
         */
        public ApplyFollowerAuthInfoResponse ApplyFollowerAuthInfoWithOptions(ApplyFollowerAuthInfoRequest request, ApplyFollowerAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthKey))
            {
                body["appAuthKey"] = request.AppAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldScope))
            {
                body["fieldScope"] = request.FieldScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "ApplyFollowerAuthInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/authInfos/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFollowerAuthInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送用户授权信息申请
         *
         * @param request ApplyFollowerAuthInfoRequest
         * @param headers ApplyFollowerAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyFollowerAuthInfoResponse
         */
        public async Task<ApplyFollowerAuthInfoResponse> ApplyFollowerAuthInfoWithOptionsAsync(ApplyFollowerAuthInfoRequest request, ApplyFollowerAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthKey))
            {
                body["appAuthKey"] = request.AppAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldScope))
            {
                body["fieldScope"] = request.FieldScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "ApplyFollowerAuthInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/authInfos/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFollowerAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送用户授权信息申请
         *
         * @param request ApplyFollowerAuthInfoRequest
         * @return ApplyFollowerAuthInfoResponse
         */
        public ApplyFollowerAuthInfoResponse ApplyFollowerAuthInfo(ApplyFollowerAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyFollowerAuthInfoHeaders headers = new ApplyFollowerAuthInfoHeaders();
            return ApplyFollowerAuthInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送用户授权信息申请
         *
         * @param request ApplyFollowerAuthInfoRequest
         * @return ApplyFollowerAuthInfoResponse
         */
        public async Task<ApplyFollowerAuthInfoResponse> ApplyFollowerAuthInfoAsync(ApplyFollowerAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyFollowerAuthInfoHeaders headers = new ApplyFollowerAuthInfoHeaders();
            return await ApplyFollowerAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册服务窗消息回调服务
         *
         * @param request CallbackRegiesterRequest
         * @param headers CallbackRegiesterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CallbackRegiesterResponse
         */
        public CallbackRegiesterResponse CallbackRegiesterWithOptions(CallbackRegiesterRequest request, CallbackRegiesterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackKey))
            {
                body["callbackKey"] = request.CallbackKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CallbackRegiester",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/callbacks/regiester",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallbackRegiesterResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 注册服务窗消息回调服务
         *
         * @param request CallbackRegiesterRequest
         * @param headers CallbackRegiesterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CallbackRegiesterResponse
         */
        public async Task<CallbackRegiesterResponse> CallbackRegiesterWithOptionsAsync(CallbackRegiesterRequest request, CallbackRegiesterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackKey))
            {
                body["callbackKey"] = request.CallbackKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CallbackRegiester",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/callbacks/regiester",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallbackRegiesterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 注册服务窗消息回调服务
         *
         * @param request CallbackRegiesterRequest
         * @return CallbackRegiesterResponse
         */
        public CallbackRegiesterResponse CallbackRegiester(CallbackRegiesterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CallbackRegiesterHeaders headers = new CallbackRegiesterHeaders();
            return CallbackRegiesterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册服务窗消息回调服务
         *
         * @param request CallbackRegiesterRequest
         * @return CallbackRegiesterResponse
         */
        public async Task<CallbackRegiesterResponse> CallbackRegiesterAsync(CallbackRegiesterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CallbackRegiesterHeaders headers = new CallbackRegiesterHeaders();
            return await CallbackRegiesterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗吊顶卡片关闭接口
         *
         * @param request CloseTopBoxInteractiveOTOMessageRequest
         * @param headers CloseTopBoxInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseTopBoxInteractiveOTOMessageResponse
         */
        public CloseTopBoxInteractiveOTOMessageResponse CloseTopBoxInteractiveOTOMessageWithOptions(CloseTopBoxInteractiveOTOMessageRequest request, CloseTopBoxInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "CloseTopBoxInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopBoxInteractiveOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗吊顶卡片关闭接口
         *
         * @param request CloseTopBoxInteractiveOTOMessageRequest
         * @param headers CloseTopBoxInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseTopBoxInteractiveOTOMessageResponse
         */
        public async Task<CloseTopBoxInteractiveOTOMessageResponse> CloseTopBoxInteractiveOTOMessageWithOptionsAsync(CloseTopBoxInteractiveOTOMessageRequest request, CloseTopBoxInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "CloseTopBoxInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopBoxInteractiveOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗吊顶卡片关闭接口
         *
         * @param request CloseTopBoxInteractiveOTOMessageRequest
         * @return CloseTopBoxInteractiveOTOMessageResponse
         */
        public CloseTopBoxInteractiveOTOMessageResponse CloseTopBoxInteractiveOTOMessage(CloseTopBoxInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopBoxInteractiveOTOMessageHeaders headers = new CloseTopBoxInteractiveOTOMessageHeaders();
            return CloseTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗吊顶卡片关闭接口
         *
         * @param request CloseTopBoxInteractiveOTOMessageRequest
         * @return CloseTopBoxInteractiveOTOMessageResponse
         */
        public async Task<CloseTopBoxInteractiveOTOMessageResponse> CloseTopBoxInteractiveOTOMessageAsync(CloseTopBoxInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopBoxInteractiveOTOMessageHeaders headers = new CloseTopBoxInteractiveOTOMessageHeaders();
            return await CloseTopBoxInteractiveOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户授权信息
         *
         * @param request GetFollowerAuthInfoRequest
         * @param headers GetFollowerAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFollowerAuthInfoResponse
         */
        public GetFollowerAuthInfoResponse GetFollowerAuthInfoWithOptions(GetFollowerAuthInfoRequest request, GetFollowerAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFollowerAuthInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFollowerAuthInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户授权信息
         *
         * @param request GetFollowerAuthInfoRequest
         * @param headers GetFollowerAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFollowerAuthInfoResponse
         */
        public async Task<GetFollowerAuthInfoResponse> GetFollowerAuthInfoWithOptionsAsync(GetFollowerAuthInfoRequest request, GetFollowerAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFollowerAuthInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFollowerAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户授权信息
         *
         * @param request GetFollowerAuthInfoRequest
         * @return GetFollowerAuthInfoResponse
         */
        public GetFollowerAuthInfoResponse GetFollowerAuthInfo(GetFollowerAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFollowerAuthInfoHeaders headers = new GetFollowerAuthInfoHeaders();
            return GetFollowerAuthInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户授权信息
         *
         * @param request GetFollowerAuthInfoRequest
         * @return GetFollowerAuthInfoResponse
         */
        public async Task<GetFollowerAuthInfoResponse> GetFollowerAuthInfoAsync(GetFollowerAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFollowerAuthInfoHeaders headers = new GetFollowerAuthInfoHeaders();
            return await GetFollowerAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取服务窗关注人信息
         *
         * @param request GetFollowerInfoRequest
         * @param headers GetFollowerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFollowerInfoResponse
         */
        public GetFollowerInfoResponse GetFollowerInfoWithOptions(GetFollowerInfoRequest request, GetFollowerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFollowerInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFollowerInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取服务窗关注人信息
         *
         * @param request GetFollowerInfoRequest
         * @param headers GetFollowerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFollowerInfoResponse
         */
        public async Task<GetFollowerInfoResponse> GetFollowerInfoWithOptionsAsync(GetFollowerInfoRequest request, GetFollowerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFollowerInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFollowerInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取服务窗关注人信息
         *
         * @param request GetFollowerInfoRequest
         * @return GetFollowerInfoResponse
         */
        public GetFollowerInfoResponse GetFollowerInfo(GetFollowerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFollowerInfoHeaders headers = new GetFollowerInfoHeaders();
            return GetFollowerInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取服务窗关注人信息
         *
         * @param request GetFollowerInfoRequest
         * @return GetFollowerInfoResponse
         */
        public async Task<GetFollowerInfoResponse> GetFollowerInfoAsync(GetFollowerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFollowerInfoHeaders headers = new GetFollowerInfoHeaders();
            return await GetFollowerInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗图片消息下载地址获取接口
         *
         * @param request GetPictureDownloadUrlRequest
         * @param headers GetPictureDownloadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPictureDownloadUrlResponse
         */
        public GetPictureDownloadUrlResponse GetPictureDownloadUrlWithOptions(GetPictureDownloadUrlRequest request, GetPictureDownloadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCode))
            {
                query["downloadCode"] = request.DownloadCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GetPictureDownloadUrl",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/pictures/downloadUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPictureDownloadUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗图片消息下载地址获取接口
         *
         * @param request GetPictureDownloadUrlRequest
         * @param headers GetPictureDownloadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPictureDownloadUrlResponse
         */
        public async Task<GetPictureDownloadUrlResponse> GetPictureDownloadUrlWithOptionsAsync(GetPictureDownloadUrlRequest request, GetPictureDownloadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCode))
            {
                query["downloadCode"] = request.DownloadCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GetPictureDownloadUrl",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/pictures/downloadUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPictureDownloadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗图片消息下载地址获取接口
         *
         * @param request GetPictureDownloadUrlRequest
         * @return GetPictureDownloadUrlResponse
         */
        public GetPictureDownloadUrlResponse GetPictureDownloadUrl(GetPictureDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPictureDownloadUrlHeaders headers = new GetPictureDownloadUrlHeaders();
            return GetPictureDownloadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗图片消息下载地址获取接口
         *
         * @param request GetPictureDownloadUrlRequest
         * @return GetPictureDownloadUrlResponse
         */
        public async Task<GetPictureDownloadUrlResponse> GetPictureDownloadUrlAsync(GetPictureDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPictureDownloadUrlHeaders headers = new GetPictureDownloadUrlHeaders();
            return await GetPictureDownloadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户关注状态
         *
         * @param request GetUserFollowStatusRequest
         * @param headers GetUserFollowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserFollowStatusResponse
         */
        public GetUserFollowStatusResponse GetUserFollowStatusWithOptions(GetUserFollowStatusRequest request, GetUserFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetUserFollowStatus",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserFollowStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户关注状态
         *
         * @param request GetUserFollowStatusRequest
         * @param headers GetUserFollowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserFollowStatusResponse
         */
        public async Task<GetUserFollowStatusResponse> GetUserFollowStatusWithOptionsAsync(GetUserFollowStatusRequest request, GetUserFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetUserFollowStatus",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserFollowStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户关注状态
         *
         * @param request GetUserFollowStatusRequest
         * @return GetUserFollowStatusResponse
         */
        public GetUserFollowStatusResponse GetUserFollowStatus(GetUserFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFollowStatusHeaders headers = new GetUserFollowStatusHeaders();
            return GetUserFollowStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户关注状态
         *
         * @param request GetUserFollowStatusRequest
         * @return GetUserFollowStatusResponse
         */
        public async Task<GetUserFollowStatusResponse> GetUserFollowStatusAsync(GetUserFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFollowStatusHeaders headers = new GetUserFollowStatusHeaders();
            return await GetUserFollowStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业下服务窗帐号列表
         *
         * @param headers ListAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountResponse
         */
        public ListAccountResponse ListAccountWithOptions(ListAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccount",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业下服务窗帐号列表
         *
         * @param headers ListAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountResponse
         */
        public async Task<ListAccountResponse> ListAccountWithOptionsAsync(ListAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccount",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业下服务窗帐号列表
         *
         * @return ListAccountResponse
         */
        public ListAccountResponse ListAccount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAccountHeaders headers = new ListAccountHeaders();
            return ListAccountWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业下服务窗帐号列表
         *
         * @return ListAccountResponse
         */
        public async Task<ListAccountResponse> ListAccountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAccountHeaders headers = new ListAccountHeaders();
            return await ListAccountWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 第三方企业应用查询服务窗帐号列表
         *
         * @param headers ListAccountInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountInfoResponse
         */
        public ListAccountInfoResponse ListAccountInfoWithOptions(ListAccountInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccountInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/isv/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 第三方企业应用查询服务窗帐号列表
         *
         * @param headers ListAccountInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountInfoResponse
         */
        public async Task<ListAccountInfoResponse> ListAccountInfoWithOptionsAsync(ListAccountInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccountInfo",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/isv/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 第三方企业应用查询服务窗帐号列表
         *
         * @return ListAccountInfoResponse
         */
        public ListAccountInfoResponse ListAccountInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAccountInfoHeaders headers = new ListAccountInfoHeaders();
            return ListAccountInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 第三方企业应用查询服务窗帐号列表
         *
         * @return ListAccountInfoResponse
         */
        public async Task<ListAccountInfoResponse> ListAccountInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAccountInfoHeaders headers = new ListAccountInfoHeaders();
            return await ListAccountInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 批量获取服务窗关注人列表
         *
         * @param request ListFollowerRequest
         * @param headers ListFollowerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFollowerResponse
         */
        public ListFollowerResponse ListFollowerWithOptions(ListFollowerRequest request, ListFollowerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListFollower",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFollowerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量获取服务窗关注人列表
         *
         * @param request ListFollowerRequest
         * @param headers ListFollowerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFollowerResponse
         */
        public async Task<ListFollowerResponse> ListFollowerWithOptionsAsync(ListFollowerRequest request, ListFollowerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListFollower",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/followers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFollowerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量获取服务窗关注人列表
         *
         * @param request ListFollowerRequest
         * @return ListFollowerResponse
         */
        public ListFollowerResponse ListFollower(ListFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFollowerHeaders headers = new ListFollowerHeaders();
            return ListFollowerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取服务窗关注人列表
         *
         * @param request ListFollowerRequest
         * @return ListFollowerResponse
         */
        public async Task<ListFollowerResponse> ListFollowerAsync(ListFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFollowerHeaders headers = new ListFollowerHeaders();
            return await ListFollowerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 第三方企业应用查询用户是否关注服务窗
         *
         * @param request QueryUserFollowStatusRequest
         * @param headers QueryUserFollowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserFollowStatusResponse
         */
        public QueryUserFollowStatusResponse QueryUserFollowStatusWithOptions(QueryUserFollowStatusRequest request, QueryUserFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryUserFollowStatus",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/isv/followers/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserFollowStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 第三方企业应用查询用户是否关注服务窗
         *
         * @param request QueryUserFollowStatusRequest
         * @param headers QueryUserFollowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserFollowStatusResponse
         */
        public async Task<QueryUserFollowStatusResponse> QueryUserFollowStatusWithOptionsAsync(QueryUserFollowStatusRequest request, QueryUserFollowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "QueryUserFollowStatus",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/isv/followers/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserFollowStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 第三方企业应用查询用户是否关注服务窗
         *
         * @param request QueryUserFollowStatusRequest
         * @return QueryUserFollowStatusResponse
         */
        public QueryUserFollowStatusResponse QueryUserFollowStatus(QueryUserFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserFollowStatusHeaders headers = new QueryUserFollowStatusHeaders();
            return QueryUserFollowStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 第三方企业应用查询用户是否关注服务窗
         *
         * @param request QueryUserFollowStatusRequest
         * @return QueryUserFollowStatusResponse
         */
        public async Task<QueryUserFollowStatusResponse> QueryUserFollowStatusAsync(QueryUserFollowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserFollowStatusHeaders headers = new QueryUserFollowStatusHeaders();
            return await QueryUserFollowStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送服务窗客服消息
         *
         * @param request SendAgentOTOMessageRequest
         * @param headers SendAgentOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendAgentOTOMessageResponse
         */
        public SendAgentOTOMessageResponse SendAgentOTOMessageWithOptions(SendAgentOTOMessageRequest request, SendAgentOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendAgentOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/agentMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendAgentOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送服务窗客服消息
         *
         * @param request SendAgentOTOMessageRequest
         * @param headers SendAgentOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendAgentOTOMessageResponse
         */
        public async Task<SendAgentOTOMessageResponse> SendAgentOTOMessageWithOptionsAsync(SendAgentOTOMessageRequest request, SendAgentOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendAgentOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/agentMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendAgentOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送服务窗客服消息
         *
         * @param request SendAgentOTOMessageRequest
         * @return SendAgentOTOMessageResponse
         */
        public SendAgentOTOMessageResponse SendAgentOTOMessage(SendAgentOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAgentOTOMessageHeaders headers = new SendAgentOTOMessageHeaders();
            return SendAgentOTOMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送服务窗客服消息
         *
         * @param request SendAgentOTOMessageRequest
         * @return SendAgentOTOMessageResponse
         */
        public async Task<SendAgentOTOMessageResponse> SendAgentOTOMessageAsync(SendAgentOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAgentOTOMessageHeaders headers = new SendAgentOTOMessageHeaders();
            return await SendAgentOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗互动卡片单发接口
         *
         * @param request SendInteractiveOTOMessageRequest
         * @param headers SendInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveOTOMessageResponse
         */
        public SendInteractiveOTOMessageResponse SendInteractiveOTOMessageWithOptions(SendInteractiveOTOMessageRequest request, SendInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/interactiveMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗互动卡片单发接口
         *
         * @param request SendInteractiveOTOMessageRequest
         * @param headers SendInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveOTOMessageResponse
         */
        public async Task<SendInteractiveOTOMessageResponse> SendInteractiveOTOMessageWithOptionsAsync(SendInteractiveOTOMessageRequest request, SendInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/interactiveMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗互动卡片单发接口
         *
         * @param request SendInteractiveOTOMessageRequest
         * @return SendInteractiveOTOMessageResponse
         */
        public SendInteractiveOTOMessageResponse SendInteractiveOTOMessage(SendInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveOTOMessageHeaders headers = new SendInteractiveOTOMessageHeaders();
            return SendInteractiveOTOMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗互动卡片单发接口
         *
         * @param request SendInteractiveOTOMessageRequest
         * @return SendInteractiveOTOMessageResponse
         */
        public async Task<SendInteractiveOTOMessageResponse> SendInteractiveOTOMessageAsync(SendInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveOTOMessageHeaders headers = new SendInteractiveOTOMessageHeaders();
            return await SendInteractiveOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗吊顶卡片发送接口
         *
         * @param request SendTopBoxInteractiveOTOMessageRequest
         * @param headers SendTopBoxInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTopBoxInteractiveOTOMessageResponse
         */
        public SendTopBoxInteractiveOTOMessageResponse SendTopBoxInteractiveOTOMessageWithOptions(SendTopBoxInteractiveOTOMessageRequest request, SendTopBoxInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendTopBoxInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/topBoxes/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTopBoxInteractiveOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗吊顶卡片发送接口
         *
         * @param request SendTopBoxInteractiveOTOMessageRequest
         * @param headers SendTopBoxInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTopBoxInteractiveOTOMessageResponse
         */
        public async Task<SendTopBoxInteractiveOTOMessageResponse> SendTopBoxInteractiveOTOMessageWithOptionsAsync(SendTopBoxInteractiveOTOMessageRequest request, SendTopBoxInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "SendTopBoxInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/topBoxes/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTopBoxInteractiveOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗吊顶卡片发送接口
         *
         * @param request SendTopBoxInteractiveOTOMessageRequest
         * @return SendTopBoxInteractiveOTOMessageResponse
         */
        public SendTopBoxInteractiveOTOMessageResponse SendTopBoxInteractiveOTOMessage(SendTopBoxInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTopBoxInteractiveOTOMessageHeaders headers = new SendTopBoxInteractiveOTOMessageHeaders();
            return SendTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗吊顶卡片发送接口
         *
         * @param request SendTopBoxInteractiveOTOMessageRequest
         * @return SendTopBoxInteractiveOTOMessageResponse
         */
        public async Task<SendTopBoxInteractiveOTOMessageResponse> SendTopBoxInteractiveOTOMessageAsync(SendTopBoxInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTopBoxInteractiveOTOMessageHeaders headers = new SendTopBoxInteractiveOTOMessageHeaders();
            return await SendTopBoxInteractiveOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗互动卡片修改接口
         *
         * @param request UpdateInteractiveOTOMessageRequest
         * @param headers UpdateInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveOTOMessageResponse
         */
        public UpdateInteractiveOTOMessageResponse UpdateInteractiveOTOMessageWithOptions(UpdateInteractiveOTOMessageRequest request, UpdateInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "UpdateInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/interactiveMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveOTOMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗互动卡片修改接口
         *
         * @param request UpdateInteractiveOTOMessageRequest
         * @param headers UpdateInteractiveOTOMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveOTOMessageResponse
         */
        public async Task<UpdateInteractiveOTOMessageResponse> UpdateInteractiveOTOMessageWithOptionsAsync(UpdateInteractiveOTOMessageRequest request, UpdateInteractiveOTOMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                body["detail"] = request.Detail;
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
                Action = "UpdateInteractiveOTOMessage",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/oToMessages/interactiveMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveOTOMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗互动卡片修改接口
         *
         * @param request UpdateInteractiveOTOMessageRequest
         * @return UpdateInteractiveOTOMessageResponse
         */
        public UpdateInteractiveOTOMessageResponse UpdateInteractiveOTOMessage(UpdateInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveOTOMessageHeaders headers = new UpdateInteractiveOTOMessageHeaders();
            return UpdateInteractiveOTOMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗互动卡片修改接口
         *
         * @param request UpdateInteractiveOTOMessageRequest
         * @return UpdateInteractiveOTOMessageResponse
         */
        public async Task<UpdateInteractiveOTOMessageResponse> UpdateInteractiveOTOMessageAsync(UpdateInteractiveOTOMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveOTOMessageHeaders headers = new UpdateInteractiveOTOMessageHeaders();
            return await UpdateInteractiveOTOMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 服务窗会话窗口快捷栏配置接口
         *
         * @param request UpdateShortcutsRequest
         * @param headers UpdateShortcutsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateShortcutsResponse
         */
        public UpdateShortcutsResponse UpdateShortcutsWithOptions(UpdateShortcutsRequest request, UpdateShortcutsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Details))
            {
                body["details"] = request.Details;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "UpdateShortcuts",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/shortcuts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateShortcutsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 服务窗会话窗口快捷栏配置接口
         *
         * @param request UpdateShortcutsRequest
         * @param headers UpdateShortcutsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateShortcutsResponse
         */
        public async Task<UpdateShortcutsResponse> UpdateShortcutsWithOptionsAsync(UpdateShortcutsRequest request, UpdateShortcutsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Details))
            {
                body["details"] = request.Details;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "UpdateShortcuts",
                Version = "link_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/link/shortcuts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateShortcutsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 服务窗会话窗口快捷栏配置接口
         *
         * @param request UpdateShortcutsRequest
         * @return UpdateShortcutsResponse
         */
        public UpdateShortcutsResponse UpdateShortcuts(UpdateShortcutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateShortcutsHeaders headers = new UpdateShortcutsHeaders();
            return UpdateShortcutsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 服务窗会话窗口快捷栏配置接口
         *
         * @param request UpdateShortcutsRequest
         * @return UpdateShortcutsResponse
         */
        public async Task<UpdateShortcutsResponse> UpdateShortcutsAsync(UpdateShortcutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateShortcutsHeaders headers = new UpdateShortcutsHeaders();
            return await UpdateShortcutsWithOptionsAsync(request, headers, runtime);
        }

    }
}
