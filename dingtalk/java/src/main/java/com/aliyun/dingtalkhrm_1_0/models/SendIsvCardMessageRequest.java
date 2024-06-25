// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendIsvCardMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("messageType")
    public String messageType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>16690147049882572</p>
     */
    @NameInMap("sceneType")
    public String sceneType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>同意转正</p>
     */
    @NameInMap("scope")
    public String scope;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>16690147049882572</p>
     */
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
