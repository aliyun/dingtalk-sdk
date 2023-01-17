// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardRequest extends TeaModel {
    /**
     * <p>卡片回调时的路由 Key，用于查询注册的 callbackUrl</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <p>卡片数据</p>
     */
    @NameInMap("cardData")
    public CreateCardRequestCardData cardData;

    /**
     * <p>卡片的模版 Id</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>协作场域信息</p>
     */
    @NameInMap("coFeedOpenSpaceModel")
    public CreateCardRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    /**
     * <p>IM 群聊场域信息</p>
     */
    @NameInMap("imGroupOpenSpaceModel")
    public CreateCardRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    /**
     * <p>IM 单聊场域信息</p>
     */
    @NameInMap("imRobotOpenSpaceModel")
    public CreateCardRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    /**
     * <p>动态数据源配置</p>
     */
    @NameInMap("openDynamicDataConfig")
    public CreateCardRequestOpenDynamicDataConfig openDynamicDataConfig;

    /**
     * <p>唯一标示卡片的外部编码</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>用户的私有数据。</p>
     * <p>● key：userId</p>
     * <p>● value：用户私有数据（cardData）</p>
     */
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    /**
     * <p>吊顶场域信息</p>
     */
    @NameInMap("topOpenSpaceModel")
    public CreateCardRequestTopOpenSpaceModel topOpenSpaceModel;

    /**
     * <p>卡片创建者的 userId</p>
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
        /**
         * <p>卡片模板内容替换参数，普通文本类型</p>
         * <p>● key：参数名</p>
         * <p>● value: 参数值</p>
         */
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
        /**
         * <p>卡片标题</p>
         */
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
         * <p>【条件必填】通知内容</p>
         * <p>若不填写则使用默认文案：如你收到1条新消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        /**
         * <p>是否推送通知，默认为 false</p>
         */
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
        /**
         * <p> 【条件必填】供消息展示与搜索的字段</p>
         * <p> 【注意】最大限制200个字符，超过存储截断200</p>
         */
        @NameInMap("searchDesc")
        public String searchDesc;

        /**
         * <p>类型的icon，供搜索展示使用</p>
         */
        @NameInMap("searchIcon")
        public String searchIcon;

        /**
         * <p>卡片类型名</p>
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
        /**
         * <p>支持国际化的LastMessage</p>
         * <p>key为语言枚举值，value为lastMessage内容</p>
         * <p>目前支持的语言枚举值：</p>
         * <p>简体中文: ZH_CN</p>
         * <p>繁体中文: ZH_TW</p>
         * <p>英文： EN_US</p>
         * <p>日语: JA_JP</p>
         * <p>越南语: VI_VN</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>卡片的通知属性信息</p>
         */
        @NameInMap("notification")
        public CreateCardRequestImGroupOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public CreateCardRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认 false</p>
         */
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
        /**
         * <p>【条件必填】通知内容</p>
         * <p>若不填写则使用默认文案：如你收到1条新消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        /**
         * <p>是否推送通知，默认为 false</p>
         */
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
        /**
         * <p>【条件必填】供消息展示与搜索的字段</p>
         * <p> 【注意】最大限制200个字符，超过存储截断200</p>
         */
        @NameInMap("searchDesc")
        public String searchDesc;

        /**
         * <p>类型的icon，供搜索展示使用</p>
         */
        @NameInMap("searchIcon")
        public String searchIcon;

        /**
         * <p>卡片类型名</p>
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
        /**
         * <p>支持国际化的LastMessage</p>
         * <p>key为语言枚举值，value为lastMessage内容</p>
         * <p>目前支持的语言枚举值：</p>
         * <p>简体中文: ZH_CN</p>
         * <p>繁体中文: ZH_TW</p>
         * <p>英文： EN_US</p>
         * <p>日语: JA_JP</p>
         * <p>越南语: VI_VN</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>卡片的通知属性信息</p>
         */
        @NameInMap("notification")
        public CreateCardRequestImRobotOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public CreateCardRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认 false</p>
         */
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

    public static class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        /**
         * <p>拉取的间隔时间，只在将 pullStrategy 设置为 INTERVAL 的时候生效</p>
         */
        @NameInMap("interval")
        public Integer interval;

        /**
         * <p>【条件必填】拉取策略，可选值：</p>
         * <p>● NONE：不拉取，无动态数据</p>
         * <p>● INTERVAL：间隔拉取</p>
         * <p>● ONCE：只拉取一次</p>
         */
        @NameInMap("pullStrategy")
        public String pullStrategy;

        /**
         * <p>拉取的间隔时间的单位，只在将 pullStrategy 设置为 INTERVAL 的时候生效。 可选值：</p>
         * <p>● SECONDS</p>
         * <p>● MINUTES</p>
         * <p>● HOURS</p>
         * <p>● DAYS</p>
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
        /**
         * <p>回调数据源的常量参数</p>
         */
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        /**
         * <p>【条件必填】数据源的唯一 ID</p>
         */
        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        /**
         * <p>【条件必填】数据源拉取配置</p>
         */
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
        /**
         * <p>动态数据源配置列表</p>
         */
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
        /**
         * <p>吊顶无其他场域属性，通过增加spaeType使卡片支持吊顶场域；吊顶对应spaceType为: ONE_BOX</p>
         */
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
