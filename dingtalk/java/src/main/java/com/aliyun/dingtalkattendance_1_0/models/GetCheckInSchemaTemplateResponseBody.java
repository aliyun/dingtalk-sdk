// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckInSchemaTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCheckInSchemaTemplateResponseBodyResult result;

    public static GetCheckInSchemaTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCheckInSchemaTemplateResponseBody self = new GetCheckInSchemaTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCheckInSchemaTemplateResponseBody setResult(GetCheckInSchemaTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCheckInSchemaTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels extends TeaModel {
        @NameInMap("canModify")
        public Boolean canModify;

        /**
         * <strong>example:</strong>
         * <p>PROC-292988B1-5064-4A42-9389-xxxxx</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xx.xx.png">https://xx.xx.png</a></p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>{     &quot;widgetName&quot;:&quot;dd_watermark_xxx_xxx&quot;,     &quot;miniAppId&quot;:&quot;50000xxx&quot;,     &quot;templateRule&quot;:{         &quot;maxItems&quot;:6,         &quot;canEditColor&quot;:true,         &quot;canEditTitle&quot;:true,         &quot;items&quot;:[          ]     },     &quot;layoutDesignId&quot;:&quot;industry_xx_xx&quot;,     &quot;width&quot;:&quot;111&quot; }</p>
         */
        @NameInMap("layoutDesign")
        public String layoutDesign;

        /**
         * <strong>example:</strong>
         * <p>water_mark_checkin_open</p>
         */
        @NameInMap("sceneCode")
        public String sceneCode;

        /**
         * <strong>example:</strong>
         * <p>{     &quot;items&quot;:[         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;enableModifyPlace&quot;,                 &quot;id&quot;:&quot;enableModifyPlace-undefined&quot;,                 &quot;value&quot;:&quot;true&quot;             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;modifyPlaceDistance&quot;,                 &quot;id&quot;:&quot;modifyPlaceDistance-undefined&quot;,                 &quot;value&quot;:200             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;title&quot;,                 &quot;id&quot;:&quot;title-undefined&quot;,                 &quot;value&quot;:&quot;wofu1&quot;             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;titleBgColor&quot;,                 &quot;id&quot;:&quot;titleBgColor-undefined&quot;,                 &quot;value&quot;:&quot;#0089FF&quot;             }         }     ] }</p>
         */
        @NameInMap("schemaContent")
        public String schemaContent;

        /**
         * <strong>example:</strong>
         * <p>suiteKey</p>
         */
        @NameInMap("suiteKey")
        public String suiteKey;

        @NameInMap("systemTemplate")
        public Boolean systemTemplate;

        /**
         * <strong>example:</strong>
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>PROC-292988B1-5064-4A42-9389-xxxxx</p>
         */
        @NameInMap("waterMarkId")
        public String waterMarkId;

        public static GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels build(java.util.Map<String, ?> map) throws Exception {
            GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels self = new GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels();
            return TeaModel.build(map, self);
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setCanModify(Boolean canModify) {
            this.canModify = canModify;
            return this;
        }
        public Boolean getCanModify() {
            return this.canModify;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setLayoutDesign(String layoutDesign) {
            this.layoutDesign = layoutDesign;
            return this;
        }
        public String getLayoutDesign() {
            return this.layoutDesign;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setSceneCode(String sceneCode) {
            this.sceneCode = sceneCode;
            return this;
        }
        public String getSceneCode() {
            return this.sceneCode;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setSchemaContent(String schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public String getSchemaContent() {
            return this.schemaContent;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setSuiteKey(String suiteKey) {
            this.suiteKey = suiteKey;
            return this;
        }
        public String getSuiteKey() {
            return this.suiteKey;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setSystemTemplate(Boolean systemTemplate) {
            this.systemTemplate = systemTemplate;
            return this;
        }
        public Boolean getSystemTemplate() {
            return this.systemTemplate;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels setWaterMarkId(String waterMarkId) {
            this.waterMarkId = waterMarkId;
            return this;
        }
        public String getWaterMarkId() {
            return this.waterMarkId;
        }

    }

    public static class GetCheckInSchemaTemplateResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>water_mark_checkin</p>
         */
        @NameInMap("bizCode")
        public String bizCode;

        @NameInMap("canModifyAndAddTemplate")
        public Boolean canModifyAndAddTemplate;

        @NameInMap("conversationAdmin")
        public Boolean conversationAdmin;

        @NameInMap("customTemplateMaxSize")
        public Integer customTemplateMaxSize;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("showStat")
        public Boolean showStat;

        @NameInMap("templateDegrade")
        public Boolean templateDegrade;

        @NameInMap("waterMarkTemplateModels")
        public java.util.List<GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels> waterMarkTemplateModels;

        public static GetCheckInSchemaTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCheckInSchemaTemplateResponseBodyResult self = new GetCheckInSchemaTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCheckInSchemaTemplateResponseBodyResult setBizCode(String bizCode) {
            this.bizCode = bizCode;
            return this;
        }
        public String getBizCode() {
            return this.bizCode;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setCanModifyAndAddTemplate(Boolean canModifyAndAddTemplate) {
            this.canModifyAndAddTemplate = canModifyAndAddTemplate;
            return this;
        }
        public Boolean getCanModifyAndAddTemplate() {
            return this.canModifyAndAddTemplate;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setConversationAdmin(Boolean conversationAdmin) {
            this.conversationAdmin = conversationAdmin;
            return this;
        }
        public Boolean getConversationAdmin() {
            return this.conversationAdmin;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setCustomTemplateMaxSize(Integer customTemplateMaxSize) {
            this.customTemplateMaxSize = customTemplateMaxSize;
            return this;
        }
        public Integer getCustomTemplateMaxSize() {
            return this.customTemplateMaxSize;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setShowStat(Boolean showStat) {
            this.showStat = showStat;
            return this;
        }
        public Boolean getShowStat() {
            return this.showStat;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setTemplateDegrade(Boolean templateDegrade) {
            this.templateDegrade = templateDegrade;
            return this;
        }
        public Boolean getTemplateDegrade() {
            return this.templateDegrade;
        }

        public GetCheckInSchemaTemplateResponseBodyResult setWaterMarkTemplateModels(java.util.List<GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels> waterMarkTemplateModels) {
            this.waterMarkTemplateModels = waterMarkTemplateModels;
            return this;
        }
        public java.util.List<GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels> getWaterMarkTemplateModels() {
            return this.waterMarkTemplateModels;
        }

    }

}
