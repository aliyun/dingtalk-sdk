// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppToGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxxx</p>
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
     * <p>staffid12</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>template-id-xxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static InstallCoolAppToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppToGroupRequest self = new InstallCoolAppToGroupRequest();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppToGroupRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public InstallCoolAppToGroupRequest setOperateCoolAppCode(String operateCoolAppCode) {
        this.operateCoolAppCode = operateCoolAppCode;
        return this;
    }
    public String getOperateCoolAppCode() {
        return this.operateCoolAppCode;
    }

    public InstallCoolAppToGroupRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public InstallCoolAppToGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
