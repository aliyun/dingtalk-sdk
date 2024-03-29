// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendIsvCardMessageRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("messageType")
    public String messageType;

    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    @NameInMap("sceneType")
    public String sceneType;

    @NameInMap("scope")
    public String scope;

    @NameInMap("senderUserId")
    public String senderUserId;

    @NameInMap("valueMap")
    public java.util.Map<String, String> valueMap;

    public static SendIsvCardMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendIsvCardMessageRequest self = new SendIsvCardMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendIsvCardMessageRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public SendIsvCardMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendIsvCardMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public SendIsvCardMessageRequest setReceiverUserIds(java.util.List<String> receiverUserIds) {
        this.receiverUserIds = receiverUserIds;
        return this;
    }
    public java.util.List<String> getReceiverUserIds() {
        return this.receiverUserIds;
    }

    public SendIsvCardMessageRequest setSceneType(String sceneType) {
        this.sceneType = sceneType;
        return this;
    }
    public String getSceneType() {
        return this.sceneType;
    }

    public SendIsvCardMessageRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public SendIsvCardMessageRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

    public SendIsvCardMessageRequest setValueMap(java.util.Map<String, String> valueMap) {
        this.valueMap = valueMap;
        return this;
    }
    public java.util.Map<String, String> getValueMap() {
        return this.valueMap;
    }

}
