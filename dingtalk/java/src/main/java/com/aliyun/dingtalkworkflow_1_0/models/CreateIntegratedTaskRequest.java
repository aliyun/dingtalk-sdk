// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CreateIntegratedTaskRequest extends TeaModel {
    @NameInMap("activityId")
    public String activityId;

    @NameInMap("featureConfig")
    public CreateIntegratedTaskRequestFeatureConfig featureConfig;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tasks")
    public java.util.List<CreateIntegratedTaskRequestTasks> tasks;

    public static CreateIntegratedTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateIntegratedTaskRequest self = new CreateIntegratedTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateIntegratedTaskRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public CreateIntegratedTaskRequest setFeatureConfig(CreateIntegratedTaskRequestFeatureConfig featureConfig) {
        this.featureConfig = featureConfig;
        return this;
    }
    public CreateIntegratedTaskRequestFeatureConfig getFeatureConfig() {
        return this.featureConfig;
    }

    public CreateIntegratedTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public CreateIntegratedTaskRequest setTasks(java.util.List<CreateIntegratedTaskRequestTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<CreateIntegratedTaskRequestTasks> getTasks() {
        return this.tasks;
    }

    public static class CreateIntegratedTaskRequestFeatureConfigFeaturesCallback extends TeaModel {
        @NameInMap("apiKey")
        public String apiKey;

        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("version")
        public String version;

        public static CreateIntegratedTaskRequestFeatureConfigFeaturesCallback build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskRequestFeatureConfigFeaturesCallback self = new CreateIntegratedTaskRequestFeatureConfigFeaturesCallback();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback setApiKey(String apiKey) {
            this.apiKey = apiKey;
            return this;
        }
        public String getApiKey() {
            return this.apiKey;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class CreateIntegratedTaskRequestFeatureConfigFeatures extends TeaModel {
        @NameInMap("callback")
        public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback callback;

        @NameInMap("config")
        public String config;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("runType")
        public String runType;

        public static CreateIntegratedTaskRequestFeatureConfigFeatures build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskRequestFeatureConfigFeatures self = new CreateIntegratedTaskRequestFeatureConfigFeatures();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setCallback(CreateIntegratedTaskRequestFeatureConfigFeaturesCallback callback) {
            this.callback = callback;
            return this;
        }
        public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback getCallback() {
            return this.callback;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateIntegratedTaskRequestFeatureConfigFeatures setRunType(String runType) {
            this.runType = runType;
            return this;
        }
        public String getRunType() {
            return this.runType;
        }

    }

    public static class CreateIntegratedTaskRequestFeatureConfig extends TeaModel {
        @NameInMap("features")
        public java.util.List<CreateIntegratedTaskRequestFeatureConfigFeatures> features;

        public static CreateIntegratedTaskRequestFeatureConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskRequestFeatureConfig self = new CreateIntegratedTaskRequestFeatureConfig();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskRequestFeatureConfig setFeatures(java.util.List<CreateIntegratedTaskRequestFeatureConfigFeatures> features) {
            this.features = features;
            return this;
        }
        public java.util.List<CreateIntegratedTaskRequestFeatureConfigFeatures> getFeatures() {
            return this.features;
        }

    }

    public static class CreateIntegratedTaskRequestTasks extends TeaModel {
        @NameInMap("customData")
        public String customData;

        @NameInMap("url")
        public String url;

        @NameInMap("userId")
        public String userId;

        public static CreateIntegratedTaskRequestTasks build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskRequestTasks self = new CreateIntegratedTaskRequestTasks();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskRequestTasks setCustomData(String customData) {
            this.customData = customData;
            return this;
        }
        public String getCustomData() {
            return this.customData;
        }

        public CreateIntegratedTaskRequestTasks setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public CreateIntegratedTaskRequestTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
