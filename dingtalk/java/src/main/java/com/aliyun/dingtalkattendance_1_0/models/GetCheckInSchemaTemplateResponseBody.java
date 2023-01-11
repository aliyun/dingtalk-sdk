// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckInSchemaTemplateResponseBody extends TeaModel {
    /**
     * <p>返回对象。</p>
     */
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
        /**
         * <p>是否可以修改。</p>
         */
        @NameInMap("canModify")
        public Boolean canModify;

        /**
         * <p>模板的表单Code。</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>模板的预览图片。</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>模板的布局信息。</p>
         */
        @NameInMap("layoutDesign")
        public String layoutDesign;

        /**
         * <p>模板的场景码。</p>
         */
        @NameInMap("sceneCode")
        public String sceneCode;

        /**
         * <p>模板的内容。</p>
         */
        @NameInMap("schemaContent")
        public String schemaContent;

        /**
         * <p>suiteKey。</p>
         */
        @NameInMap("suiteKey")
        public String suiteKey;

        /**
         * <p>是否系统模板。</p>
         */
        @NameInMap("systemTemplate")
        public Boolean systemTemplate;

        /**
         * <p>模板的标题。</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>模板的水印ID。</p>
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
         * <p>业务码。</p>
         */
        @NameInMap("bizCode")
        public String bizCode;

        /**
         * <p>是否可以操作模板。</p>
         */
        @NameInMap("canModifyAndAddTemplate")
        public Boolean canModifyAndAddTemplate;

        /**
         * <p>是否群管理员。</p>
         */
        @NameInMap("conversationAdmin")
        public Boolean conversationAdmin;

        /**
         * <p>自定义模板的最大数量。</p>
         */
        @NameInMap("customTemplateMaxSize")
        public Integer customTemplateMaxSize;

        /**
         * <p>群会话ID。</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>是否展示统计入口。</p>
         */
        @NameInMap("showStat")
        public Boolean showStat;

        /**
         * <p>是否开启水印模板降级。</p>
         */
        @NameInMap("templateDegrade")
        public Boolean templateDegrade;

        /**
         * <p>模板列表。</p>
         */
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
