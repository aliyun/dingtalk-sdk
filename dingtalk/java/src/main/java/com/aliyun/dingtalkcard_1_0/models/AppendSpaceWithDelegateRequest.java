// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class AppendSpaceWithDelegateRequest extends TeaModel {
    @NameInMap("coFeedOpenSpaceModel")
    public AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    @NameInMap("imGroupOpenSpaceModel")
    public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    @NameInMap("imRobotOpenSpaceModel")
    public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx_yyyy_123456</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("topOpenSpaceModel")
    public AppendSpaceWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel;

    public static AppendSpaceWithDelegateRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendSpaceWithDelegateRequest self = new AppendSpaceWithDelegateRequest();
        return TeaModel.build(map, self);
    }

    public AppendSpaceWithDelegateRequest setCoFeedOpenSpaceModel(AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public AppendSpaceWithDelegateRequest setImGroupOpenSpaceModel(AppendSpaceWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public AppendSpaceWithDelegateRequest setImRobotOpenSpaceModel(AppendSpaceWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public AppendSpaceWithDelegateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public AppendSpaceWithDelegateRequest setTopOpenSpaceModel(AppendSpaceWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public AppendSpaceWithDelegateRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public static class AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxxx卡片</p>
         */
        @NameInMap("title")
        public String title;

        public static AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel self = new AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>你收到了一个卡片消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification self = new AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>卡片的具体描述</p>
         */
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

        public static AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport self = new AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class AppendSpaceWithDelegateRequestImGroupOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static AppendSpaceWithDelegateRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImGroupOpenSpaceModel self = new AppendSpaceWithDelegateRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel setNotification(AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel setSearchSupport(AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public AppendSpaceWithDelegateRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>你收到了一个卡片消息</p>
         */
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification self = new AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>卡片的具体描述</p>
         */
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

        public static AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport self = new AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class AppendSpaceWithDelegateRequestImRobotOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static AppendSpaceWithDelegateRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestImRobotOpenSpaceModel self = new AppendSpaceWithDelegateRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel setNotification(AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel setSearchSupport(AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public AppendSpaceWithDelegateRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class AppendSpaceWithDelegateRequestTopOpenSpaceModel extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ONE_BOX</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        public static AppendSpaceWithDelegateRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            AppendSpaceWithDelegateRequestTopOpenSpaceModel self = new AppendSpaceWithDelegateRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public AppendSpaceWithDelegateRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
