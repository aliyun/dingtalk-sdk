// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteWaterMarkTemplateRequest extends TeaModel {
    /**
     * <p>模板的表单Code。</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>模板的内容。</p>
     */
    @NameInMap("formContent")
    public String formContent;

    /**
     * <p>群会话ID。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>是否是系统模板。</p>
     * <p>- true：是</p>
     * <p>- false：否</p>
     * <br>
     * <br>
     */
    @NameInMap("systemTemplate")
    public Boolean systemTemplate;

    /**
     * <p>用户的userid。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteWaterMarkTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWaterMarkTemplateRequest self = new DeleteWaterMarkTemplateRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWaterMarkTemplateRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public DeleteWaterMarkTemplateRequest setFormContent(String formContent) {
        this.formContent = formContent;
        return this;
    }
    public String getFormContent() {
        return this.formContent;
    }

    public DeleteWaterMarkTemplateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DeleteWaterMarkTemplateRequest setSystemTemplate(Boolean systemTemplate) {
        this.systemTemplate = systemTemplate;
        return this;
    }
    public Boolean getSystemTemplate() {
        return this.systemTemplate;
    }

    public DeleteWaterMarkTemplateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
