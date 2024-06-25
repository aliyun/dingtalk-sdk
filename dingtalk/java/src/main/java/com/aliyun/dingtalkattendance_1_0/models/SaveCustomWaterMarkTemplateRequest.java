// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>water_mark_checkin</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://xx.xx.png">https://xx.xx.png</a></p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>industry_dx_xx</p>
     */
    @NameInMap("layoutDesignId")
    public String layoutDesignId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>water_mark_checkin_open</p>
     */
    @NameInMap("sceneCode")
    public String sceneCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{ &quot;items&quot;:[ { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;enableModifyPlace&quot;, &quot;id&quot;:&quot;enableModifyPlace-undefined&quot;, &quot;value&quot;:&quot;true&quot; } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;modifyPlaceDistance&quot;, &quot;id&quot;:&quot;modifyPlaceDistance-undefined&quot;, &quot;value&quot;:200 } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;title&quot;, &quot;id&quot;:&quot;title-undefined&quot;, &quot;value&quot;:&quot;wofu1&quot; } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;titleBgColor&quot;, &quot;id&quot;:&quot;titleBgColor-undefined&quot;, &quot;value&quot;:&quot;#0089FF&quot; } } ] }</p>
     */
    @NameInMap("schemaContent")
    public String schemaContent;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manage123</p>
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
