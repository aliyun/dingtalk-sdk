// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0
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


        /**
         * @summary 创建群公告
         *
         * @param request CreateGroupBlackboardRequest
         * @param headers CreateGroupBlackboardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupBlackboardResponse
         */
        public CreateGroupBlackboardResponse CreateGroupBlackboardWithOptions(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建群公告
         *
         * @param request CreateGroupBlackboardRequest
         * @param headers CreateGroupBlackboardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupBlackboardResponse
         */
        public async Task<CreateGroupBlackboardResponse> CreateGroupBlackboardWithOptionsAsync(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDing))
            {
                body["sendDing"] = request.SendDing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sticky))
            {
                body["sticky"] = request.Sticky;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["uniqueId"] = request.UniqueId;
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
                Action = "CreateGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建群公告
         *
         * @param request CreateGroupBlackboardRequest
         * @return CreateGroupBlackboardResponse
         */
        public CreateGroupBlackboardResponse CreateGroupBlackboard(CreateGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
            return CreateGroupBlackboardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建群公告
         *
         * @param request CreateGroupBlackboardRequest
         * @return CreateGroupBlackboardResponse
         */
        public async Task<CreateGroupBlackboardResponse> CreateGroupBlackboardAsync(CreateGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
            return await CreateGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除群公告
         *
         * @param request DeleteGroupBlackboardRequest
         * @param headers DeleteGroupBlackboardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupBlackboardResponse
         */
        public DeleteGroupBlackboardResponse DeleteGroupBlackboardWithOptions(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除群公告
         *
         * @param request DeleteGroupBlackboardRequest
         * @param headers DeleteGroupBlackboardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupBlackboardResponse
         */
        public async Task<DeleteGroupBlackboardResponse> DeleteGroupBlackboardWithOptionsAsync(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DeleteGroupBlackboard",
                Version = "groupBlackboard_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/groupBlackboard/blackboards/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupBlackboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除群公告
         *
         * @param request DeleteGroupBlackboardRequest
         * @return DeleteGroupBlackboardResponse
         */
        public DeleteGroupBlackboardResponse DeleteGroupBlackboard(DeleteGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
            return DeleteGroupBlackboardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除群公告
         *
         * @param request DeleteGroupBlackboardRequest
         * @return DeleteGroupBlackboardResponse
         */
        public async Task<DeleteGroupBlackboardResponse> DeleteGroupBlackboardAsync(DeleteGroupBlackboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
            return await DeleteGroupBlackboardWithOptionsAsync(request, headers, runtime);
        }

    }
}
