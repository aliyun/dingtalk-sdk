// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteWaterMarkTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formCode")
    public String formCode;

    @NameInMap("formContent")
    public String formContent;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemTemplate")
    public Boolean systemTemplate;

    /**
     * <p>This parameter is required.</p>
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
