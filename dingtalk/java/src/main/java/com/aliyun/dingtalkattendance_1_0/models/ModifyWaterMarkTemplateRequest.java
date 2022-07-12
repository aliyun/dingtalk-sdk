// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ModifyWaterMarkTemplateRequest extends TeaModel {
    // 模板的表单Code。
    @NameInMap("formCode")
    public String formCode;

    // 模板的预览图片。
    @NameInMap("icon")
    public String icon;

    // 模板的布局ID。
    @NameInMap("layoutDesignId")
    public String layoutDesignId;

    // 模板的内容。
    @NameInMap("schemaContent")
    public String schemaContent;

    // 模板的标题。
    @NameInMap("title")
    public String title;

    // 模板的水印ID。
    @NameInMap("waterMarkId")
    public String waterMarkId;

    // 群会话ID。
    @NameInMap("openConversationId")
    public String openConversationId;

    // 用户的userid。
    @NameInMap("userId")
    public String userId;

    public static ModifyWaterMarkTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyWaterMarkTemplateRequest self = new ModifyWaterMarkTemplateRequest();
        return TeaModel.build(map, self);
    }

    public ModifyWaterMarkTemplateRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public ModifyWaterMarkTemplateRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public ModifyWaterMarkTemplateRequest setLayoutDesignId(String layoutDesignId) {
        this.layoutDesignId = layoutDesignId;
        return this;
    }
    public String getLayoutDesignId() {
        return this.layoutDesignId;
    }

    public ModifyWaterMarkTemplateRequest setSchemaContent(String schemaContent) {
        this.schemaContent = schemaContent;
        return this;
    }
    public String getSchemaContent() {
        return this.schemaContent;
    }

    public ModifyWaterMarkTemplateRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public ModifyWaterMarkTemplateRequest setWaterMarkId(String waterMarkId) {
        this.waterMarkId = waterMarkId;
        return this;
    }
    public String getWaterMarkId() {
        return this.waterMarkId;
    }

    public ModifyWaterMarkTemplateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ModifyWaterMarkTemplateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}