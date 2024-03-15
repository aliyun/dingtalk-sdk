// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdpaas_1_0.models;

import com.aliyun.tea.*;

public class UninstallCoolAppFromGroupRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("operateCoolAppCode")
    public String operateCoolAppCode;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("templateId")
    public String templateId;

    public static UninstallCoolAppFromGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UninstallCoolAppFromGroupRequest self = new UninstallCoolAppFromGroupRequest();
        return TeaModel.build(map, self);
    }

    public UninstallCoolAppFromGroupRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public UninstallCoolAppFromGroupRequest setOperateCoolAppCode(String operateCoolAppCode) {
        this.operateCoolAppCode = operateCoolAppCode;
        return this;
    }
    public String getOperateCoolAppCode() {
        return this.operateCoolAppCode;
    }

    public UninstallCoolAppFromGroupRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UninstallCoolAppFromGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
