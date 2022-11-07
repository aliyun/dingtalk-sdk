// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverRequest extends TeaModel {
    // 卡片回调时的路由 key
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("cardAtUserIds")
    public java.util.List<String> cardAtUserIds;

    // 卡片数据
    @NameInMap("cardData")
    public CreateAndDeliverRequestCardData cardData;

    // 卡片内容模板ID
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 协作投放参数
    @NameInMap("coFeedOpenDeliverModel")
    public CreateAndDeliverRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    // 协作场域信息
    @NameInMap("coFeedOpenSpaceModel")
    public CreateAndDeliverRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    // 群聊投放参数
    @NameInMap("imGroupOpenDeliverModel")
    public CreateAndDeliverRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    // IM群聊场域信息
    @NameInMap("imGroupOpenSpaceModel")
    public CreateAndDeliverRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    // 单聊场域投放参数
    @NameInMap("imSingleOpenDeliverModel")
    public CreateAndDeliverRequestImSingleOpenDeliverModel imSingleOpenDeliverModel;

    // IM单聊场域信息
    @NameInMap("imSingleOpenSpaceModel")
    public CreateAndDeliverRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    // 动态数据源配置
    @NameInMap("openDynamicDataConfig")
    public CreateAndDeliverRequestOpenDynamicDataConfig openDynamicDataConfig;

    // dt.card//spaceType.spaceId;spaceType.spaceId
    @NameInMap("openSpaceId")
    public String openSpaceId;

    // 外部业务标识符
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    // 吊顶投放参数
    @NameInMap("topOpenDeliverModel")
    public CreateAndDeliverRequestTopOpenDeliverModel topOpenDeliverModel;

    // 吊顶场域信息
    @NameInMap("topOpenSpaceModel")
    public CreateAndDeliverRequestTopOpenSpaceModel topOpenSpaceModel;

    // 卡片创建者 id
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    // 工作台投放参数
    @NameInMap("workBenchOpenDeliverModel")
    public CreateAndDeliverRequestWorkBenchOpenDeliverModel workBenchOpenDeliverModel;

    // 工作台场域信息
    @NameInMap("workBenchOpenSpaceModel")
    public CreateAndDeliverRequestWorkBenchOpenSpaceModel workBenchOpenSpaceModel;

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

    public CreateAndDeliverRequest setCardAtUserIds(java.util.List<String> cardAtUserIds) {
        this.cardAtUserIds = cardAtUserIds;
        return this;
    }
    public java.util.List<String> getCardAtUserIds() {
        return this.cardAtUserIds;
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

    public CreateAndDeliverRequest setImSingleOpenDeliverModel(CreateAndDeliverRequestImSingleOpenDeliverModel imSingleOpenDeliverModel) {
        this.imSingleOpenDeliverModel = imSingleOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestImSingleOpenDeliverModel getImSingleOpenDeliverModel() {
        return this.imSingleOpenDeliverModel;
    }

    public CreateAndDeliverRequest setImSingleOpenSpaceModel(CreateAndDeliverRequestImSingleOpenSpaceModel imSingleOpenSpaceModel) {
        this.imSingleOpenSpaceModel = imSingleOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestImSingleOpenSpaceModel getImSingleOpenSpaceModel() {
        return this.imSingleOpenSpaceModel;
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

    public CreateAndDeliverRequest setWorkBenchOpenDeliverModel(CreateAndDeliverRequestWorkBenchOpenDeliverModel workBenchOpenDeliverModel) {
        this.workBenchOpenDeliverModel = workBenchOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverRequestWorkBenchOpenDeliverModel getWorkBenchOpenDeliverModel() {
        return this.workBenchOpenDeliverModel;
    }

    public CreateAndDeliverRequest setWorkBenchOpenSpaceModel(CreateAndDeliverRequestWorkBenchOpenSpaceModel workBenchOpenSpaceModel) {
        this.workBenchOpenSpaceModel = workBenchOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverRequestWorkBenchOpenSpaceModel getWorkBenchOpenSpaceModel() {
        return this.workBenchOpenSpaceModel;
    }

    public static class CreateAndDeliverRequestCardData extends TeaModel {
        // 卡片模板-文本内容参数
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
        // 【必填】业务标识
        @NameInMap("bizTag")
        public String bizTag;

        // 【必填】协作场域下的排序时间
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
        // 【必填】标题
        @NameInMap("title")
        public String title;

        public static CreateAndDeliverRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestCoFeedOpenSpaceModel self = new CreateAndDeliverRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateAndDeliverRequestImGroupOpenDeliverModel extends TeaModel {
        // 消息@人，
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        // 指定接收者
        @NameInMap("recipients")
        public java.util.List<String> recipients;

        // 机器人的code
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
        // 支持国际化的LastMessage
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        // 通知信息
        @NameInMap("notification")
        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification notification;

        // 支持卡片消息可被搜索字段
        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        // 是否支持转发, 默认false
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

    public static class CreateAndDeliverRequestImSingleOpenDeliverModel extends TeaModel {
        // 消息@人，
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        public static CreateAndDeliverRequestImSingleOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImSingleOpenDeliverModel self = new CreateAndDeliverRequestImSingleOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImSingleOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

    }

    public static class CreateAndDeliverRequestImSingleOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverRequestImSingleOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImSingleOpenSpaceModelNotification self = new CreateAndDeliverRequestImSingleOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport self = new CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverRequestImSingleOpenSpaceModel extends TeaModel {
        // 支持国际化的LastMessage
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        // 通知信息
        @NameInMap("notification")
        public CreateAndDeliverRequestImSingleOpenSpaceModelNotification notification;

        // 支持卡片消息可被搜索字段
        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport searchSupport;

        // 是否支持转发, 默认false
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverRequestImSingleOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImSingleOpenSpaceModel self = new CreateAndDeliverRequestImSingleOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModel setNotification(CreateAndDeliverRequestImSingleOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverRequestImSingleOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModel setSearchSupport(CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverRequestImSingleOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        // 间隔
        @NameInMap("interval")
        public Integer interval;

        // 拉取策略 (NONE: 不拉取,无动态数据, INTERVAL: 间隔拉取, ONCE: 只拉取一次)
        @NameInMap("pullStrategy")
        public String pullStrategy;

        // 间隔的时间单位 (SECONDS, MINUTES, HOURS, DAYS)
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
        // 回调数据源的常量参数
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        // 数据源配置id
        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        // 数据源拉取配置
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
        // 动态数据替换关系,key是变量名, value是数据源的jsonPath相关配置
        @NameInMap("dynamicDataMapping")
        public java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> dynamicDataMapping;

        // 动态数据映射类型 (REPLACE_WITHOUT_MAPPING: 直接将动态数据返回，无需根据 key mapping, MAPPING_BY_KEY: 根据创建时的 key 进行 mapping)
        @NameInMap("dynamicDataMappingMethod")
        public String dynamicDataMappingMethod;

        // 动态数据源配置列表
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateAndDeliverRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestOpenDynamicDataConfig self = new CreateAndDeliverRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestOpenDynamicDataConfig setDynamicDataMapping(java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> dynamicDataMapping) {
            this.dynamicDataMapping = dynamicDataMapping;
            return this;
        }
        public java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> getDynamicDataMapping() {
            return this.dynamicDataMapping;
        }

        public CreateAndDeliverRequestOpenDynamicDataConfig setDynamicDataMappingMethod(String dynamicDataMappingMethod) {
            this.dynamicDataMappingMethod = dynamicDataMappingMethod;
            return this;
        }
        public String getDynamicDataMappingMethod() {
            return this.dynamicDataMappingMethod;
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
        // 【必填】过期时间戳
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        // 可以查看该吊顶卡片的设备
        @NameInMap("platforms")
        public java.util.List<String> platforms;

        // 可以查看该吊顶卡片的staffId
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
        // 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
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

    public static class CreateAndDeliverRequestWorkBenchOpenDeliverModel extends TeaModel {
        // 【必填】组件icon对应组件左上角的图标
        @NameInMap("icon")
        public String icon;

        // 【必填】卡片名称
        @NameInMap("name")
        public String name;

        // 【必填】卡片组件名
        @NameInMap("pluginComponentName")
        public String pluginComponentName;

        // 【必填】卡片预览图
        @NameInMap("previewUrl")
        public String previewUrl;

        // 【必填】保持和微应用名称相同
        @NameInMap("projectName")
        public String projectName;

        // 【必填】操作者Id
        @NameInMap("userId")
        public String userId;

        public static CreateAndDeliverRequestWorkBenchOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestWorkBenchOpenDeliverModel self = new CreateAndDeliverRequestWorkBenchOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setPluginComponentName(String pluginComponentName) {
            this.pluginComponentName = pluginComponentName;
            return this;
        }
        public String getPluginComponentName() {
            return this.pluginComponentName;
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public CreateAndDeliverRequestWorkBenchOpenDeliverModel setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateAndDeliverRequestWorkBenchOpenSpaceModel extends TeaModel {
        // 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverRequestWorkBenchOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestWorkBenchOpenSpaceModel self = new CreateAndDeliverRequestWorkBenchOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestWorkBenchOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
