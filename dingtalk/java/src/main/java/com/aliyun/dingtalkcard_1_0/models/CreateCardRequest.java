// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>routekey-7931</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <strong>example:</strong>
     * <p>STREAM</p>
     */
    @NameInMap("callbackType")
    public String callbackType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardData")
    public CreateCardRequestCardData cardData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>b0aa776f-79ac-4e13-f838-749aae913bc7</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("coFeedOpenSpaceModel")
    public CreateCardRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    @NameInMap("imGroupOpenSpaceModel")
    public CreateCardRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    @NameInMap("imRobotOpenSpaceModel")
    public CreateCardRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    @NameInMap("imSingleOpenSpaceModel")
    public CreateCardRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    @NameInMap("openDynamicDataConfig")
    public CreateCardRequestOpenDynamicDataConfig openDynamicDataConfig;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>mycard-07921</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("topOpenSpaceModel")
    public CreateCardRequestTopOpenSpaceModel topOpenSpaceModel;

    /**
     * <strong>example:</strong>
     * <p>manager1234</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static CreateCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCardRequest self = new CreateCardRequest();
        return TeaModel.build(map, self);
    }

    public CreateCardRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public CreateCardRequest setCallbackType(String callbackType) {
        this.callbackType = callbackType;
        return this;
    }
    public String getCallbackType() {
        return this.callbackType;
    }

    public CreateCardRequest setCardData(CreateCardRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public CreateCardRequestCardData getCardData() {
        return this.cardData;
    }

    public CreateCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public CreateCardRequest setCoFeedOpenSpaceModel(CreateCardRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public CreateCardRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public CreateCardRequest setImGroupOpenSpaceModel(CreateCardRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public CreateCardRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public CreateCardRequest setImRobotOpenSpaceModel(CreateCardRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public CreateCardRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public CreateCardRequest setImSingleOpenSpaceModel(CreateCardRequestImSingleOpenSpaceModel imSingleOpenSpaceModel) {
        this.imSingleOpenSpaceModel = imSingleOpenSpaceModel;
        return this;
    }
    public CreateCardRequestImSingleOpenSpaceModel getImSingleOpenSpaceModel() {
        return this.imSingleOpenSpaceModel;
    }

    public CreateCardRequest setOpenDynamicDataConfig(CreateCardRequestOpenDynamicDataConfig openDynamicDataConfig) {
        this.openDynamicDataConfig = openDynamicDataConfig;
        return this;
    }
    public CreateCardRequestOpenDynamicDataConfig getOpenDynamicDataConfig() {
        return this.openDynamicDataConfig;
    }

    public CreateCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CreateCardRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public CreateCardRequest setTopOpenSpaceModel(CreateCardRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public CreateCardRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public CreateCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class CreateCardRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static CreateCardRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestCardData self = new CreateCardRequestCardData();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class CreateCardRequestCoFeedOpenSpaceModel extends TeaModel {
        @NameInMap("title")
        public String title;

        public static CreateCardRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestCoFeedOpenSpaceModel self = new CreateCardRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateCardRequestImGroupOpenSpaceModelNotification extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>你收到1条新消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImGroupOpenSpaceModelNotification self = new CreateCardRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        /**
         * <strong>example:</strong>
         * <p>@lALPDgQ9q8hFhlHNAXzNAqI</p>
         */
        @NameInMap("searchIcon")
        public String searchIcon;

        /**
         * <strong>example:</strong>
         * <p>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</p>
         */
        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImGroupOpenSpaceModelSearchSupport self = new CreateCardRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardRequestImGroupOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardRequestImGroupOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImGroupOpenSpaceModel self = new CreateCardRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardRequestImGroupOpenSpaceModel setNotification(CreateCardRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardRequestImGroupOpenSpaceModel setSearchSupport(CreateCardRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardRequestImRobotOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImRobotOpenSpaceModelNotification self = new CreateCardRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        /**
         * <strong>example:</strong>
         * <p>@lALPDgQ9q8hFhlHNAXzNAqI</p>
         */
        @NameInMap("searchIcon")
        public String searchIcon;

        /**
         * <strong>example:</strong>
         * <p>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</p>
         */
        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImRobotOpenSpaceModelSearchSupport self = new CreateCardRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardRequestImRobotOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardRequestImRobotOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImRobotOpenSpaceModel self = new CreateCardRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardRequestImRobotOpenSpaceModel setNotification(CreateCardRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardRequestImRobotOpenSpaceModel setSearchSupport(CreateCardRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardRequestImSingleOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateCardRequestImSingleOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImSingleOpenSpaceModelNotification self = new CreateCardRequestImSingleOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImSingleOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateCardRequestImSingleOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateCardRequestImSingleOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        /**
         * <strong>example:</strong>
         * <p>@lALPDgQ9q8hFhlHNAXzNAqI</p>
         */
        @NameInMap("searchIcon")
        public String searchIcon;

        /**
         * <strong>example:</strong>
         * <p>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</p>
         */
        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateCardRequestImSingleOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImSingleOpenSpaceModelSearchSupport self = new CreateCardRequestImSingleOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImSingleOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateCardRequestImSingleOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateCardRequestImSingleOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateCardRequestImSingleOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateCardRequestImSingleOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateCardRequestImSingleOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateCardRequestImSingleOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestImSingleOpenSpaceModel self = new CreateCardRequestImSingleOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestImSingleOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateCardRequestImSingleOpenSpaceModel setNotification(CreateCardRequestImSingleOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateCardRequestImSingleOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateCardRequestImSingleOpenSpaceModel setSearchSupport(CreateCardRequestImSingleOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateCardRequestImSingleOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateCardRequestImSingleOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        @NameInMap("interval")
        public Integer interval;

        /**
         * <strong>example:</strong>
         * <p>INTERVAL</p>
         */
        @NameInMap("pullStrategy")
        public String pullStrategy;

        /**
         * <strong>example:</strong>
         * <p>SECONDS</p>
         */
        @NameInMap("timeUnit")
        public String timeUnit;

        public static CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig self = new CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setPullStrategy(String pullStrategy) {
            this.pullStrategy = pullStrategy;
            return this;
        }
        public String getPullStrategy() {
            return this.pullStrategy;
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

    }

    public static class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends TeaModel {
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        /**
         * <strong>example:</strong>
         * <p>ds-01</p>
         */
        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        @NameInMap("pullConfig")
        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig;

        public static CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs self = new CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs setConstParams(java.util.Map<String, String> constParams) {
            this.constParams = constParams;
            return this;
        }
        public java.util.Map<String, String> getConstParams() {
            return this.constParams;
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs setDynamicDataSourceId(String dynamicDataSourceId) {
            this.dynamicDataSourceId = dynamicDataSourceId;
            return this;
        }
        public String getDynamicDataSourceId() {
            return this.dynamicDataSourceId;
        }

        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs setPullConfig(CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig) {
            this.pullConfig = pullConfig;
            return this;
        }
        public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig getPullConfig() {
            return this.pullConfig;
        }

    }

    public static class CreateCardRequestOpenDynamicDataConfig extends TeaModel {
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateCardRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestOpenDynamicDataConfig self = new CreateCardRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestOpenDynamicDataConfig setDynamicDataSourceConfigs(java.util.List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs) {
            this.dynamicDataSourceConfigs = dynamicDataSourceConfigs;
            return this;
        }
        public java.util.List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> getDynamicDataSourceConfigs() {
            return this.dynamicDataSourceConfigs;
        }

    }

    public static class CreateCardRequestTopOpenSpaceModel extends TeaModel {
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateCardRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestTopOpenSpaceModel self = new CreateCardRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
