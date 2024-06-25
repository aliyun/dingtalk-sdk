// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>用于员工差旅费用报销使用</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>出差报销审批</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>proc-abc</p>
     */
    @NameInMap("processCode")
    public String processCode;

    @NameInMap("processFeatureConfig")
    public SaveProcessRequestProcessFeatureConfig processFeatureConfig;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("templateConfig")
    @Deprecated
    public SaveProcessRequestTemplateConfig templateConfig;

    public static SaveProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveProcessRequest self = new SaveProcessRequest();
        return TeaModel.build(map, self);
    }

    public SaveProcessRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SaveProcessRequest setFormComponents(java.util.List<FormComponent> formComponents) {
        this.formComponents = formComponents;
        return this;
    }
    public java.util.List<FormComponent> getFormComponents() {
        return this.formComponents;
    }

    public SaveProcessRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SaveProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SaveProcessRequest setProcessFeatureConfig(SaveProcessRequestProcessFeatureConfig processFeatureConfig) {
        this.processFeatureConfig = processFeatureConfig;
        return this;
    }
    public SaveProcessRequestProcessFeatureConfig getProcessFeatureConfig() {
        return this.processFeatureConfig;
    }

    public SaveProcessRequest setTemplateConfig(SaveProcessRequestTemplateConfig templateConfig) {
        this.templateConfig = templateConfig;
        return this;
    }
    public SaveProcessRequestTemplateConfig getTemplateConfig() {
        return this.templateConfig;
    }

    public static class SaveProcessRequestProcessFeatureConfigFeaturesCallback extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("apiKey")
        public String apiKey;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("version")
        public String version;

        public static SaveProcessRequestProcessFeatureConfigFeaturesCallback build(java.util.Map<String, ?> map) throws Exception {
            SaveProcessRequestProcessFeatureConfigFeaturesCallback self = new SaveProcessRequestProcessFeatureConfigFeaturesCallback();
            return TeaModel.build(map, self);
        }

        public SaveProcessRequestProcessFeatureConfigFeaturesCallback setApiKey(String apiKey) {
            this.apiKey = apiKey;
            return this;
        }
        public String getApiKey() {
            return this.apiKey;
        }

        public SaveProcessRequestProcessFeatureConfigFeaturesCallback setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public SaveProcessRequestProcessFeatureConfigFeaturesCallback setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class SaveProcessRequestProcessFeatureConfigFeatures extends TeaModel {
        @NameInMap("callback")
        public SaveProcessRequestProcessFeatureConfigFeaturesCallback callback;

        /**
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("config")
        public String config;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <strong>example:</strong>
         * <p>ORIGIN</p>
         */
        @NameInMap("runType")
        public String runType;

        public static SaveProcessRequestProcessFeatureConfigFeatures build(java.util.Map<String, ?> map) throws Exception {
            SaveProcessRequestProcessFeatureConfigFeatures self = new SaveProcessRequestProcessFeatureConfigFeatures();
            return TeaModel.build(map, self);
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setCallback(SaveProcessRequestProcessFeatureConfigFeaturesCallback callback) {
            this.callback = callback;
            return this;
        }
        public SaveProcessRequestProcessFeatureConfigFeaturesCallback getCallback() {
            return this.callback;
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public SaveProcessRequestProcessFeatureConfigFeatures setRunType(String runType) {
            this.runType = runType;
            return this;
        }
        public String getRunType() {
            return this.runType;
        }

    }

    public static class SaveProcessRequestProcessFeatureConfig extends TeaModel {
        @NameInMap("features")
        public java.util.List<SaveProcessRequestProcessFeatureConfigFeatures> features;

        public static SaveProcessRequestProcessFeatureConfig build(java.util.Map<String, ?> map) throws Exception {
            SaveProcessRequestProcessFeatureConfig self = new SaveProcessRequestProcessFeatureConfig();
            return TeaModel.build(map, self);
        }

        public SaveProcessRequestProcessFeatureConfig setFeatures(java.util.List<SaveProcessRequestProcessFeatureConfigFeatures> features) {
            this.features = features;
            return this;
        }
        public java.util.List<SaveProcessRequestProcessFeatureConfigFeatures> getFeatures() {
            return this.features;
        }

    }

    public static class SaveProcessRequestTemplateConfig extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></p>
         */
        @NameInMap("createInstanceMobileUrl")
        @Deprecated
        public String createInstanceMobileUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></p>
         */
        @NameInMap("createInstancePcUrl")
        @Deprecated
        public String createInstancePcUrl;

        /**
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("disableSendCard")
        public Boolean disableSendCard;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hidden")
        public Boolean hidden;

        /**
         * <strong>example:</strong>
         * <p><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></p>
         * 
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("templateEditUrl")
        @Deprecated
        public String templateEditUrl;

        public static SaveProcessRequestTemplateConfig build(java.util.Map<String, ?> map) throws Exception {
            SaveProcessRequestTemplateConfig self = new SaveProcessRequestTemplateConfig();
            return TeaModel.build(map, self);
        }

        public SaveProcessRequestTemplateConfig setCreateInstanceMobileUrl(String createInstanceMobileUrl) {
            this.createInstanceMobileUrl = createInstanceMobileUrl;
            return this;
        }
        public String getCreateInstanceMobileUrl() {
            return this.createInstanceMobileUrl;
        }

        public SaveProcessRequestTemplateConfig setCreateInstancePcUrl(String createInstancePcUrl) {
            this.createInstancePcUrl = createInstancePcUrl;
            return this;
        }
        public String getCreateInstancePcUrl() {
            return this.createInstancePcUrl;
        }

        public SaveProcessRequestTemplateConfig setDisableSendCard(Boolean disableSendCard) {
            this.disableSendCard = disableSendCard;
            return this;
        }
        public Boolean getDisableSendCard() {
            return this.disableSendCard;
        }

        public SaveProcessRequestTemplateConfig setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public SaveProcessRequestTemplateConfig setTemplateEditUrl(String templateEditUrl) {
            this.templateEditUrl = templateEditUrl;
            return this;
        }
        public String getTemplateEditUrl() {
            return this.templateEditUrl;
        }

    }

}
