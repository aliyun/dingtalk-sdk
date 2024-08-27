// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessRequest extends TeaModel {
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
    public PremiumSaveIntegratedProcessRequestProcessFeatureConfig processFeatureConfig;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("templateConfig")
    @Deprecated
    public PremiumSaveIntegratedProcessRequestTemplateConfig templateConfig;

    public static PremiumSaveIntegratedProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessRequest self = new PremiumSaveIntegratedProcessRequest();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PremiumSaveIntegratedProcessRequest setFormComponents(java.util.List<FormComponent> formComponents) {
        this.formComponents = formComponents;
        return this;
    }
    public java.util.List<FormComponent> getFormComponents() {
        return this.formComponents;
    }

    public PremiumSaveIntegratedProcessRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public PremiumSaveIntegratedProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumSaveIntegratedProcessRequest setProcessFeatureConfig(PremiumSaveIntegratedProcessRequestProcessFeatureConfig processFeatureConfig) {
        this.processFeatureConfig = processFeatureConfig;
        return this;
    }
    public PremiumSaveIntegratedProcessRequestProcessFeatureConfig getProcessFeatureConfig() {
        return this.processFeatureConfig;
    }

    public PremiumSaveIntegratedProcessRequest setTemplateConfig(PremiumSaveIntegratedProcessRequestTemplateConfig templateConfig) {
        this.templateConfig = templateConfig;
        return this;
    }
    public PremiumSaveIntegratedProcessRequestTemplateConfig getTemplateConfig() {
        return this.templateConfig;
    }

    public static class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback extends TeaModel {
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

        public static PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback self = new PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback setApiKey(String apiKey) {
            this.apiKey = apiKey;
            return this;
        }
        public String getApiKey() {
            return this.apiKey;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures extends TeaModel {
        @NameInMap("callback")
        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback callback;

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

        public static PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures self = new PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures setCallback(PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback callback) {
            this.callback = callback;
            return this;
        }
        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback getCallback() {
            return this.callback;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures setRunType(String runType) {
            this.runType = runType;
            return this;
        }
        public String getRunType() {
            return this.runType;
        }

    }

    public static class PremiumSaveIntegratedProcessRequestProcessFeatureConfig extends TeaModel {
        @NameInMap("features")
        public java.util.List<PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures> features;

        public static PremiumSaveIntegratedProcessRequestProcessFeatureConfig build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessRequestProcessFeatureConfig self = new PremiumSaveIntegratedProcessRequestProcessFeatureConfig();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessRequestProcessFeatureConfig setFeatures(java.util.List<PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures> features) {
            this.features = features;
            return this;
        }
        public java.util.List<PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures> getFeatures() {
            return this.features;
        }

    }

    public static class PremiumSaveIntegratedProcessRequestTemplateConfig extends TeaModel {
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

        public static PremiumSaveIntegratedProcessRequestTemplateConfig build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessRequestTemplateConfig self = new PremiumSaveIntegratedProcessRequestTemplateConfig();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessRequestTemplateConfig setCreateInstanceMobileUrl(String createInstanceMobileUrl) {
            this.createInstanceMobileUrl = createInstanceMobileUrl;
            return this;
        }
        public String getCreateInstanceMobileUrl() {
            return this.createInstanceMobileUrl;
        }

        public PremiumSaveIntegratedProcessRequestTemplateConfig setCreateInstancePcUrl(String createInstancePcUrl) {
            this.createInstancePcUrl = createInstancePcUrl;
            return this;
        }
        public String getCreateInstancePcUrl() {
            return this.createInstancePcUrl;
        }

        public PremiumSaveIntegratedProcessRequestTemplateConfig setDisableSendCard(Boolean disableSendCard) {
            this.disableSendCard = disableSendCard;
            return this;
        }
        public Boolean getDisableSendCard() {
            return this.disableSendCard;
        }

        public PremiumSaveIntegratedProcessRequestTemplateConfig setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public PremiumSaveIntegratedProcessRequestTemplateConfig setTemplateEditUrl(String templateEditUrl) {
            this.templateEditUrl = templateEditUrl;
            return this;
        }
        public String getTemplateEditUrl() {
            return this.templateEditUrl;
        }

    }

}
