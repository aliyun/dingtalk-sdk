// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardRequest extends TeaModel {
    // 卡片回调时的路由 Key，用于查询注册的 callbackUrl
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("cardAtUserIds")
    public java.util.List<String> cardAtUserIds;

    // 卡片数据
    @NameInMap("cardData")
    public CreateCardRequestCardData cardData;

    // 卡片的模版 Id
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 协作场域信息
    @NameInMap("coFeedOpenSpaceModel")
    public CreateCardRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    // IM 群聊场域信息
    @NameInMap("imGroupOpenSpaceModel")
    public CreateCardRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    // IM 单聊场域信息
    @NameInMap("imSingleOpenSpaceModel")
    public CreateCardRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    // 动态数据源配置
    @NameInMap("openDynamicDataConfig")
    public CreateCardRequestOpenDynamicDataConfig openDynamicDataConfig;

    // 唯一标示卡片的外部编码
    @NameInMap("outTrackId")
    public String outTrackId;

    // 用户的私有数据。
    // ● key：userId
    // ● value：用户私有数据（cardData）
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    // 吊顶场域信息
    @NameInMap("topOpenSpaceModel")
    public CreateCardRequestTopOpenSpaceModel topOpenSpaceModel;

    // 卡片创建者的 userId
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    // 工作台场域信息
    @NameInMap("workBenchOpenSpaceModel")
    public CreateCardRequestWorkBenchOpenSpaceModel workBenchOpenSpaceModel;

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

    public CreateCardRequest setCardAtUserIds(java.util.List<String> cardAtUserIds) {
        this.cardAtUserIds = cardAtUserIds;
        return this;
    }
    public java.util.List<String> getCardAtUserIds() {
        return this.cardAtUserIds;
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

    public CreateCardRequest setWorkBenchOpenSpaceModel(CreateCardRequestWorkBenchOpenSpaceModel workBenchOpenSpaceModel) {
        this.workBenchOpenSpaceModel = workBenchOpenSpaceModel;
        return this;
    }
    public CreateCardRequestWorkBenchOpenSpaceModel getWorkBenchOpenSpaceModel() {
        return this.workBenchOpenSpaceModel;
    }

    public static class CreateCardRequestCardData extends TeaModel {
        // 卡片模板内容替换参数，普通文本类型
        // ● key：参数名
        // ● value: 参数值
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
        // 卡片标题
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
        // 【条件必填】通知内容
        // 若不填写则使用默认文案：如你收到1条新消息
        @NameInMap("alertContent")
        public String alertContent;

        // 是否推送通知，默认为 false
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
        //  【条件必填】供消息展示与搜索的字段
        //  【注意】最大限制200个字符，超过存储截断200
        @NameInMap("searchDesc")
        public String searchDesc;

        // 类型的icon，供搜索展示使用
        @NameInMap("searchIcon")
        public String searchIcon;

        // 卡片类型名
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
        // 支持国际化的LastMessage
        // key为语言枚举值，value为lastMessage内容
        // 目前支持的语言枚举值：
        // 简体中文: ZH_CN
        // 繁体中文: ZH_TW
        // 英文： EN_US
        // 日语: JA_JP
        // 越南语: VI_VN
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        // 卡片的通知属性信息
        @NameInMap("notification")
        public CreateCardRequestImGroupOpenSpaceModelNotification notification;

        // 支持卡片消息可被搜索字段
        @NameInMap("searchSupport")
        public CreateCardRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        // 是否支持转发, 默认 false
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

    public static class CreateCardRequestImSingleOpenSpaceModelNotification extends TeaModel {
        // 【条件必填】通知内容
        // 若不填写则使用默认文案：如你收到1条新消息
        @NameInMap("alertContent")
        public String alertContent;

        // 是否推送通知，默认为 false
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
        // 【条件必填】供消息展示与搜索的字段
        //  【注意】最大限制200个字符，超过存储截断200
        @NameInMap("searchDesc")
        public String searchDesc;

        // 类型的icon，供搜索展示使用
        @NameInMap("searchIcon")
        public String searchIcon;

        // 卡片类型名
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
        // 支持国际化的LastMessage
        // key为语言枚举值，value为lastMessage内容
        // 目前支持的语言枚举值：
        // 简体中文: ZH_CN
        // 繁体中文: ZH_TW
        // 英文： EN_US
        // 日语: JA_JP
        // 越南语: VI_VN
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        // 卡片的通知属性信息
        @NameInMap("notification")
        public CreateCardRequestImSingleOpenSpaceModelNotification notification;

        // 支持卡片消息可被搜索字段
        @NameInMap("searchSupport")
        public CreateCardRequestImSingleOpenSpaceModelSearchSupport searchSupport;

        // 是否支持转发, 默认 false
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
        // 拉取的间隔时间，只在将 pullStrategy 设置为 INTERVAL 的时候生效
        @NameInMap("interval")
        public Integer interval;

        // 【条件必填】拉取策略，可选值：
        // ● NONE：不拉取，无动态数据
        // ● INTERVAL：间隔拉取
        // ● ONCE：只拉取一次
        @NameInMap("pullStrategy")
        public String pullStrategy;

        // 拉取的间隔时间的单位，只在将 pullStrategy 设置为 INTERVAL 的时候生效。 可选值：
        // ● SECONDS
        // ● MINUTES
        // ● HOURS
        // ● DAYS
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
        // 回调数据源的常量参数
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        // 【条件必填】数据源的唯一 ID
        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        // 【条件必填】数据源拉取配置
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
        // 动态数据替换关系
        // ● key：变量名
        // ● value：数据映射的配置
        @NameInMap("dynamicDataMapping")
        public java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> dynamicDataMapping;

        // 动态数据映射方法，可选值
        // ● REPLACE_WITHOUT_MAPPING：直接返回动态数据
        // ● MAPPING_BY_KEY：根据指定的规则，将返回数据映射到卡片数据上
        // 默认值：REPLACE_WITHOUT_MAPPING
        @NameInMap("dynamicDataMappingMethod")
        public String dynamicDataMappingMethod;

        // 动态数据源配置列表
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateCardRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestOpenDynamicDataConfig self = new CreateCardRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestOpenDynamicDataConfig setDynamicDataMapping(java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> dynamicDataMapping) {
            this.dynamicDataMapping = dynamicDataMapping;
            return this;
        }
        public java.util.Map<String, OpenDynamicDataConfigDynamicDataMappingValue> getDynamicDataMapping() {
            return this.dynamicDataMapping;
        }

        public CreateCardRequestOpenDynamicDataConfig setDynamicDataMappingMethod(String dynamicDataMappingMethod) {
            this.dynamicDataMappingMethod = dynamicDataMappingMethod;
            return this;
        }
        public String getDynamicDataMappingMethod() {
            return this.dynamicDataMappingMethod;
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
        // 吊顶无其他场域属性，通过增加spaeType使卡片支持吊顶场域；吊顶对应spaceType为: ONE_BOX
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

    public static class CreateCardRequestWorkBenchOpenSpaceModel extends TeaModel {
        // 工作台无其他场域属性，通过增加spaeType使卡片支持工作台场域;工作台对应spaceType为: WORK_BENCH
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateCardRequestWorkBenchOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateCardRequestWorkBenchOpenSpaceModel self = new CreateCardRequestWorkBenchOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateCardRequestWorkBenchOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
