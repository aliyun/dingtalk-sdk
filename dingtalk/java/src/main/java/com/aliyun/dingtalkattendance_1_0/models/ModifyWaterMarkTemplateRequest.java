// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ModifyWaterMarkTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formCode")
    public String formCode;

    @NameInMap("icon")
    public String icon;

    @NameInMap("layoutDesignId")
    public String layoutDesignId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("schemaContent")
    public String schemaContent;

    @NameInMap("title")
    public String title;

    @NameInMap("waterMarkId")
    public String waterMarkId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
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
