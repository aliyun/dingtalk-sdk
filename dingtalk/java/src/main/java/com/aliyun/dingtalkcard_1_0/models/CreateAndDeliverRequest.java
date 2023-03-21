// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverRequest extends TeaModel {
    /**
     * <p>卡片回调时的路由 key</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <p>卡片数据</p>
     */
    @NameInMap("cardData")
    public CreateAndDeliverRequestCardData cardData;

    /**
     * <p>卡片内容模板ID</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>协作投放参数</p>
     */
    @NameInMap("coFeedOpenDeliverModel")
    public CreateAndDeliverRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    /**
     * <p>协作场域信息</p>
     */
    @NameInMap("coFeedOpenSpaceModel")
    public CreateAndDeliverRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    /**
     * <p>文档投放参数</p>
     */
    @NameInMap("docOpenDeliverModel")
    public CreateAndDeliverRequestDocOpenDeliverModel docOpenDeliverModel;

    /**
     * <p>群聊投放参数</p>
     */
    @NameInMap("imGroupOpenDeliverModel")
    public CreateAndDeliverRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    /**
     * <p>IM群聊场域信息</p>
     */
    @NameInMap("imGroupOpenSpaceModel")
    public CreateAndDeliverRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    /**
     * <p>单聊场域投放参数</p>
     */
    @NameInMap("imRobotOpenDeliverModel")
    public CreateAndDeliverRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    /**
     * <p>IM单聊场域信息</p>
     */
    @NameInMap("imRobotOpenSpaceModel")
    public CreateAndDeliverRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    /**
     * <p>动态数据源配置</p>
     */
    @NameInMap("openDynamicDataConfig")
    public CreateAndDeliverRequestOpenDynamicDataConfig openDynamicDataConfig;

    /**
     * <p>dt.card//spaceType.spaceId;spaceType.spaceId</p>
     */
    @NameInMap("openSpaceId")
    public String openSpaceId;

    /**
     * <p>外部业务标识符</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    /**
     * <p>吊顶投放参数</p>
     */
    @NameInMap("topOpenDeliverModel")
    public CreateAndDeliverRequestTopOpenDeliverModel topOpenDeliverModel;

    /**
     * <p>吊顶场域信息</p>
     */
    @NameInMap("topOpenSpaceModel")
    public CreateAndDeliverRequestTopOpenSpaceModel topOpenSpaceModel;

    /**
     * <p>卡片创建者 id</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static CreateAndDeliverRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverRequest self = new CreateAndDeliverRequest();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public CreateAndDeliverRequest setCardData(CreateAndDeliverRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public CreateAndDeliverRequestCardData getCardData() {
        return this.cardData;
    }

    public CreateAndDeliverRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public CreateAndDeliverRequest setCoFeedOpenDeliverModel(CreateAndDeliverRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel) {
        this.coFeedOpenDeliverModel = coFeedOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestCoFeedOpenDeliverModel getCoFeedOpenDeliverModel() {
        return this.coFeedOpenDeliverModel;
    }

    public CreateAndDeliverRequest setCoFeedOpenSpaceModel(CreateAndDeliverRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public CreateAndDeliverRequest setDocOpenDeliverModel(CreateAndDeliverRequestDocOpenDeliverModel docOpenDeliverModel) {
        this.docOpenDeliverModel = docOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestDocOpenDeliverModel getDocOpenDeliverModel() {
        return this.docOpenDeliverModel;
    }

    public CreateAndDeliverRequest setImGroupOpenDeliverModel(CreateAndDeliverRequestImGroupOpenDeliverModel imGroupOpenDeliverModel) {
        this.imGroupOpenDeliverModel = imGroupOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestImGroupOpenDeliverModel getImGroupOpenDeliverModel() {
        return this.imGroupOpenDeliverModel;
    }

    public CreateAndDeliverRequest setImGroupOpenSpaceModel(CreateAndDeliverRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public CreateAndDeliverRequest setImRobotOpenDeliverModel(CreateAndDeliverRequestImRobotOpenDeliverModel imRobotOpenDeliverModel) {
        this.imRobotOpenDeliverModel = imRobotOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestImRobotOpenDeliverModel getImRobotOpenDeliverModel() {
        return this.imRobotOpenDeliverModel;
    }

    public CreateAndDeliverRequest setImRobotOpenSpaceModel(CreateAndDeliverRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public CreateAndDeliverRequest setOpenDynamicDataConfig(CreateAndDeliverRequestOpenDynamicDataConfig openDynamicDataConfig) {
        this.openDynamicDataConfig = openDynamicDataConfig;
        return this;
    }
    public CreateAndDeliverRequestOpenDynamicDataConfig getOpenDynamicDataConfig() {
        return this.openDynamicDataConfig;
    }

    public CreateAndDeliverRequest setOpenSpaceId(String openSpaceId) {
        this.openSpaceId = openSpaceId;
        return this;
    }
    public String getOpenSpaceId() {
        return this.openSpaceId;
    }

    public CreateAndDeliverRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CreateAndDeliverRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public CreateAndDeliverRequest setTopOpenDeliverModel(CreateAndDeliverRequestTopOpenDeliverModel topOpenDeliverModel) {
        this.topOpenDeliverModel = topOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestTopOpenDeliverModel getTopOpenDeliverModel() {
        return this.topOpenDeliverModel;
    }

    public CreateAndDeliverRequest setTopOpenSpaceModel(CreateAndDeliverRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public CreateAndDeliverRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateAndDeliverRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class CreateAndDeliverRequestCardData extends TeaModel {
        /**
         * <p>卡片模板-文本内容参数</p>
         */
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static CreateAndDeliverRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestCardData self = new CreateAndDeliverRequestCardData();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class CreateAndDeliverRequestCoFeedOpenDeliverModel extends TeaModel {
        /**
         * <p>【必填】业务标识</p>
         */
        @NameInMap("bizTag")
        public String bizTag;

        /**
         * <p>【必填】协作场域下的排序时间</p>
         */
        @NameInMap("gmtTimeLine")
        public Long gmtTimeLine;

        public static CreateAndDeliverRequestCoFeedOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestCoFeedOpenDeliverModel self = new CreateAndDeliverRequestCoFeedOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestCoFeedOpenDeliverModel setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public CreateAndDeliverRequestCoFeedOpenDeliverModel setGmtTimeLine(Long gmtTimeLine) {
            this.gmtTimeLine = gmtTimeLine;
            return this;
        }
        public Long getGmtTimeLine() {
            return this.gmtTimeLine;
        }

    }

    public static class CreateAndDeliverRequestCoFeedOpenSpaceModel extends TeaModel {
        @NameInMap("coolAppCode")
        public String coolAppCode;

        /**
         * <p>【必填】标题</p>
         */
        @NameInMap("title")
        public String title;

        public static CreateAndDeliverRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestCoFeedOpenSpaceModel self = new CreateAndDeliverRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestCoFeedOpenSpaceModel setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public CreateAndDeliverRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateAndDeliverRequestDocOpenDeliverModel extends TeaModel {
        /**
         * <p>【必填】员工id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateAndDeliverRequestDocOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestDocOpenDeliverModel self = new CreateAndDeliverRequestDocOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestDocOpenDeliverModel setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateAndDeliverRequestImGroupOpenDeliverModel extends TeaModel {
        /**
         * <p>消息@人，</p>
         */
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        /**
         * <p>指定接收者</p>
         */
        @NameInMap("recipients")
        public java.util.List<String> recipients;

        /**
         * <p>机器人的code</p>
         */
        @NameInMap("robotCode")
        public String robotCode;

        public static CreateAndDeliverRequestImGroupOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImGroupOpenDeliverModel self = new CreateAndDeliverRequestImGroupOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImGroupOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public CreateAndDeliverRequestImGroupOpenDeliverModel setRecipients(java.util.List<String> recipients) {
            this.recipients = recipients;
            return this;
        }
        public java.util.List<String> getRecipients() {
            return this.recipients;
        }

        public CreateAndDeliverRequestImGroupOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

    public static class CreateAndDeliverRequestImGroupOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImGroupOpenSpaceModelNotification self = new CreateAndDeliverRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport self = new CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverRequestImGroupOpenSpaceModel extends TeaModel {
        /**
         * <p>支持国际化的LastMessage</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>通知信息</p>
         */
        @NameInMap("notification")
        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认false</p>
         */
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImGroupOpenSpaceModel self = new CreateAndDeliverRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModel setNotification(CreateAndDeliverRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModel setSearchSupport(CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverRequestImRobotOpenDeliverModel extends TeaModel {
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImRobotOpenDeliverModel self = new CreateAndDeliverRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImRobotOpenDeliverModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

    public static class CreateAndDeliverRequestImRobotOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImRobotOpenSpaceModelNotification self = new CreateAndDeliverRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport self = new CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverRequestImRobotOpenSpaceModel extends TeaModel {
        /**
         * <p>支持国际化的LastMessage</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>通知信息</p>
         */
        @NameInMap("notification")
        public CreateAndDeliverRequestImRobotOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认false</p>
         */
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImRobotOpenSpaceModel self = new CreateAndDeliverRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModel setNotification(CreateAndDeliverRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModel setSearchSupport(CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        /**
         * <p>间隔</p>
         */
        @NameInMap("interval")
        public Integer interval;

        /**
         * <p>拉取策略 (NONE: 不拉取,无动态数据, INTERVAL: 间隔拉取, ONCE: 只拉取一次)</p>
         */
        @NameInMap("pullStrategy")
        public String pullStrategy;

        /**
         * <p>间隔的时间单位 (SECONDS, MINUTES, HOURS, DAYS)</p>
         */
        @NameInMap("timeUnit")
        public String timeUnit;

        public static CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig self = new CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setPullStrategy(String pullStrategy) {
            this.pullStrategy = pullStrategy;
            return this;
        }
        public String getPullStrategy() {
            return this.pullStrategy;
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

    }

    public static class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends TeaModel {
        /**
         * <p>回调数据源的常量参数</p>
         */
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        /**
         * <p>数据源配置id</p>
         */
        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        /**
         * <p>数据源拉取配置</p>
         */
        @NameInMap("pullConfig")
        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig;

        public static CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs self = new CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs setConstParams(java.util.Map<String, String> constParams) {
            this.constParams = constParams;
            return this;
        }
        public java.util.Map<String, String> getConstParams() {
            return this.constParams;
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs setDynamicDataSourceId(String dynamicDataSourceId) {
            this.dynamicDataSourceId = dynamicDataSourceId;
            return this;
        }
        public String getDynamicDataSourceId() {
            return this.dynamicDataSourceId;
        }

        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs setPullConfig(CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig) {
            this.pullConfig = pullConfig;
            return this;
        }
        public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig getPullConfig() {
            return this.pullConfig;
        }

    }

    public static class CreateAndDeliverRequestOpenDynamicDataConfig extends TeaModel {
        /**
         * <p>动态数据源配置列表</p>
         */
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateAndDeliverRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestOpenDynamicDataConfig self = new CreateAndDeliverRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestOpenDynamicDataConfig setDynamicDataSourceConfigs(java.util.List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs) {
            this.dynamicDataSourceConfigs = dynamicDataSourceConfigs;
            return this;
        }
        public java.util.List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> getDynamicDataSourceConfigs() {
            return this.dynamicDataSourceConfigs;
        }

    }

    public static class CreateAndDeliverRequestTopOpenDeliverModel extends TeaModel {
        /**
         * <p>【必填】过期时间戳</p>
         */
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        /**
         * <p>可以查看该吊顶卡片的设备</p>
         */
        @NameInMap("platforms")
        public java.util.List<String> platforms;

        /**
         * <p>可以查看该吊顶卡片的staffId</p>
         */
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static CreateAndDeliverRequestTopOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestTopOpenDeliverModel self = new CreateAndDeliverRequestTopOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestTopOpenDeliverModel setExpiredTimeMillis(Long expiredTimeMillis) {
            this.expiredTimeMillis = expiredTimeMillis;
            return this;
        }
        public Long getExpiredTimeMillis() {
            return this.expiredTimeMillis;
        }

        public CreateAndDeliverRequestTopOpenDeliverModel setPlatforms(java.util.List<String> platforms) {
            this.platforms = platforms;
            return this;
        }
        public java.util.List<String> getPlatforms() {
            return this.platforms;
        }

        public CreateAndDeliverRequestTopOpenDeliverModel setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

    public static class CreateAndDeliverRequestTopOpenSpaceModel extends TeaModel {
        /**
         * <p>【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestTopOpenSpaceModel self = new CreateAndDeliverRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
