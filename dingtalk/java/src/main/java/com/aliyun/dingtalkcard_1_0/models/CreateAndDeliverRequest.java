// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverRequest extends TeaModel {
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("callbackType")
    public String callbackType;

    @NameInMap("cardData")
    public CreateAndDeliverRequestCardData cardData;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("coFeedOpenDeliverModel")
    public CreateAndDeliverRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    @NameInMap("coFeedOpenSpaceModel")
    public CreateAndDeliverRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    @NameInMap("docOpenDeliverModel")
    public CreateAndDeliverRequestDocOpenDeliverModel docOpenDeliverModel;

    @NameInMap("imGroupOpenDeliverModel")
    public CreateAndDeliverRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    @NameInMap("imGroupOpenSpaceModel")
    public CreateAndDeliverRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    @NameInMap("imRobotOpenDeliverModel")
    public CreateAndDeliverRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    @NameInMap("imRobotOpenSpaceModel")
    public CreateAndDeliverRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    @NameInMap("imSingleOpenDeliverModel")
    public CreateAndDeliverRequestImSingleOpenDeliverModel imSingleOpenDeliverModel;

    @NameInMap("imSingleOpenSpaceModel")
    public CreateAndDeliverRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    @NameInMap("openDynamicDataConfig")
    public CreateAndDeliverRequestOpenDynamicDataConfig openDynamicDataConfig;

    @NameInMap("openSpaceId")
    public String openSpaceId;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("topOpenDeliverModel")
    public CreateAndDeliverRequestTopOpenDeliverModel topOpenDeliverModel;

    @NameInMap("topOpenSpaceModel")
    public CreateAndDeliverRequestTopOpenSpaceModel topOpenSpaceModel;

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

    public CreateAndDeliverRequest setCallbackType(String callbackType) {
        this.callbackType = callbackType;
        return this;
    }
    public String getCallbackType() {
        return this.callbackType;
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

    public static class CreateAndDeliverRequestCardData extends TeaModel {
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
        @NameInMap("bizTag")
        public String bizTag;

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
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("recipients")
        public java.util.List<String> recipients;

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

        public CreateAndDeliverRequestImGroupOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
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
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverRequestImGroupOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport searchSupport;

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
        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("robotCode")
        public String robotCode;

        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverRequestImRobotOpenDeliverModel self = new CreateAndDeliverRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverRequestImRobotOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public CreateAndDeliverRequestImRobotOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
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
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverRequestImRobotOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport searchSupport;

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

    public static class CreateAndDeliverRequestImSingleOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

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

        public CreateAndDeliverRequestImSingleOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
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
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverRequestImSingleOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport searchSupport;

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
        @NameInMap("interval")
        public Integer interval;

        @NameInMap("pullStrategy")
        public String pullStrategy;

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
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

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
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        @NameInMap("platforms")
        public java.util.List<String> platforms;

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
