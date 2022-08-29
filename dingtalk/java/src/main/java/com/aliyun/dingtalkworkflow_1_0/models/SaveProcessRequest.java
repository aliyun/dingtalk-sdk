// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessRequest extends TeaModel {
    // 表单模板描述
    @NameInMap("description")
    public String description;

    // 表单控件列表
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    // 表单模板名称
    @NameInMap("name")
    public String name;

    // 模板code
    @NameInMap("processCode")
    public String processCode;

    // 流程中心集成配置
    @NameInMap("processFeatureConfig")
    public SaveProcessRequestProcessFeatureConfig processFeatureConfig;

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

    public static class SaveProcessRequestProcessFeatureConfigFeaturesCallback extends TeaModel {
        // 网关接口标识
        @NameInMap("apiKey")
        public String apiKey;

        // 网关接口对应应用的uuid
        @NameInMap("appUuid")
        public String appUuid;

        // 网关接口版本
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

        // 手机端链接
        @NameInMap("mobileUrl")
        public String mobileUrl;

        // 名称
        @NameInMap("name")
        public String name;

        // pc端链接
        @NameInMap("pcUrl")
        public String pcUrl;

        // 运行方式：
        // ORIGIN：原生运行，即在官方审批内运行对应功能；
        // REDIRECT：外部跳转运行，需要跳转到三方地址运行对应功能
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
        // 配置列表
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

}
