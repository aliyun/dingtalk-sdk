// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardWithDelegateRequest extends TeaModel {
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("callbackType")
    public String callbackType;

    @NameInMap("cardData")
    public CreateCardWithDelegateRequestCardData cardData;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("coFeedOpenSpaceModel")
    public CreateCardWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    @NameInMap("imGroupOpenSpaceModel")
    public CreateCardWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    @NameInMap("imRobotOpenSpaceModel")
    public CreateCardWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    @NameInMap("imSingleOpenSpaceModel")
    public CreateCardWithDelegateRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    @NameInMap("openDynamicDataConfig")
    public CreateCardWithDelegateRequestOpenDynamicDataConfig openDynamicDataConfig;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("topOpenSpaceModel")
    public CreateCardWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static CreateCardWithDelegateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCardWithDelegateRequest self = new CreateCardWithDelegateRequest();
        return TeaModel.build(map, self);
    }

    public CreateCardWithDelegateRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public CreateCardWithDelegateRequest setCallbackType(String callbackType) {
        this.callbackType = callbackType;
        return this;
    }
    public String getCallbackType() {
        return this.callbackType;
    }

    public CreateCardWithDelegateRequest setCardData(CreateCardWithDelegateRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public CreateCardWithDelegateRequestCardData getCardData() {
        return this.cardData;
    }

    public CreateCardWithDelegateRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public CreateCardWithDelegateRequest setCoFeedOpenSpaceModel(CreateCardWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public CreateCardWithDelegateRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public CreateCardWithDelegateRequest setImGroupOpenSpaceModel(CreateCardWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public CreateCardWithDelegateRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public CreateCardWithDelegateRequest setImRobotOpenSpaceModel(CreateCardWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public CreateCardWithDelegateRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public CreateCardWithDelegateRequest setImSingleOpenSpaceModel(CreateCardWithDelegateRequestImSingleOpenSpaceModel imSingleOpenSpaceModel) {
        this.imSingleOpenSpaceModel = imSingleOpenSpaceModel;
        return this;
    }
    public CreateCardWithDelegateRequestImSingleOpenSpaceModel getImSingleOpenSpaceModel() {
        return this.imSingleOpenSpaceModel;
    }

    public CreateCardWithDelegateRequest setOpenDynamicDataConfig(CreateCardWithDelegateRequestOpenDynamicDataConfig openDynamicDataConfig) {
        this.openDynamicDataConfig = openDynamicDataConfig;
        return this;
    }
    public CreateCardWithDelegateRequestOpenDynamicDataConfig getOpenDynamicDataConfig() {
        return this.openDynamicDataConfig;
    }

    public CreateCardWithDelegateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CreateCardWithDelegateRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public CreateCardWithDelegateRequest setTopOpenSpaceModel(CreateCardWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public CreateCardWithDelegateRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public CreateCardWithDelegateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateCardWithDelegateRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class CreateCardWithDelegateRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static CreateCardWithDelegateRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestCardData self = new CreateCardWithDelegateRequestCardData();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class CreateCardWithDelegateRequestCoFeedOpenSpaceModel extends TeaModel {
        @NameInMap("title")
        public String title;

        public static CreateCardWithDelegateRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestCoFeedOpenSpaceModel self = new CreateCardWithDelegateRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification self = new CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport self = new CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardWithDelegateRequestImGroupOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardWithDelegateRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImGroupOpenSpaceModel self = new CreateCardWithDelegateRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModel setNotification(CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModel setSearchSupport(CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardWithDelegateRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification self = new CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport self = new CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardWithDelegateRequestImRobotOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardWithDelegateRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImRobotOpenSpaceModel self = new CreateCardWithDelegateRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModel setNotification(CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModel setSearchSupport(CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardWithDelegateRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification self = new CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport self = new CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardWithDelegateRequestImSingleOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardWithDelegateRequestImSingleOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestImSingleOpenSpaceModel self = new CreateCardWithDelegateRequestImSingleOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModel setNotification(CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModel setSearchSupport(CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardWithDelegateRequestImSingleOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        @NameInMap("interval")
        public Integer interval;

        @NameInMap("pullStrategy")
        public String pullStrategy;

        @NameInMap("timeUnit")
        public String timeUnit;

        public static CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig self = new CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setPullStrategy(String pullStrategy) {
            this.pullStrategy = pullStrategy;
            return this;
        }
        public String getPullStrategy() {
            return this.pullStrategy;
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

    }

    public static class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends TeaModel {
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        @NameInMap("pullConfig")
        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig;

        public static CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs self = new CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setConstParams(java.util.Map<String, String> constParams) {
            this.constParams = constParams;
            return this;
        }
        public java.util.Map<String, String> getConstParams() {
            return this.constParams;
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setDynamicDataSourceId(String dynamicDataSourceId) {
            this.dynamicDataSourceId = dynamicDataSourceId;
            return this;
        }
        public String getDynamicDataSourceId() {
            return this.dynamicDataSourceId;
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setPullConfig(CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig) {
            this.pullConfig = pullConfig;
            return this;
        }
        public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig getPullConfig() {
            return this.pullConfig;
        }

    }

    public static class CreateCardWithDelegateRequestOpenDynamicDataConfig extends TeaModel {
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateCardWithDelegateRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestOpenDynamicDataConfig self = new CreateCardWithDelegateRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestOpenDynamicDataConfig setDynamicDataSourceConfigs(java.util.List<CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs) {
            this.dynamicDataSourceConfigs = dynamicDataSourceConfigs;
            return this;
        }
        public java.util.List<CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> getDynamicDataSourceConfigs() {
            return this.dynamicDataSourceConfigs;
        }

    }

    public static class CreateCardWithDelegateRequestTopOpenSpaceModel extends TeaModel {
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateCardWithDelegateRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardWithDelegateRequestTopOpenSpaceModel self = new CreateCardWithDelegateRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardWithDelegateRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
