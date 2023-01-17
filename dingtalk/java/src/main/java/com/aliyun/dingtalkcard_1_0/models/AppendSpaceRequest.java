// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class AppendSpaceRequest extends TeaModel {
    /**
     * <p>协作场域信息</p>
     */
    @NameInMap("coFeedOpenSpaceModel")
    public AppendSpaceRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    /**
     * <p>IM群聊场域信息</p>
     */
    @NameInMap("imGroupOpenSpaceModel")
    public AppendSpaceRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    /**
     * <p>IM群聊场域信息</p>
     */
    @NameInMap("imRobotOpenSpaceModel")
    public AppendSpaceRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    /**
     * <p>唯一标识一张卡片的外部Id</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>吊顶场域信息</p>
     */
    @NameInMap("topOpenSpaceModel")
    public AppendSpaceRequestTopOpenSpaceModel topOpenSpaceModel;

    public static AppendSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendSpaceRequest self = new AppendSpaceRequest();
        return TeaModel.build(map, self);
    }

    public AppendSpaceRequest setCoFeedOpenSpaceModel(AppendSpaceRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public AppendSpaceRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public AppendSpaceRequest setImGroupOpenSpaceModel(AppendSpaceRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public AppendSpaceRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public AppendSpaceRequest setImRobotOpenSpaceModel(AppendSpaceRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public AppendSpaceRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public AppendSpaceRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public AppendSpaceRequest setTopOpenSpaceModel(AppendSpaceRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public AppendSpaceRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public static class AppendSpaceRequestCoFeedOpenSpaceModel extends TeaModel {
        /**
         * <p>【必填】标题</p>
         */
        @NameInMap("title")
        public String title;

        public static AppendSpaceRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestCoFeedOpenSpaceModel self = new AppendSpaceRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class AppendSpaceRequestImGroupOpenSpaceModelNotification extends TeaModel {
        /**
         * <p>【条件必填】通知内容</p>
         * <br>
         * <p>【注意】若不填写则使用默认文案：如你收到1条新消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        /**
         * <p>是否关闭推送通知，默认为false</p>
         */
        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static AppendSpaceRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImGroupOpenSpaceModelNotification self = new AppendSpaceRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public AppendSpaceRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        /**
         * <p>卡片的具体描述</p>
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

        public static AppendSpaceRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImGroupOpenSpaceModelSearchSupport self = new AppendSpaceRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class AppendSpaceRequestImGroupOpenSpaceModel extends TeaModel {
        /**
         * <p>支持国际化的LastMessage</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>通知信息</p>
         */
        @NameInMap("notification")
        public AppendSpaceRequestImGroupOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认false</p>
         */
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static AppendSpaceRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImGroupOpenSpaceModel self = new AppendSpaceRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public AppendSpaceRequestImGroupOpenSpaceModel setNotification(AppendSpaceRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public AppendSpaceRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public AppendSpaceRequestImGroupOpenSpaceModel setSearchSupport(AppendSpaceRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public AppendSpaceRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class AppendSpaceRequestImRobotOpenSpaceModelNotification extends TeaModel {
        /**
         * <p>【条件必填】通知内容</p>
         * <br>
         * <p>【注意】若不填写则使用默认文案：如你收到1条新消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        /**
         * <p>是否关闭推送通知，默认为false</p>
         */
        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static AppendSpaceRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImRobotOpenSpaceModelNotification self = new AppendSpaceRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public AppendSpaceRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class AppendSpaceRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        /**
         * <p>卡片的具体描述</p>
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

        public static AppendSpaceRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImRobotOpenSpaceModelSearchSupport self = new AppendSpaceRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class AppendSpaceRequestImRobotOpenSpaceModel extends TeaModel {
        /**
         * <p>支持国际化的LastMessage</p>
         */
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        /**
         * <p>通知信息</p>
         */
        @NameInMap("notification")
        public AppendSpaceRequestImRobotOpenSpaceModelNotification notification;

        /**
         * <p>支持卡片消息可被搜索字段</p>
         */
        @NameInMap("searchSupport")
        public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        /**
         * <p>是否支持转发, 默认false</p>
         */
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static AppendSpaceRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestImRobotOpenSpaceModel self = new AppendSpaceRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public AppendSpaceRequestImRobotOpenSpaceModel setNotification(AppendSpaceRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public AppendSpaceRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public AppendSpaceRequestImRobotOpenSpaceModel setSearchSupport(AppendSpaceRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public AppendSpaceRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class AppendSpaceRequestTopOpenSpaceModel extends TeaModel {
        /**
         * <p>【必填】场域类型</p>
         * <br>
         * <p>吊顶无其他场域属性，通过设置spaeType为ONE_BOX使卡片支持吊顶场域</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        public static AppendSpaceRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceRequestTopOpenSpaceModel self = new AppendSpaceRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
