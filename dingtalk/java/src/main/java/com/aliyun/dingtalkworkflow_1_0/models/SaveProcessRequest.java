// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    @NameInMap("name")
    public String name;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("processFeatureConfig")
    public SaveProcessRequestProcessFeatureConfig processFeatureConfig;

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
        @NameInMap("apiKey")
        public String apiKey;

        @NameInMap("appUuid")
        public String appUuid;

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

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

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
        @NameInMap("createInstanceMobileUrl")
        @Deprecated
        public String createInstanceMobileUrl;

        @NameInMap("createInstancePcUrl")
        @Deprecated
        public String createInstancePcUrl;

        @NameInMap("disableSendCard")
        public Boolean disableSendCard;

        @NameInMap("hidden")
        public Boolean hidden;

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
