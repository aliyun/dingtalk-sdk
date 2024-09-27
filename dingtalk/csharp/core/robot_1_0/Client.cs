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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>批量查询人与机器人会话机器人消息是否已读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOTOQueryRequest
        /// </param>
        /// <param name="headers">
        /// BatchOTOQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchOTOQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询人与机器人会话机器人消息是否已读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOTOQueryRequest
        /// </param>
        /// <param name="headers">
        /// BatchOTOQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchOTOQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询人与机器人会话机器人消息是否已读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOTOQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchOTOQueryResponse
        /// </returns>
        public BatchOTOQueryResponse BatchOTOQuery(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return BatchOTOQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询人与机器人会话机器人消息是否已读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOTOQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchOTOQueryResponse
        /// </returns>
        public async Task<BatchOTOQueryResponse> BatchOTOQueryAsync(BatchOTOQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
            return await BatchOTOQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回群聊机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallGroupRequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回群聊机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallGroupRequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回群聊机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallGroupResponse
        /// </returns>
        public BatchRecallGroupResponse BatchRecallGroup(BatchRecallGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
            return BatchRecallGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回群聊机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallGroupResponse
        /// </returns>
        public async Task<BatchRecallGroupResponse> BatchRecallGroupAsync(BatchRecallGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
            return await BatchRecallGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallOTORequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallOTOHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallOTOResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallOTORequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallOTOHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallOTOResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallOTORequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallOTOResponse
        /// </returns>
        public BatchRecallOTOResponse BatchRecallOTO(BatchRecallOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
            return BatchRecallOTOWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallOTORequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallOTOResponse
        /// </returns>
        public async Task<BatchRecallOTOResponse> BatchRecallOTOAsync(BatchRecallOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
            return await BatchRecallOTOWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPrivateChatRequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallPrivateChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPrivateChatResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPrivateChatRequest
        /// </param>
        /// <param name="headers">
        /// BatchRecallPrivateChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPrivateChatResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPrivateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPrivateChatResponse
        /// </returns>
        public BatchRecallPrivateChatResponse BatchRecallPrivateChat(BatchRecallPrivateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallPrivateChatHeaders headers = new BatchRecallPrivateChatHeaders();
            return BatchRecallPrivateChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回人与人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPrivateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPrivateChatResponse
        /// </returns>
        public async Task<BatchRecallPrivateChatResponse> BatchRecallPrivateChatAsync(BatchRecallPrivateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRecallPrivateChatHeaders headers = new BatchRecallPrivateChatHeaders();
            return await BatchRecallPrivateChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOTORequest
        /// </param>
        /// <param name="headers">
        /// BatchSendOTOHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOTOResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOTORequest
        /// </param>
        /// <param name="headers">
        /// BatchSendOTOHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOTOResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOTORequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOTOResponse
        /// </returns>
        public BatchSendOTOResponse BatchSendOTO(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return BatchSendOTOWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送人与机器人会话中机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSendOTORequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendOTOResponse
        /// </returns>
        public async Task<BatchSendOTOResponse> BatchSendOTOAsync(BatchSendOTORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
            return await BatchSendOTOWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// ClearRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// ClearRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearRobotPluginResponse
        /// </returns>
        public ClearRobotPluginResponse ClearRobotPlugin(ClearRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRobotPluginHeaders headers = new ClearRobotPluginHeaders();
            return ClearRobotPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清空单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearRobotPluginResponse
        /// </returns>
        public async Task<ClearRobotPluginResponse> ClearRobotPluginAsync(ClearRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearRobotPluginHeaders headers = new ClearRobotPluginHeaders();
            return await ClearRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行机器人的AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteRobotAiSkillRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteRobotAiSkillHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRobotAiSkillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行机器人的AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteRobotAiSkillRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteRobotAiSkillHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRobotAiSkillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行机器人的AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteRobotAiSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRobotAiSkillResponse
        /// </returns>
        public ExecuteRobotAiSkillResponse ExecuteRobotAiSkill(ExecuteRobotAiSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteRobotAiSkillHeaders headers = new ExecuteRobotAiSkillHeaders();
            return ExecuteRobotAiSkillWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行机器人的AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteRobotAiSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRobotAiSkillResponse
        /// </returns>
        public async Task<ExecuteRobotAiSkillResponse> ExecuteRobotAiSkillAsync(ExecuteRobotAiSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteRobotAiSkillHeaders headers = new ExecuteRobotAiSkillHeaders();
            return await ExecuteRobotAiSkillWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内的机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBotListInGroupRequest
        /// </param>
        /// <param name="headers">
        /// GetBotListInGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBotListInGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内的机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBotListInGroupRequest
        /// </param>
        /// <param name="headers">
        /// GetBotListInGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBotListInGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内的机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBotListInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBotListInGroupResponse
        /// </returns>
        public GetBotListInGroupResponse GetBotListInGroup(GetBotListInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBotListInGroupHeaders headers = new GetBotListInGroupHeaders();
            return GetBotListInGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内的机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBotListInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBotListInGroupResponse
        /// </returns>
        public async Task<GetBotListInGroupResponse> GetBotListInGroupAsync(GetBotListInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBotListInGroupHeaders headers = new GetBotListInGroupHeaders();
            return await GetBotListInGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理机器人启用，停用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageSingleChatRobotStatusRequest
        /// </param>
        /// <param name="headers">
        /// ManageSingleChatRobotStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManageSingleChatRobotStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理机器人启用，停用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageSingleChatRobotStatusRequest
        /// </param>
        /// <param name="headers">
        /// ManageSingleChatRobotStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManageSingleChatRobotStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理机器人启用，停用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageSingleChatRobotStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ManageSingleChatRobotStatusResponse
        /// </returns>
        public ManageSingleChatRobotStatusResponse ManageSingleChatRobotStatus(ManageSingleChatRobotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManageSingleChatRobotStatusHeaders headers = new ManageSingleChatRobotStatusHeaders();
            return ManageSingleChatRobotStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理机器人启用，停用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManageSingleChatRobotStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ManageSingleChatRobotStatusResponse
        /// </returns>
        public async Task<ManageSingleChatRobotStatusResponse> ManageSingleChatRobotStatusAsync(ManageSingleChatRobotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ManageSingleChatRobotStatusHeaders headers = new ManageSingleChatRobotStatusHeaders();
            return await ManageSingleChatRobotStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业机器人群聊消息用户已读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupQueryRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业机器人群聊消息用户已读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupQueryRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业机器人群聊消息用户已读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupQueryResponse
        /// </returns>
        public OrgGroupQueryResponse OrgGroupQuery(OrgGroupQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupQueryHeaders headers = new OrgGroupQueryHeaders();
            return OrgGroupQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业机器人群聊消息用户已读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupQueryResponse
        /// </returns>
        public async Task<OrgGroupQueryResponse> OrgGroupQueryAsync(OrgGroupQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupQueryHeaders headers = new OrgGroupQueryHeaders();
            return await OrgGroupQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业机器人撤回内部群消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupRecallRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupRecallHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupRecallResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业机器人撤回内部群消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupRecallRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupRecallHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupRecallResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业机器人撤回内部群消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupRecallRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupRecallResponse
        /// </returns>
        public OrgGroupRecallResponse OrgGroupRecall(OrgGroupRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupRecallHeaders headers = new OrgGroupRecallHeaders();
            return OrgGroupRecallWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业机器人撤回内部群消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupRecallRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupRecallResponse
        /// </returns>
        public async Task<OrgGroupRecallResponse> OrgGroupRecallAsync(OrgGroupRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupRecallHeaders headers = new OrgGroupRecallHeaders();
            return await OrgGroupRecallWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupSendRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupSendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupSendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupSendRequest
        /// </param>
        /// <param name="headers">
        /// OrgGroupSendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupSendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupSendRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupSendResponse
        /// </returns>
        public OrgGroupSendResponse OrgGroupSend(OrgGroupSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
            return OrgGroupSendWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgGroupSendRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgGroupSendResponse
        /// </returns>
        public async Task<OrgGroupSendResponse> OrgGroupSendAsync(OrgGroupSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
            return await OrgGroupSendWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人与人会话中机器人已读消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatQueryRequest
        /// </param>
        /// <param name="headers">
        /// PrivateChatQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人与人会话中机器人已读消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatQueryRequest
        /// </param>
        /// <param name="headers">
        /// PrivateChatQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人与人会话中机器人已读消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatQueryResponse
        /// </returns>
        public PrivateChatQueryResponse PrivateChatQuery(PrivateChatQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatQueryHeaders headers = new PrivateChatQueryHeaders();
            return PrivateChatQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人与人会话中机器人已读消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatQueryResponse
        /// </returns>
        public async Task<PrivateChatQueryResponse> PrivateChatQueryAsync(PrivateChatQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatQueryHeaders headers = new PrivateChatQueryHeaders();
            return await PrivateChatQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人会话中机器人发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatSendRequest
        /// </param>
        /// <param name="headers">
        /// PrivateChatSendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatSendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人会话中机器人发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatSendRequest
        /// </param>
        /// <param name="headers">
        /// PrivateChatSendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatSendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人会话中机器人发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatSendRequest
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatSendResponse
        /// </returns>
        public PrivateChatSendResponse PrivateChatSend(PrivateChatSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatSendHeaders headers = new PrivateChatSendHeaders();
            return PrivateChatSendWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人会话中机器人发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrivateChatSendRequest
        /// </param>
        /// 
        /// <returns>
        /// PrivateChatSendResponse
        /// </returns>
        public async Task<PrivateChatSendResponse> PrivateChatSendAsync(PrivateChatSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrivateChatSendHeaders headers = new PrivateChatSendHeaders();
            return await PrivateChatSendWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人所在群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBotInstanceInGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryBotInstanceInGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBotInstanceInGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人所在群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBotInstanceInGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryBotInstanceInGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBotInstanceInGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人所在群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBotInstanceInGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBotInstanceInGroupInfoResponse
        /// </returns>
        public QueryBotInstanceInGroupInfoResponse QueryBotInstanceInGroupInfo(QueryBotInstanceInGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBotInstanceInGroupInfoHeaders headers = new QueryBotInstanceInGroupInfoHeaders();
            return QueryBotInstanceInGroupInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人所在群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBotInstanceInGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBotInstanceInGroupInfoResponse
        /// </returns>
        public async Task<QueryBotInstanceInGroupInfoResponse> QueryBotInstanceInGroupInfoAsync(QueryBotInstanceInGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBotInstanceInGroupInfoHeaders headers = new QueryBotInstanceInGroupInfoHeaders();
            return await QueryBotInstanceInGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// QueryRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// QueryRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotPluginResponse
        /// </returns>
        public QueryRobotPluginResponse QueryRobotPlugin(QueryRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRobotPluginHeaders headers = new QueryRobotPluginHeaders();
            return QueryRobotPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotPluginResponse
        /// </returns>
        public async Task<QueryRobotPluginResponse> QueryRobotPluginAsync(QueryRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRobotPluginHeaders headers = new QueryRobotPluginHeaders();
            return await QueryRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人消息中文件下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotMessageFileDownloadRequest
        /// </param>
        /// <param name="headers">
        /// RobotMessageFileDownloadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotMessageFileDownloadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人消息中文件下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotMessageFileDownloadRequest
        /// </param>
        /// <param name="headers">
        /// RobotMessageFileDownloadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotMessageFileDownloadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人消息中文件下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotMessageFileDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotMessageFileDownloadResponse
        /// </returns>
        public RobotMessageFileDownloadResponse RobotMessageFileDownload(RobotMessageFileDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageFileDownloadHeaders headers = new RobotMessageFileDownloadHeaders();
            return RobotMessageFileDownloadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取机器人消息中文件下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotMessageFileDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotMessageFileDownloadResponse
        /// </returns>
        public async Task<RobotMessageFileDownloadResponse> RobotMessageFileDownloadAsync(RobotMessageFileDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageFileDownloadHeaders headers = new RobotMessageFileDownloadHeaders();
            return await RobotMessageFileDownloadWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回已经发送的DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotRecallDingRequest
        /// </param>
        /// <param name="headers">
        /// RobotRecallDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotRecallDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回已经发送的DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotRecallDingRequest
        /// </param>
        /// <param name="headers">
        /// RobotRecallDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotRecallDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回已经发送的DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotRecallDingRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotRecallDingResponse
        /// </returns>
        public RobotRecallDingResponse RobotRecallDing(RobotRecallDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotRecallDingHeaders headers = new RobotRecallDingHeaders();
            return RobotRecallDingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤回已经发送的DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotRecallDingRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotRecallDingResponse
        /// </returns>
        public async Task<RobotRecallDingResponse> RobotRecallDingAsync(RobotRecallDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotRecallDingHeaders headers = new RobotRecallDingHeaders();
            return await RobotRecallDingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotSendDingRequest
        /// </param>
        /// <param name="headers">
        /// RobotSendDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotSendDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotSendDingRequest
        /// </param>
        /// <param name="headers">
        /// RobotSendDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotSendDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotSendDingRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotSendDingResponse
        /// </returns>
        public RobotSendDingResponse RobotSendDing(RobotSendDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotSendDingHeaders headers = new RobotSendDingHeaders();
            return RobotSendDingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RobotSendDingRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotSendDingResponse
        /// </returns>
        public async Task<RobotSendDingResponse> RobotSendDingAsync(RobotSendDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotSendDingHeaders headers = new RobotSendDingHeaders();
            return await RobotSendDingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotDingMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotDingMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotDingMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotDingMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotDingMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotDingMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotDingMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotDingMessageResponse
        /// </returns>
        public SendRobotDingMessageResponse SendRobotDingMessage(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return SendRobotDingMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送DING消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotDingMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotDingMessageResponse
        /// </returns>
        public async Task<SendRobotDingMessageResponse> SendRobotDingMessageAsync(SendRobotDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
            return await SendRobotDingMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// SetRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRobotPluginRequest
        /// </param>
        /// <param name="headers">
        /// SetRobotPluginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRobotPluginResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRobotPluginResponse
        /// </returns>
        public SetRobotPluginResponse SetRobotPlugin(SetRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotPluginHeaders headers = new SetRobotPluginHeaders();
            return SetRobotPluginWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单聊机器人快捷入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRobotPluginRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRobotPluginResponse
        /// </returns>
        public async Task<SetRobotPluginResponse> SetRobotPluginAsync(SetRobotPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotPluginHeaders headers = new SetRobotPluginHeaders();
            return await SetRobotPluginWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安装到组织的机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstalledRobotRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstalledRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstalledRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安装到组织的机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstalledRobotRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstalledRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstalledRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安装到组织的机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstalledRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstalledRobotResponse
        /// </returns>
        public UpdateInstalledRobotResponse UpdateInstalledRobot(UpdateInstalledRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstalledRobotHeaders headers = new UpdateInstalledRobotHeaders();
            return UpdateInstalledRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安装到组织的机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstalledRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstalledRobotResponse
        /// </returns>
        public async Task<UpdateInstalledRobotResponse> UpdateInstalledRobotAsync(UpdateInstalledRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstalledRobotHeaders headers = new UpdateInstalledRobotHeaders();
            return await UpdateInstalledRobotWithOptionsAsync(request, headers, runtime);
        }

    }
}
