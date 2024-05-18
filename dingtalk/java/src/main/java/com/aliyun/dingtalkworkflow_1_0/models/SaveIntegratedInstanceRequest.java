// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceRequest extends TeaModel {
    @NameInMap("bizData")
    public String bizData;

    @NameInMap("featureConfig")
    public SaveIntegratedInstanceRequestFeatureConfig featureConfig;

    @NameInMap("formComponentValueList")
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("notifiers")
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processCode")
    public String processCode;

    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static SaveIntegratedInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceRequest self = new SaveIntegratedInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceRequest setBizData(String bizData) {
        this.bizData = bizData;
        return this;
    }
    public String getBizData() {
        return this.bizData;
    }

    public SaveIntegratedInstanceRequest setFeatureConfig(SaveIntegratedInstanceRequestFeatureConfig featureConfig) {
        this.featureConfig = featureConfig;
        return this;
    }
    public SaveIntegratedInstanceRequestFeatureConfig getFeatureConfig() {
        return this.featureConfig;
    }

    public SaveIntegratedInstanceRequest setFormComponentValueList(java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public SaveIntegratedInstanceRequest setNotifiers(java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public SaveIntegratedInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public SaveIntegratedInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SaveIntegratedInstanceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SaveIntegratedInstanceRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public static class SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback extends TeaModel {
        @NameInMap("apiKey")
        public String apiKey;

        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("version")
        public String version;

        public static SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback self = new SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback setApiKey(String apiKey) {
            this.apiKey = apiKey;
            return this;
        }
        public String getApiKey() {
            return this.apiKey;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class SaveIntegratedInstanceRequestFeatureConfigFeatures extends TeaModel {
        @NameInMap("callback")
        public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback callback;

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

        public static SaveIntegratedInstanceRequestFeatureConfigFeatures build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFeatureConfigFeatures self = new SaveIntegratedInstanceRequestFeatureConfigFeatures();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setCallback(SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback callback) {
            this.callback = callback;
            return this;
        }
        public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback getCallback() {
            return this.callback;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public SaveIntegratedInstanceRequestFeatureConfigFeatures setRunType(String runType) {
            this.runType = runType;
            return this;
        }
        public String getRunType() {
            return this.runType;
        }

    }

    public static class SaveIntegratedInstanceRequestFeatureConfig extends TeaModel {
        @NameInMap("features")
        public java.util.List<SaveIntegratedInstanceRequestFeatureConfigFeatures> features;

        public static SaveIntegratedInstanceRequestFeatureConfig build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFeatureConfig self = new SaveIntegratedInstanceRequestFeatureConfig();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFeatureConfig setFeatures(java.util.List<SaveIntegratedInstanceRequestFeatureConfigFeatures> features) {
            this.features = features;
            return this;
        }
        public java.util.List<SaveIntegratedInstanceRequestFeatureConfigFeatures> getFeatures() {
            return this.features;
        }

    }

    public static class SaveIntegratedInstanceRequestFormComponentValueList extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static SaveIntegratedInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFormComponentValueList self = new SaveIntegratedInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SaveIntegratedInstanceRequestNotifiers extends TeaModel {
        @NameInMap("position")
        public String position;

        @NameInMap("userid")
        public String userid;

        public static SaveIntegratedInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestNotifiers self = new SaveIntegratedInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestNotifiers setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public SaveIntegratedInstanceRequestNotifiers setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
