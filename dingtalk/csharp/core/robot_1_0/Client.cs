// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkrobot_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0
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
         * @summary 批量查询人与机器人会话机器人消息是否已读
         *
         * @param request BatchOTOQueryRequest
         * @param headers BatchOTOQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchOTOQueryResponse
         */
        public BatchOTOQueryResponse BatchOTOQueryWithOptions(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                query["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
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
                Action = "BatchOTOQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/oToMessages/readStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchOTOQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询人与机器人会话机器人消息是否已读
         *
         * @param request BatchOTOQueryRequest
         * @param headers BatchOTOQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchOTOQueryResponse
         */
        public async Task<BatchOTOQueryResponse> BatchOTOQueryWithOptionsAsync(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                query["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
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
                Action = "BatchOTOQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/oToMessages/readStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchOTOQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询人与机器人会话机器人消息是否已读
         *
         * @param request BatchOTOQueryRequest
         * @return BatchOTOQueryResponse
         */
        public BatchOTOQueryResponse BatchOTOQuery(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return BatchOTOQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询人与机器人会话机器人消息是否已读
         *
         * @param request BatchOTOQueryRequest
         * @return BatchOTOQueryResponse
         */
        public async Task<BatchOTOQueryResponse> BatchOTOQueryAsync(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return await BatchOTOQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量撤回群聊机器人消息
         *
         * @param request BatchRecallGroupRequest
         * @param headers BatchRecallGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallGroupResponse
         */
        public BatchRecallGroupResponse BatchRecallGroupWithOptions(BatchRecallGroupRequest request, BatchRecallGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
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
                Action = "BatchRecallGroup",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量撤回群聊机器人消息
         *
         * @param request BatchRecallGroupRequest
         * @param headers BatchRecallGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallGroupResponse
         */
        public async Task<BatchRecallGroupResponse> BatchRecallGroupWithOptionsAsync(BatchRecallGroupRequest request, BatchRecallGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
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
                Action = "BatchRecallGroup",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量撤回群聊机器人消息
         *
         * @param request BatchRecallGroupRequest
         * @return BatchRecallGroupResponse
         */
        public BatchRecallGroupResponse BatchRecallGroup(BatchRecallGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
            return BatchRecallGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量撤回群聊机器人消息
         *
         * @param request BatchRecallGroupRequest
         * @return BatchRecallGroupResponse
         */
        public async Task<BatchRecallGroupResponse> BatchRecallGroupAsync(BatchRecallGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
            return await BatchRecallGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量撤回人与机器人会话中机器人消息
         *
         * @param request BatchRecallOTORequest
         * @param headers BatchRecallOTOHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallOTOResponse
         */
        public BatchRecallOTOResponse BatchRecallOTOWithOptions(BatchRecallOTORequest request, BatchRecallOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "BatchRecallOTO",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/otoMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallOTOResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量撤回人与机器人会话中机器人消息
         *
         * @param request BatchRecallOTORequest
         * @param headers BatchRecallOTOHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallOTOResponse
         */
        public async Task<BatchRecallOTOResponse> BatchRecallOTOWithOptionsAsync(BatchRecallOTORequest request, BatchRecallOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "BatchRecallOTO",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/otoMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallOTOResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量撤回人与机器人会话中机器人消息
         *
         * @param request BatchRecallOTORequest
         * @return BatchRecallOTOResponse
         */
        public BatchRecallOTOResponse BatchRecallOTO(BatchRecallOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
            return BatchRecallOTOWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量撤回人与机器人会话中机器人消息
         *
         * @param request BatchRecallOTORequest
         * @return BatchRecallOTOResponse
         */
        public async Task<BatchRecallOTOResponse> BatchRecallOTOAsync(BatchRecallOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
            return await BatchRecallOTOWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量撤回人与人会话中机器人消息
         *
         * @param request BatchRecallPrivateChatRequest
         * @param headers BatchRecallPrivateChatHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallPrivateChatResponse
         */
        public BatchRecallPrivateChatResponse BatchRecallPrivateChatWithOptions(BatchRecallPrivateChatRequest request, BatchRecallPrivateChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "BatchRecallPrivateChat",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallPrivateChatResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量撤回人与人会话中机器人消息
         *
         * @param request BatchRecallPrivateChatRequest
         * @param headers BatchRecallPrivateChatHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRecallPrivateChatResponse
         */
        public async Task<BatchRecallPrivateChatResponse> BatchRecallPrivateChatWithOptionsAsync(BatchRecallPrivateChatRequest request, BatchRecallPrivateChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "BatchRecallPrivateChat",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/batchRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallPrivateChatResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量撤回人与人会话中机器人消息
         *
         * @param request BatchRecallPrivateChatRequest
         * @return BatchRecallPrivateChatResponse
         */
        public BatchRecallPrivateChatResponse BatchRecallPrivateChat(BatchRecallPrivateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallPrivateChatHeaders headers = new BatchRecallPrivateChatHeaders();
            return BatchRecallPrivateChatWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量撤回人与人会话中机器人消息
         *
         * @param request BatchRecallPrivateChatRequest
         * @return BatchRecallPrivateChatResponse
         */
        public async Task<BatchRecallPrivateChatResponse> BatchRecallPrivateChatAsync(BatchRecallPrivateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallPrivateChatHeaders headers = new BatchRecallPrivateChatHeaders();
            return await BatchRecallPrivateChatWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量发送人与机器人会话中机器人消息
         *
         * @param request BatchSendOTORequest
         * @param headers BatchSendOTOHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSendOTOResponse
         */
        public BatchSendOTOResponse BatchSendOTOWithOptions(BatchSendOTORequest request, BatchSendOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "BatchSendOTO",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/oToMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendOTOResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量发送人与机器人会话中机器人消息
         *
         * @param request BatchSendOTORequest
         * @param headers BatchSendOTOHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSendOTOResponse
         */
        public async Task<BatchSendOTOResponse> BatchSendOTOWithOptionsAsync(BatchSendOTORequest request, BatchSendOTOHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "BatchSendOTO",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/oToMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendOTOResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量发送人与机器人会话中机器人消息
         *
         * @param request BatchSendOTORequest
         * @return BatchSendOTOResponse
         */
        public BatchSendOTOResponse BatchSendOTO(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return BatchSendOTOWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量发送人与机器人会话中机器人消息
         *
         * @param request BatchSendOTORequest
         * @return BatchSendOTOResponse
         */
        public async Task<BatchSendOTOResponse> BatchSendOTOAsync(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return await BatchSendOTOWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 清空单聊机器人快捷入口
         *
         * @param request ClearRobotPluginRequest
         * @param headers ClearRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRobotPluginResponse
         */
        public ClearRobotPluginResponse ClearRobotPluginWithOptions(ClearRobotPluginRequest request, ClearRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "ClearRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRobotPluginResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 清空单聊机器人快捷入口
         *
         * @param request ClearRobotPluginRequest
         * @param headers ClearRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRobotPluginResponse
         */
        public async Task<ClearRobotPluginResponse> ClearRobotPluginWithOptionsAsync(ClearRobotPluginRequest request, ClearRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "ClearRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRobotPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 清空单聊机器人快捷入口
         *
         * @param request ClearRobotPluginRequest
         * @return ClearRobotPluginResponse
         */
        public ClearRobotPluginResponse ClearRobotPlugin(ClearRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRobotPluginHeaders headers = new ClearRobotPluginHeaders();
            return ClearRobotPluginWithOptions(request, headers, runtime);
        }

        /**
         * @summary 清空单聊机器人快捷入口
         *
         * @param request ClearRobotPluginRequest
         * @return ClearRobotPluginResponse
         */
        public async Task<ClearRobotPluginResponse> ClearRobotPluginAsync(ClearRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRobotPluginHeaders headers = new ClearRobotPluginHeaders();
            return await ClearRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 执行机器人的AI技能
         *
         * @param request ExecuteRobotAiSkillRequest
         * @param headers ExecuteRobotAiSkillHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteRobotAiSkillResponse
         */
        public ExecuteRobotAiSkillResponse ExecuteRobotAiSkillWithOptions(ExecuteRobotAiSkillRequest request, ExecuteRobotAiSkillHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                body["skillId"] = request.SkillId;
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
                Action = "ExecuteRobotAiSkill",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/aiSkill/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteRobotAiSkillResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 执行机器人的AI技能
         *
         * @param request ExecuteRobotAiSkillRequest
         * @param headers ExecuteRobotAiSkillHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteRobotAiSkillResponse
         */
        public async Task<ExecuteRobotAiSkillResponse> ExecuteRobotAiSkillWithOptionsAsync(ExecuteRobotAiSkillRequest request, ExecuteRobotAiSkillHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                body["context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                body["skillId"] = request.SkillId;
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
                Action = "ExecuteRobotAiSkill",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/aiSkill/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteRobotAiSkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 执行机器人的AI技能
         *
         * @param request ExecuteRobotAiSkillRequest
         * @return ExecuteRobotAiSkillResponse
         */
        public ExecuteRobotAiSkillResponse ExecuteRobotAiSkill(ExecuteRobotAiSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteRobotAiSkillHeaders headers = new ExecuteRobotAiSkillHeaders();
            return ExecuteRobotAiSkillWithOptions(request, headers, runtime);
        }

        /**
         * @summary 执行机器人的AI技能
         *
         * @param request ExecuteRobotAiSkillRequest
         * @return ExecuteRobotAiSkillResponse
         */
        public async Task<ExecuteRobotAiSkillResponse> ExecuteRobotAiSkillAsync(ExecuteRobotAiSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteRobotAiSkillHeaders headers = new ExecuteRobotAiSkillHeaders();
            return await ExecuteRobotAiSkillWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群内的机器人列表
         *
         * @param request GetBotListInGroupRequest
         * @param headers GetBotListInGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBotListInGroupResponse
         */
        public GetBotListInGroupResponse GetBotListInGroupWithOptions(GetBotListInGroupRequest request, GetBotListInGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetBotListInGroup",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groups/robots/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBotListInGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群内的机器人列表
         *
         * @param request GetBotListInGroupRequest
         * @param headers GetBotListInGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBotListInGroupResponse
         */
        public async Task<GetBotListInGroupResponse> GetBotListInGroupWithOptionsAsync(GetBotListInGroupRequest request, GetBotListInGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetBotListInGroup",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groups/robots/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBotListInGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群内的机器人列表
         *
         * @param request GetBotListInGroupRequest
         * @return GetBotListInGroupResponse
         */
        public GetBotListInGroupResponse GetBotListInGroup(GetBotListInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBotListInGroupHeaders headers = new GetBotListInGroupHeaders();
            return GetBotListInGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群内的机器人列表
         *
         * @param request GetBotListInGroupRequest
         * @return GetBotListInGroupResponse
         */
        public async Task<GetBotListInGroupResponse> GetBotListInGroupAsync(GetBotListInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBotListInGroupHeaders headers = new GetBotListInGroupHeaders();
            return await GetBotListInGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 管理机器人启用，停用状态
         *
         * @param request ManageSingleChatRobotStatusRequest
         * @param headers ManageSingleChatRobotStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageSingleChatRobotStatusResponse
         */
        public ManageSingleChatRobotStatusResponse ManageSingleChatRobotStatusWithOptions(ManageSingleChatRobotStatusRequest request, ManageSingleChatRobotStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "ManageSingleChatRobotStatus",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/statuses/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageSingleChatRobotStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 管理机器人启用，停用状态
         *
         * @param request ManageSingleChatRobotStatusRequest
         * @param headers ManageSingleChatRobotStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageSingleChatRobotStatusResponse
         */
        public async Task<ManageSingleChatRobotStatusResponse> ManageSingleChatRobotStatusWithOptionsAsync(ManageSingleChatRobotStatusRequest request, ManageSingleChatRobotStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "ManageSingleChatRobotStatus",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/statuses/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageSingleChatRobotStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 管理机器人启用，停用状态
         *
         * @param request ManageSingleChatRobotStatusRequest
         * @return ManageSingleChatRobotStatusResponse
         */
        public ManageSingleChatRobotStatusResponse ManageSingleChatRobotStatus(ManageSingleChatRobotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManageSingleChatRobotStatusHeaders headers = new ManageSingleChatRobotStatusHeaders();
            return ManageSingleChatRobotStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 管理机器人启用，停用状态
         *
         * @param request ManageSingleChatRobotStatusRequest
         * @return ManageSingleChatRobotStatusResponse
         */
        public async Task<ManageSingleChatRobotStatusResponse> ManageSingleChatRobotStatusAsync(ManageSingleChatRobotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManageSingleChatRobotStatusHeaders headers = new ManageSingleChatRobotStatusHeaders();
            return await ManageSingleChatRobotStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询企业机器人群聊消息用户已读状态
         *
         * @param request OrgGroupQueryRequest
         * @param headers OrgGroupQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupQueryResponse
         */
        public OrgGroupQueryResponse OrgGroupQueryWithOptions(OrgGroupQueryRequest request, OrgGroupQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                body["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
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
                Action = "OrgGroupQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业机器人群聊消息用户已读状态
         *
         * @param request OrgGroupQueryRequest
         * @param headers OrgGroupQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupQueryResponse
         */
        public async Task<OrgGroupQueryResponse> OrgGroupQueryWithOptionsAsync(OrgGroupQueryRequest request, OrgGroupQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                body["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
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
                Action = "OrgGroupQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业机器人群聊消息用户已读状态
         *
         * @param request OrgGroupQueryRequest
         * @return OrgGroupQueryResponse
         */
        public OrgGroupQueryResponse OrgGroupQuery(OrgGroupQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupQueryHeaders headers = new OrgGroupQueryHeaders();
            return OrgGroupQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询企业机器人群聊消息用户已读状态
         *
         * @param request OrgGroupQueryRequest
         * @return OrgGroupQueryResponse
         */
        public async Task<OrgGroupQueryResponse> OrgGroupQueryAsync(OrgGroupQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupQueryHeaders headers = new OrgGroupQueryHeaders();
            return await OrgGroupQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业机器人撤回内部群消息
         *
         * @param request OrgGroupRecallRequest
         * @param headers OrgGroupRecallHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupRecallResponse
         */
        public OrgGroupRecallResponse OrgGroupRecallWithOptions(OrgGroupRecallRequest request, OrgGroupRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "OrgGroupRecall",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupRecallResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 企业机器人撤回内部群消息
         *
         * @param request OrgGroupRecallRequest
         * @param headers OrgGroupRecallHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupRecallResponse
         */
        public async Task<OrgGroupRecallResponse> OrgGroupRecallWithOptionsAsync(OrgGroupRecallRequest request, OrgGroupRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKeys))
            {
                body["processQueryKeys"] = request.ProcessQueryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "OrgGroupRecall",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupRecallResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 企业机器人撤回内部群消息
         *
         * @param request OrgGroupRecallRequest
         * @return OrgGroupRecallResponse
         */
        public OrgGroupRecallResponse OrgGroupRecall(OrgGroupRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupRecallHeaders headers = new OrgGroupRecallHeaders();
            return OrgGroupRecallWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业机器人撤回内部群消息
         *
         * @param request OrgGroupRecallRequest
         * @return OrgGroupRecallResponse
         */
        public async Task<OrgGroupRecallResponse> OrgGroupRecallAsync(OrgGroupRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupRecallHeaders headers = new OrgGroupRecallHeaders();
            return await OrgGroupRecallWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 机器人发送群聊消息
         *
         * @param request OrgGroupSendRequest
         * @param headers OrgGroupSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupSendResponse
         */
        public OrgGroupSendResponse OrgGroupSendWithOptions(OrgGroupSendRequest request, OrgGroupSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
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
                Action = "OrgGroupSend",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupSendResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 机器人发送群聊消息
         *
         * @param request OrgGroupSendRequest
         * @param headers OrgGroupSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrgGroupSendResponse
         */
        public async Task<OrgGroupSendResponse> OrgGroupSendWithOptionsAsync(OrgGroupSendRequest request, OrgGroupSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
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
                Action = "OrgGroupSend",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgGroupSendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 机器人发送群聊消息
         *
         * @param request OrgGroupSendRequest
         * @return OrgGroupSendResponse
         */
        public OrgGroupSendResponse OrgGroupSend(OrgGroupSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
            return OrgGroupSendWithOptions(request, headers, runtime);
        }

        /**
         * @summary 机器人发送群聊消息
         *
         * @param request OrgGroupSendRequest
         * @return OrgGroupSendResponse
         */
        public async Task<OrgGroupSendResponse> OrgGroupSendAsync(OrgGroupSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
            return await OrgGroupSendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询人与人会话中机器人已读消息
         *
         * @param request PrivateChatQueryRequest
         * @param headers PrivateChatQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrivateChatQueryResponse
         */
        public PrivateChatQueryResponse PrivateChatQueryWithOptions(PrivateChatQueryRequest request, PrivateChatQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                body["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "PrivateChatQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrivateChatQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询人与人会话中机器人已读消息
         *
         * @param request PrivateChatQueryRequest
         * @param headers PrivateChatQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrivateChatQueryResponse
         */
        public async Task<PrivateChatQueryResponse> PrivateChatQueryWithOptionsAsync(PrivateChatQueryRequest request, PrivateChatQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessQueryKey))
            {
                body["processQueryKey"] = request.ProcessQueryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "PrivateChatQuery",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrivateChatQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询人与人会话中机器人已读消息
         *
         * @param request PrivateChatQueryRequest
         * @return PrivateChatQueryResponse
         */
        public PrivateChatQueryResponse PrivateChatQuery(PrivateChatQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatQueryHeaders headers = new PrivateChatQueryHeaders();
            return PrivateChatQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询人与人会话中机器人已读消息
         *
         * @param request PrivateChatQueryRequest
         * @return PrivateChatQueryResponse
         */
        public async Task<PrivateChatQueryResponse> PrivateChatQueryAsync(PrivateChatQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatQueryHeaders headers = new PrivateChatQueryHeaders();
            return await PrivateChatQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人与人会话中机器人发送普通消息
         *
         * @param request PrivateChatSendRequest
         * @param headers PrivateChatSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrivateChatSendResponse
         */
        public PrivateChatSendResponse PrivateChatSendWithOptions(PrivateChatSendRequest request, PrivateChatSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "PrivateChatSend",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrivateChatSendResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人与人会话中机器人发送普通消息
         *
         * @param request PrivateChatSendRequest
         * @param headers PrivateChatSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PrivateChatSendResponse
         */
        public async Task<PrivateChatSendResponse> PrivateChatSendWithOptionsAsync(PrivateChatSendRequest request, PrivateChatSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "PrivateChatSend",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/privateChatMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrivateChatSendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人与人会话中机器人发送普通消息
         *
         * @param request PrivateChatSendRequest
         * @return PrivateChatSendResponse
         */
        public PrivateChatSendResponse PrivateChatSend(PrivateChatSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatSendHeaders headers = new PrivateChatSendHeaders();
            return PrivateChatSendWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人与人会话中机器人发送普通消息
         *
         * @param request PrivateChatSendRequest
         * @return PrivateChatSendResponse
         */
        public async Task<PrivateChatSendResponse> PrivateChatSendAsync(PrivateChatSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatSendHeaders headers = new PrivateChatSendHeaders();
            return await PrivateChatSendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取机器人所在群信息
         *
         * @param request QueryBotInstanceInGroupInfoRequest
         * @param headers QueryBotInstanceInGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBotInstanceInGroupInfoResponse
         */
        public QueryBotInstanceInGroupInfoResponse QueryBotInstanceInGroupInfoWithOptions(QueryBotInstanceInGroupInfoRequest request, QueryBotInstanceInGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "QueryBotInstanceInGroupInfo",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBotInstanceInGroupInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取机器人所在群信息
         *
         * @param request QueryBotInstanceInGroupInfoRequest
         * @param headers QueryBotInstanceInGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBotInstanceInGroupInfoResponse
         */
        public async Task<QueryBotInstanceInGroupInfoResponse> QueryBotInstanceInGroupInfoWithOptionsAsync(QueryBotInstanceInGroupInfoRequest request, QueryBotInstanceInGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "QueryBotInstanceInGroupInfo",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBotInstanceInGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取机器人所在群信息
         *
         * @param request QueryBotInstanceInGroupInfoRequest
         * @return QueryBotInstanceInGroupInfoResponse
         */
        public QueryBotInstanceInGroupInfoResponse QueryBotInstanceInGroupInfo(QueryBotInstanceInGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBotInstanceInGroupInfoHeaders headers = new QueryBotInstanceInGroupInfoHeaders();
            return QueryBotInstanceInGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取机器人所在群信息
         *
         * @param request QueryBotInstanceInGroupInfoRequest
         * @return QueryBotInstanceInGroupInfoResponse
         */
        public async Task<QueryBotInstanceInGroupInfoResponse> QueryBotInstanceInGroupInfoAsync(QueryBotInstanceInGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBotInstanceInGroupInfoHeaders headers = new QueryBotInstanceInGroupInfoHeaders();
            return await QueryBotInstanceInGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询单聊机器人快捷入口
         *
         * @param request QueryRobotPluginRequest
         * @param headers QueryRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRobotPluginResponse
         */
        public QueryRobotPluginResponse QueryRobotPluginWithOptions(QueryRobotPluginRequest request, QueryRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "QueryRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotPluginResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询单聊机器人快捷入口
         *
         * @param request QueryRobotPluginRequest
         * @param headers QueryRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRobotPluginResponse
         */
        public async Task<QueryRobotPluginResponse> QueryRobotPluginWithOptionsAsync(QueryRobotPluginRequest request, QueryRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "QueryRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单聊机器人快捷入口
         *
         * @param request QueryRobotPluginRequest
         * @return QueryRobotPluginResponse
         */
        public QueryRobotPluginResponse QueryRobotPlugin(QueryRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRobotPluginHeaders headers = new QueryRobotPluginHeaders();
            return QueryRobotPluginWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询单聊机器人快捷入口
         *
         * @param request QueryRobotPluginRequest
         * @return QueryRobotPluginResponse
         */
        public async Task<QueryRobotPluginResponse> QueryRobotPluginAsync(QueryRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRobotPluginHeaders headers = new QueryRobotPluginHeaders();
            return await QueryRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取机器人消息中文件下载链接
         *
         * @param request RobotMessageFileDownloadRequest
         * @param headers RobotMessageFileDownloadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotMessageFileDownloadResponse
         */
        public RobotMessageFileDownloadResponse RobotMessageFileDownloadWithOptions(RobotMessageFileDownloadRequest request, RobotMessageFileDownloadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCode))
            {
                body["downloadCode"] = request.DownloadCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotMessageFileDownload",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/messageFiles/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotMessageFileDownloadResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取机器人消息中文件下载链接
         *
         * @param request RobotMessageFileDownloadRequest
         * @param headers RobotMessageFileDownloadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotMessageFileDownloadResponse
         */
        public async Task<RobotMessageFileDownloadResponse> RobotMessageFileDownloadWithOptionsAsync(RobotMessageFileDownloadRequest request, RobotMessageFileDownloadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCode))
            {
                body["downloadCode"] = request.DownloadCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotMessageFileDownload",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/messageFiles/download",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotMessageFileDownloadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取机器人消息中文件下载链接
         *
         * @param request RobotMessageFileDownloadRequest
         * @return RobotMessageFileDownloadResponse
         */
        public RobotMessageFileDownloadResponse RobotMessageFileDownload(RobotMessageFileDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageFileDownloadHeaders headers = new RobotMessageFileDownloadHeaders();
            return RobotMessageFileDownloadWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取机器人消息中文件下载链接
         *
         * @param request RobotMessageFileDownloadRequest
         * @return RobotMessageFileDownloadResponse
         */
        public async Task<RobotMessageFileDownloadResponse> RobotMessageFileDownloadAsync(RobotMessageFileDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageFileDownloadHeaders headers = new RobotMessageFileDownloadHeaders();
            return await RobotMessageFileDownloadWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 撤回已经发送的DING消息
         *
         * @param request RobotRecallDingRequest
         * @param headers RobotRecallDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotRecallDingResponse
         */
        public RobotRecallDingResponse RobotRecallDingWithOptions(RobotRecallDingRequest request, RobotRecallDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDingId))
            {
                body["openDingId"] = request.OpenDingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotRecallDing",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/ding/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotRecallDingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 撤回已经发送的DING消息
         *
         * @param request RobotRecallDingRequest
         * @param headers RobotRecallDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotRecallDingResponse
         */
        public async Task<RobotRecallDingResponse> RobotRecallDingWithOptionsAsync(RobotRecallDingRequest request, RobotRecallDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDingId))
            {
                body["openDingId"] = request.OpenDingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotRecallDing",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/ding/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotRecallDingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 撤回已经发送的DING消息
         *
         * @param request RobotRecallDingRequest
         * @return RobotRecallDingResponse
         */
        public RobotRecallDingResponse RobotRecallDing(RobotRecallDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotRecallDingHeaders headers = new RobotRecallDingHeaders();
            return RobotRecallDingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 撤回已经发送的DING消息
         *
         * @param request RobotRecallDingRequest
         * @return RobotRecallDingResponse
         */
        public async Task<RobotRecallDingResponse> RobotRecallDingAsync(RobotRecallDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotRecallDingHeaders headers = new RobotRecallDingHeaders();
            return await RobotRecallDingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送DING消息
         *
         * @param request RobotSendDingRequest
         * @param headers RobotSendDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotSendDingResponse
         */
        public RobotSendDingResponse RobotSendDingWithOptions(RobotSendDingRequest request, RobotSendDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindType))
            {
                body["remindType"] = request.RemindType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotSendDing",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/ding/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotSendDingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送DING消息
         *
         * @param request RobotSendDingRequest
         * @param headers RobotSendDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RobotSendDingResponse
         */
        public async Task<RobotSendDingResponse> RobotSendDingWithOptionsAsync(RobotSendDingRequest request, RobotSendDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindType))
            {
                body["remindType"] = request.RemindType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "RobotSendDing",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/ding/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotSendDingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送DING消息
         *
         * @param request RobotSendDingRequest
         * @return RobotSendDingResponse
         */
        public RobotSendDingResponse RobotSendDing(RobotSendDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotSendDingHeaders headers = new RobotSendDingHeaders();
            return RobotSendDingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送DING消息
         *
         * @param request RobotSendDingRequest
         * @return RobotSendDingResponse
         */
        public async Task<RobotSendDingResponse> RobotSendDingAsync(RobotSendDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotSendDingHeaders headers = new RobotSendDingHeaders();
            return await RobotSendDingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 机器人发送DING消息
         *
         * @param request SendRobotDingMessageRequest
         * @param headers SendRobotDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotDingMessageResponse
         */
        public SendRobotDingMessageResponse SendRobotDingMessageWithOptions(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentParams))
            {
                body["contentParams"] = request.ContentParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTemplateId))
            {
                body["dingTemplateId"] = request.DingTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "SendRobotDingMessage",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/dingMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotDingMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 机器人发送DING消息
         *
         * @param request SendRobotDingMessageRequest
         * @param headers SendRobotDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotDingMessageResponse
         */
        public async Task<SendRobotDingMessageResponse> SendRobotDingMessageWithOptionsAsync(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentParams))
            {
                body["contentParams"] = request.ContentParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTemplateId))
            {
                body["dingTemplateId"] = request.DingTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "SendRobotDingMessage",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/dingMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotDingMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 机器人发送DING消息
         *
         * @param request SendRobotDingMessageRequest
         * @return SendRobotDingMessageResponse
         */
        public SendRobotDingMessageResponse SendRobotDingMessage(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return SendRobotDingMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 机器人发送DING消息
         *
         * @param request SendRobotDingMessageRequest
         * @return SendRobotDingMessageResponse
         */
        public async Task<SendRobotDingMessageResponse> SendRobotDingMessageAsync(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return await SendRobotDingMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置单聊机器人快捷入口
         *
         * @param request SetRobotPluginRequest
         * @param headers SetRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRobotPluginResponse
         */
        public SetRobotPluginResponse SetRobotPluginWithOptions(SetRobotPluginRequest request, SetRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginInfoList))
            {
                body["pluginInfoList"] = request.PluginInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "SetRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRobotPluginResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置单聊机器人快捷入口
         *
         * @param request SetRobotPluginRequest
         * @param headers SetRobotPluginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRobotPluginResponse
         */
        public async Task<SetRobotPluginResponse> SetRobotPluginWithOptionsAsync(SetRobotPluginRequest request, SetRobotPluginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginInfoList))
            {
                body["pluginInfoList"] = request.PluginInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
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
                Action = "SetRobotPlugin",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/plugins/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRobotPluginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置单聊机器人快捷入口
         *
         * @param request SetRobotPluginRequest
         * @return SetRobotPluginResponse
         */
        public SetRobotPluginResponse SetRobotPlugin(SetRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotPluginHeaders headers = new SetRobotPluginHeaders();
            return SetRobotPluginWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置单聊机器人快捷入口
         *
         * @param request SetRobotPluginRequest
         * @return SetRobotPluginResponse
         */
        public async Task<SetRobotPluginResponse> SetRobotPluginAsync(SetRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotPluginHeaders headers = new SetRobotPluginHeaders();
            return await SetRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新安装到组织的机器人信息
         *
         * @param request UpdateInstalledRobotRequest
         * @param headers UpdateInstalledRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstalledRobotResponse
         */
        public UpdateInstalledRobotResponse UpdateInstalledRobotWithOptions(UpdateInstalledRobotRequest request, UpdateInstalledRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                body["updateType"] = request.UpdateType;
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
                Action = "UpdateInstalledRobot",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/managements/infos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstalledRobotResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新安装到组织的机器人信息
         *
         * @param request UpdateInstalledRobotRequest
         * @param headers UpdateInstalledRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstalledRobotResponse
         */
        public async Task<UpdateInstalledRobotResponse> UpdateInstalledRobotWithOptionsAsync(UpdateInstalledRobotRequest request, UpdateInstalledRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                body["updateType"] = request.UpdateType;
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
                Action = "UpdateInstalledRobot",
                Version = "robot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/robot/managements/infos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstalledRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新安装到组织的机器人信息
         *
         * @param request UpdateInstalledRobotRequest
         * @return UpdateInstalledRobotResponse
         */
        public UpdateInstalledRobotResponse UpdateInstalledRobot(UpdateInstalledRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstalledRobotHeaders headers = new UpdateInstalledRobotHeaders();
            return UpdateInstalledRobotWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新安装到组织的机器人信息
         *
         * @param request UpdateInstalledRobotRequest
         * @return UpdateInstalledRobotResponse
         */
        public async Task<UpdateInstalledRobotResponse> UpdateInstalledRobotAsync(UpdateInstalledRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstalledRobotHeaders headers = new UpdateInstalledRobotHeaders();
            return await UpdateInstalledRobotWithOptionsAsync(request, headers, runtime);
        }

    }
}
