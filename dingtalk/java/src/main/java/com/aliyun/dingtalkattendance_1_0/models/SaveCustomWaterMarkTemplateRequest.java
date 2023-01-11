// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateRequest extends TeaModel {
    /**
     * <p>模板的业务码：</p>
     * <p>- water_mark_checkin</p>
     * <br>
     * <br>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>模板的预览图片。</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>模板的布局ID。</p>
     */
    @NameInMap("layoutDesignId")
    public String layoutDesignId;

    /**
     * <p>模板的场景码：</p>
     * <p>- water_mark_checkin_h3yun 开放场景码</p>
     * <br>
     * <br>
     */
    @NameInMap("sceneCode")
    public String sceneCode;

    /**
     * <p>模板的内容。</p>
     */
    @NameInMap("schemaContent")
    public String schemaContent;

    /**
     * <p>模板的标题。</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>群会话ID。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>用户的userid。</p>
     */
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
