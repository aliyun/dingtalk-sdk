// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>act_xxxx</p>
     */
    @NameInMap("activityId")
    public String activityId;

    @NameInMap("featureConfig")
    public PremiumSaveIntegratedTaskRequestFeatureConfig featureConfig;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>tPr_FB_mT_xxxxxxxxx2hQ05201655306463</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tasks")
    public java.util.List<PremiumSaveIntegratedTaskRequestTasks> tasks;

    public static PremiumSaveIntegratedTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedTaskRequest self = new PremiumSaveIntegratedTaskRequest();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedTaskRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public PremiumSaveIntegratedTaskRequest setFeatureConfig(PremiumSaveIntegratedTaskRequestFeatureConfig featureConfig) {
        this.featureConfig = featureConfig;
        return this;
    }
    public PremiumSaveIntegratedTaskRequestFeatureConfig getFeatureConfig() {
        return this.featureConfig;
    }

    public PremiumSaveIntegratedTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumSaveIntegratedTaskRequest setTasks(java.util.List<PremiumSaveIntegratedTaskRequestTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<PremiumSaveIntegratedTaskRequestTasks> getTasks() {
        return this.tasks;
    }

    public static class PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback extends TeaModel {
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

        public static PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback self = new PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback setApiKey(String apiKey) {
            this.apiKey = apiKey;
            return this;
        }
        public String getApiKey() {
            return this.apiKey;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class PremiumSaveIntegratedTaskRequestFeatureConfigFeatures extends TeaModel {
        @NameInMap("callback")
        public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback callback;

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

        public static PremiumSaveIntegratedTaskRequestFeatureConfigFeatures build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedTaskRequestFeatureConfigFeatures self = new PremiumSaveIntegratedTaskRequestFeatureConfigFeatures();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setCallback(PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback callback) {
            this.callback = callback;
            return this;
        }
        public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback getCallback() {
            return this.callback;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfigFeatures setRunType(String runType) {
            this.runType = runType;
            return this;
        }
        public String getRunType() {
            return this.runType;
        }

    }

    public static class PremiumSaveIntegratedTaskRequestFeatureConfig extends TeaModel {
        @NameInMap("features")
        public java.util.List<PremiumSaveIntegratedTaskRequestFeatureConfigFeatures> features;

        public static PremiumSaveIntegratedTaskRequestFeatureConfig build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedTaskRequestFeatureConfig self = new PremiumSaveIntegratedTaskRequestFeatureConfig();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedTaskRequestFeatureConfig setFeatures(java.util.List<PremiumSaveIntegratedTaskRequestFeatureConfigFeatures> features) {
            this.features = features;
            return this;
        }
        public java.util.List<PremiumSaveIntegratedTaskRequestFeatureConfigFeatures> getFeatures() {
            return this.features;
        }

    }

    public static class PremiumSaveIntegratedTaskRequestTasks extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;id&quot;:&quot;12345&quot;}</p>
         */
        @NameInMap("customData")
        public String customData;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>manager001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PremiumSaveIntegratedTaskRequestTasks build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedTaskRequestTasks self = new PremiumSaveIntegratedTaskRequestTasks();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedTaskRequestTasks setCustomData(String customData) {
            this.customData = customData;
            return this;
        }
        public String getCustomData() {
            return this.customData;
        }

        public PremiumSaveIntegratedTaskRequestTasks setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public PremiumSaveIntegratedTaskRequestTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
