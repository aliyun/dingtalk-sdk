// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrobot_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>批量查询人与机器人会话机器人消息是否已读</p>
     * 
     * @param request BatchOTOQueryRequest
     * @param headers BatchOTOQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchOTOQueryResponse
     */
    public BatchOTOQueryResponse batchOTOQueryWithOptions(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKey)) {
            query.put("processQueryKey", request.processQueryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            query.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchOTOQuery"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/oToMessages/readStatus"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchOTOQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询人与机器人会话机器人消息是否已读</p>
     * 
     * @param request BatchOTOQueryRequest
     * @return BatchOTOQueryResponse
     */
    public BatchOTOQueryResponse batchOTOQuery(BatchOTOQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
        return this.batchOTOQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回群聊机器人消息</p>
     * 
     * @param request BatchRecallGroupRequest
     * @param headers BatchRecallGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRecallGroupResponse
     */
    public BatchRecallGroupResponse batchRecallGroupWithOptions(BatchRecallGroupRequest request, BatchRecallGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRecallGroup"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groupMessages/batchRecall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRecallGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回群聊机器人消息</p>
     * 
     * @param request BatchRecallGroupRequest
     * @return BatchRecallGroupResponse
     */
    public BatchRecallGroupResponse batchRecallGroup(BatchRecallGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
        return this.batchRecallGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回人与机器人会话中机器人消息</p>
     * 
     * @param request BatchRecallOTORequest
     * @param headers BatchRecallOTOHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRecallOTOResponse
     */
    public BatchRecallOTOResponse batchRecallOTOWithOptions(BatchRecallOTORequest request, BatchRecallOTOHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRecallOTO"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/otoMessages/batchRecall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRecallOTOResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回人与机器人会话中机器人消息</p>
     * 
     * @param request BatchRecallOTORequest
     * @return BatchRecallOTOResponse
     */
    public BatchRecallOTOResponse batchRecallOTO(BatchRecallOTORequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
        return this.batchRecallOTOWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回人与人会话中机器人消息</p>
     * 
     * @param request BatchRecallPrivateChatRequest
     * @param headers BatchRecallPrivateChatHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRecallPrivateChatResponse
     */
    public BatchRecallPrivateChatResponse batchRecallPrivateChatWithOptions(BatchRecallPrivateChatRequest request, BatchRecallPrivateChatHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRecallPrivateChat"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/privateChatMessages/batchRecall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRecallPrivateChatResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量撤回人与人会话中机器人消息</p>
     * 
     * @param request BatchRecallPrivateChatRequest
     * @return BatchRecallPrivateChatResponse
     */
    public BatchRecallPrivateChatResponse batchRecallPrivateChat(BatchRecallPrivateChatRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRecallPrivateChatHeaders headers = new BatchRecallPrivateChatHeaders();
        return this.batchRecallPrivateChatWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量发送人与机器人会话中机器人消息</p>
     * 
     * @param request BatchSendOTORequest
     * @param headers BatchSendOTOHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchSendOTOResponse
     */
    public BatchSendOTOResponse batchSendOTOWithOptions(BatchSendOTORequest request, BatchSendOTOHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchSendOTO"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/oToMessages/batchSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchSendOTOResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量发送人与机器人会话中机器人消息</p>
     * 
     * @param request BatchSendOTORequest
     * @return BatchSendOTOResponse
     */
    public BatchSendOTOResponse batchSendOTO(BatchSendOTORequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
        return this.batchSendOTOWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>清空单聊机器人快捷入口</p>
     * 
     * @param request ClearRobotPluginRequest
     * @param headers ClearRobotPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearRobotPluginResponse
     */
    public ClearRobotPluginResponse clearRobotPluginWithOptions(ClearRobotPluginRequest request, ClearRobotPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ClearRobotPlugin"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/plugins/clear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearRobotPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>清空单聊机器人快捷入口</p>
     * 
     * @param request ClearRobotPluginRequest
     * @return ClearRobotPluginResponse
     */
    public ClearRobotPluginResponse clearRobotPlugin(ClearRobotPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearRobotPluginHeaders headers = new ClearRobotPluginHeaders();
        return this.clearRobotPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>执行机器人的AI技能</p>
     * 
     * @param request ExecuteRobotAiSkillRequest
     * @param headers ExecuteRobotAiSkillHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExecuteRobotAiSkillResponse
     */
    public ExecuteRobotAiSkillResponse executeRobotAiSkillWithOptions(ExecuteRobotAiSkillRequest request, ExecuteRobotAiSkillHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.context)) {
            body.put("context", request.context);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.input)) {
            body.put("input", request.input);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skillId)) {
            body.put("skillId", request.skillId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ExecuteRobotAiSkill"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/aiSkill/execute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExecuteRobotAiSkillResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>执行机器人的AI技能</p>
     * 
     * @param request ExecuteRobotAiSkillRequest
     * @return ExecuteRobotAiSkillResponse
     */
    public ExecuteRobotAiSkillResponse executeRobotAiSkill(ExecuteRobotAiSkillRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteRobotAiSkillHeaders headers = new ExecuteRobotAiSkillHeaders();
        return this.executeRobotAiSkillWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询群内的机器人列表</p>
     * 
     * @param request GetBotListInGroupRequest
     * @param headers GetBotListInGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBotListInGroupResponse
     */
    public GetBotListInGroupResponse getBotListInGroupWithOptions(GetBotListInGroupRequest request, GetBotListInGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetBotListInGroup"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groups/robots/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBotListInGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询群内的机器人列表</p>
     * 
     * @param request GetBotListInGroupRequest
     * @return GetBotListInGroupResponse
     */
    public GetBotListInGroupResponse getBotListInGroup(GetBotListInGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBotListInGroupHeaders headers = new GetBotListInGroupHeaders();
        return this.getBotListInGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>管理机器人启用，停用状态</p>
     * 
     * @param request ManageSingleChatRobotStatusRequest
     * @param headers ManageSingleChatRobotStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManageSingleChatRobotStatusResponse
     */
    public ManageSingleChatRobotStatusResponse manageSingleChatRobotStatusWithOptions(ManageSingleChatRobotStatusRequest request, ManageSingleChatRobotStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ManageSingleChatRobotStatus"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/statuses/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManageSingleChatRobotStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>管理机器人启用，停用状态</p>
     * 
     * @param request ManageSingleChatRobotStatusRequest
     * @return ManageSingleChatRobotStatusResponse
     */
    public ManageSingleChatRobotStatusResponse manageSingleChatRobotStatus(ManageSingleChatRobotStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManageSingleChatRobotStatusHeaders headers = new ManageSingleChatRobotStatusHeaders();
        return this.manageSingleChatRobotStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业机器人群聊消息用户已读状态</p>
     * 
     * @param request OrgGroupQueryRequest
     * @param headers OrgGroupQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgGroupQueryResponse
     */
    public OrgGroupQueryResponse orgGroupQueryWithOptions(OrgGroupQueryRequest request, OrgGroupQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKey)) {
            body.put("processQueryKey", request.processQueryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OrgGroupQuery"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groupMessages/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgGroupQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业机器人群聊消息用户已读状态</p>
     * 
     * @param request OrgGroupQueryRequest
     * @return OrgGroupQueryResponse
     */
    public OrgGroupQueryResponse orgGroupQuery(OrgGroupQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgGroupQueryHeaders headers = new OrgGroupQueryHeaders();
        return this.orgGroupQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>企业机器人撤回内部群消息</p>
     * 
     * @param request OrgGroupRecallRequest
     * @param headers OrgGroupRecallHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgGroupRecallResponse
     */
    public OrgGroupRecallResponse orgGroupRecallWithOptions(OrgGroupRecallRequest request, OrgGroupRecallHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OrgGroupRecall"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groupMessages/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgGroupRecallResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业机器人撤回内部群消息</p>
     * 
     * @param request OrgGroupRecallRequest
     * @return OrgGroupRecallResponse
     */
    public OrgGroupRecallResponse orgGroupRecall(OrgGroupRecallRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgGroupRecallHeaders headers = new OrgGroupRecallHeaders();
        return this.orgGroupRecallWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>机器人发送群聊消息</p>
     * 
     * @param request OrgGroupSendRequest
     * @param headers OrgGroupSendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrgGroupSendResponse
     */
    public OrgGroupSendResponse orgGroupSendWithOptions(OrgGroupSendRequest request, OrgGroupSendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OrgGroupSend"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groupMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrgGroupSendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>机器人发送群聊消息</p>
     * 
     * @param request OrgGroupSendRequest
     * @return OrgGroupSendResponse
     */
    public OrgGroupSendResponse orgGroupSend(OrgGroupSendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
        return this.orgGroupSendWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询人与人会话中机器人已读消息</p>
     * 
     * @param request PrivateChatQueryRequest
     * @param headers PrivateChatQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PrivateChatQueryResponse
     */
    public PrivateChatQueryResponse privateChatQueryWithOptions(PrivateChatQueryRequest request, PrivateChatQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKey)) {
            body.put("processQueryKey", request.processQueryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PrivateChatQuery"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/privateChatMessages/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PrivateChatQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询人与人会话中机器人已读消息</p>
     * 
     * @param request PrivateChatQueryRequest
     * @return PrivateChatQueryResponse
     */
    public PrivateChatQueryResponse privateChatQuery(PrivateChatQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PrivateChatQueryHeaders headers = new PrivateChatQueryHeaders();
        return this.privateChatQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人与人会话中机器人发送普通消息</p>
     * 
     * @param request PrivateChatSendRequest
     * @param headers PrivateChatSendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PrivateChatSendResponse
     */
    public PrivateChatSendResponse privateChatSendWithOptions(PrivateChatSendRequest request, PrivateChatSendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PrivateChatSend"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/privateChatMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PrivateChatSendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人与人会话中机器人发送普通消息</p>
     * 
     * @param request PrivateChatSendRequest
     * @return PrivateChatSendResponse
     */
    public PrivateChatSendResponse privateChatSend(PrivateChatSendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PrivateChatSendHeaders headers = new PrivateChatSendHeaders();
        return this.privateChatSendWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取机器人所在群信息</p>
     * 
     * @param request QueryBotInstanceInGroupInfoRequest
     * @param headers QueryBotInstanceInGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBotInstanceInGroupInfoResponse
     */
    public QueryBotInstanceInGroupInfoResponse queryBotInstanceInGroupInfoWithOptions(QueryBotInstanceInGroupInfoRequest request, QueryBotInstanceInGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryBotInstanceInGroupInfo"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/groups/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBotInstanceInGroupInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取机器人所在群信息</p>
     * 
     * @param request QueryBotInstanceInGroupInfoRequest
     * @return QueryBotInstanceInGroupInfoResponse
     */
    public QueryBotInstanceInGroupInfoResponse queryBotInstanceInGroupInfo(QueryBotInstanceInGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBotInstanceInGroupInfoHeaders headers = new QueryBotInstanceInGroupInfoHeaders();
        return this.queryBotInstanceInGroupInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询单聊机器人快捷入口</p>
     * 
     * @param request QueryRobotPluginRequest
     * @param headers QueryRobotPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRobotPluginResponse
     */
    public QueryRobotPluginResponse queryRobotPluginWithOptions(QueryRobotPluginRequest request, QueryRobotPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryRobotPlugin"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/plugins/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRobotPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询单聊机器人快捷入口</p>
     * 
     * @param request QueryRobotPluginRequest
     * @return QueryRobotPluginResponse
     */
    public QueryRobotPluginResponse queryRobotPlugin(QueryRobotPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRobotPluginHeaders headers = new QueryRobotPluginHeaders();
        return this.queryRobotPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取机器人消息中文件下载链接</p>
     * 
     * @param request RobotMessageFileDownloadRequest
     * @param headers RobotMessageFileDownloadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RobotMessageFileDownloadResponse
     */
    public RobotMessageFileDownloadResponse robotMessageFileDownloadWithOptions(RobotMessageFileDownloadRequest request, RobotMessageFileDownloadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.downloadCode)) {
            body.put("downloadCode", request.downloadCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RobotMessageFileDownload"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/messageFiles/download"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RobotMessageFileDownloadResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取机器人消息中文件下载链接</p>
     * 
     * @param request RobotMessageFileDownloadRequest
     * @return RobotMessageFileDownloadResponse
     */
    public RobotMessageFileDownloadResponse robotMessageFileDownload(RobotMessageFileDownloadRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RobotMessageFileDownloadHeaders headers = new RobotMessageFileDownloadHeaders();
        return this.robotMessageFileDownloadWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤回已经发送的DING消息</p>
     * 
     * @param request RobotRecallDingRequest
     * @param headers RobotRecallDingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RobotRecallDingResponse
     */
    public RobotRecallDingResponse robotRecallDingWithOptions(RobotRecallDingRequest request, RobotRecallDingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openDingId)) {
            body.put("openDingId", request.openDingId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RobotRecallDing"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/ding/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RobotRecallDingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤回已经发送的DING消息</p>
     * 
     * @param request RobotRecallDingRequest
     * @return RobotRecallDingResponse
     */
    public RobotRecallDingResponse robotRecallDing(RobotRecallDingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RobotRecallDingHeaders headers = new RobotRecallDingHeaders();
        return this.robotRecallDingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送DING消息</p>
     * 
     * @param request RobotSendDingRequest
     * @param headers RobotSendDingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RobotSendDingResponse
     */
    public RobotSendDingResponse robotSendDingWithOptions(RobotSendDingRequest request, RobotSendDingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remindType)) {
            body.put("remindType", request.remindType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RobotSendDing"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/ding/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RobotSendDingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送DING消息</p>
     * 
     * @param request RobotSendDingRequest
     * @return RobotSendDingResponse
     */
    public RobotSendDingResponse robotSendDing(RobotSendDingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RobotSendDingHeaders headers = new RobotSendDingHeaders();
        return this.robotSendDingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>机器人发送DING消息</p>
     * 
     * @param request SendRobotDingMessageRequest
     * @param headers SendRobotDingMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendRobotDingMessageResponse
     */
    public SendRobotDingMessageResponse sendRobotDingMessageWithOptions(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contentParams)) {
            body.put("contentParams", request.contentParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTemplateId)) {
            body.put("dingTemplateId", request.dingTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SendRobotDingMessage"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/dingMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendRobotDingMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>机器人发送DING消息</p>
     * 
     * @param request SendRobotDingMessageRequest
     * @return SendRobotDingMessageResponse
     */
    public SendRobotDingMessageResponse sendRobotDingMessage(SendRobotDingMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
        return this.sendRobotDingMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置单聊机器人快捷入口</p>
     * 
     * @param request SetRobotPluginRequest
     * @param headers SetRobotPluginHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetRobotPluginResponse
     */
    public SetRobotPluginResponse setRobotPluginWithOptions(SetRobotPluginRequest request, SetRobotPluginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pluginInfoList)) {
            body.put("pluginInfoList", request.pluginInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetRobotPlugin"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/plugins/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetRobotPluginResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置单聊机器人快捷入口</p>
     * 
     * @param request SetRobotPluginRequest
     * @return SetRobotPluginResponse
     */
    public SetRobotPluginResponse setRobotPlugin(SetRobotPluginRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetRobotPluginHeaders headers = new SetRobotPluginHeaders();
        return this.setRobotPluginWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新安装到组织的机器人信息</p>
     * 
     * @param request UpdateInstalledRobotRequest
     * @param headers UpdateInstalledRobotHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInstalledRobotResponse
     */
    public UpdateInstalledRobotResponse updateInstalledRobotWithOptions(UpdateInstalledRobotRequest request, UpdateInstalledRobotHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.brief)) {
            body.put("brief", request.brief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateType)) {
            body.put("updateType", request.updateType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateInstalledRobot"),
            new TeaPair("version", "robot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/robot/managements/infos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInstalledRobotResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新安装到组织的机器人信息</p>
     * 
     * @param request UpdateInstalledRobotRequest
     * @return UpdateInstalledRobotResponse
     */
    public UpdateInstalledRobotResponse updateInstalledRobot(UpdateInstalledRobotRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInstalledRobotHeaders headers = new UpdateInstalledRobotHeaders();
        return this.updateInstalledRobotWithOptions(request, headers, runtime);
    }
}
