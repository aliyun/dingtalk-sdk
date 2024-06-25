// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class UninstallCoolAppFromGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxx</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <strong>example:</strong>
     * <p>CoolApp-xxx</p>
     */
    @NameInMap("operateCoolAppCode")
    public String operateCoolAppCode;

    /**
     * <strong>example:</strong>
     * <p>staffid111</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>template-id-xxx</p>
     */
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
