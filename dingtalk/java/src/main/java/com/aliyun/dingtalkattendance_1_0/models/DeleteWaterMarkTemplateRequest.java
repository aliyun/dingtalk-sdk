// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteWaterMarkTemplateRequest extends TeaModel {
    // 模板的表单Code。
    @NameInMap("formCode")
    public String formCode;

    // 模板的内容。
    @NameInMap("formContent")
    public String formContent;

    // 群会话ID。
    @NameInMap("openConversationId")
    public String openConversationId;

    // 是否是系统模板。
    // - true：是
    // - false：否
    // 
    // 
    @NameInMap("systemTemplate")
    public Boolean systemTemplate;

    // 用户的userid。
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
