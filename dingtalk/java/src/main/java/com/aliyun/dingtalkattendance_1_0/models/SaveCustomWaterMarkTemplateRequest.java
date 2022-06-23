// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateRequest extends TeaModel {
    // 模板的业务码：
    // - water_mark_checkin
    // 
    // 
    @NameInMap("bizCode")
    public String bizCode;

    // 模板的预览图片。
    @NameInMap("icon")
    public String icon;

    // 模板的布局ID。
    @NameInMap("layoutDesignId")
    public String layoutDesignId;

    // 模板的场景码：
    // - water_mark_checkin_h3yun 开放场景码
    // 
    // 
    @NameInMap("sceneCode")
    public String sceneCode;

    // 模板的内容。
    @NameInMap("schemaContent")
    public String schemaContent;

    // 模板的标题。
    @NameInMap("title")
    public String title;

    // 群会话ID。
    @NameInMap("openConversationId")
    public String openConversationId;

    // 用户的userid。
    @NameInMap("userId")
    public String userId;

    public static SaveCustomWaterMarkTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveCustomWaterMarkTemplateRequest self = new SaveCustomWaterMarkTemplateRequest();
        return TeaModel.build(map, self);
    }

    public SaveCustomWaterMarkTemplateRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public SaveCustomWaterMarkTemplateRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public SaveCustomWaterMarkTemplateRequest setLayoutDesignId(String layoutDesignId) {
        this.layoutDesignId = layoutDesignId;
        return this;
    }
    public String getLayoutDesignId() {
        return this.layoutDesignId;
    }

    public SaveCustomWaterMarkTemplateRequest setSceneCode(String sceneCode) {
        this.sceneCode = sceneCode;
        return this;
    }
    public String getSceneCode() {
        return this.sceneCode;
    }

    public SaveCustomWaterMarkTemplateRequest setSchemaContent(String schemaContent) {
        this.schemaContent = schemaContent;
        return this;
    }
    public String getSchemaContent() {
        return this.schemaContent;
    }

    public SaveCustomWaterMarkTemplateRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SaveCustomWaterMarkTemplateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SaveCustomWaterMarkTemplateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
