// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvCardMessageRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("messageType")
    public String messageType;

    @NameInMap("sceneType")
    public String sceneType;

    @NameInMap("scope")
    public String scope;

    @NameInMap("valueMap")
    public java.util.Map<String, String> valueMap;

    public static UpdateIsvCardMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvCardMessageRequest self = new UpdateIsvCardMessageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateIsvCardMessageRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public UpdateIsvCardMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public UpdateIsvCardMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public UpdateIsvCardMessageRequest setSceneType(String sceneType) {
        this.sceneType = sceneType;
        return this;
    }
    public String getSceneType() {
        return this.sceneType;
    }

    public UpdateIsvCardMessageRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public UpdateIsvCardMessageRequest setValueMap(java.util.Map<String, String> valueMap) {
        this.valueMap = valueMap;
        return this;
    }
    public java.util.Map<String, String> getValueMap() {
        return this.valueMap;
    }

}
