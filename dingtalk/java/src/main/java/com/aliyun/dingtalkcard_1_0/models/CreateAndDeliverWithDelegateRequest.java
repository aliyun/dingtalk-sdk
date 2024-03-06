// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverWithDelegateRequest extends TeaModel {
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("callbackType")
    public String callbackType;

    @NameInMap("cardData")
    public CreateAndDeliverWithDelegateRequestCardData cardData;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("coFeedOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    @NameInMap("coFeedOpenSpaceModel")
    public CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel;

    @NameInMap("docOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestDocOpenDeliverModel docOpenDeliverModel;

    @NameInMap("imGroupOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    @NameInMap("imGroupOpenSpaceModel")
    public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel;

    @NameInMap("imRobotOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    @NameInMap("imRobotOpenSpaceModel")
    public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel;

    @NameInMap("imSingleOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel imSingleOpenDeliverModel;

    @NameInMap("imSingleOpenSpaceModel")
    public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel imSingleOpenSpaceModel;

    @NameInMap("openDynamicDataConfig")
    public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig openDynamicDataConfig;

    @NameInMap("openSpaceId")
    public String openSpaceId;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("topOpenDeliverModel")
    public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel topOpenDeliverModel;

    @NameInMap("topOpenSpaceModel")
    public CreateAndDeliverWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static CreateAndDeliverWithDelegateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverWithDelegateRequest self = new CreateAndDeliverWithDelegateRequest();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverWithDelegateRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public CreateAndDeliverWithDelegateRequest setCallbackType(String callbackType) {
        this.callbackType = callbackType;
        return this;
    }
    public String getCallbackType() {
        return this.callbackType;
    }

    public CreateAndDeliverWithDelegateRequest setCardData(CreateAndDeliverWithDelegateRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestCardData getCardData() {
        return this.cardData;
    }

    public CreateAndDeliverWithDelegateRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public CreateAndDeliverWithDelegateRequest setCoFeedOpenDeliverModel(CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel) {
        this.coFeedOpenDeliverModel = coFeedOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel getCoFeedOpenDeliverModel() {
        return this.coFeedOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setCoFeedOpenSpaceModel(CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel coFeedOpenSpaceModel) {
        this.coFeedOpenSpaceModel = coFeedOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel getCoFeedOpenSpaceModel() {
        return this.coFeedOpenSpaceModel;
    }

    public CreateAndDeliverWithDelegateRequest setDocOpenDeliverModel(CreateAndDeliverWithDelegateRequestDocOpenDeliverModel docOpenDeliverModel) {
        this.docOpenDeliverModel = docOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestDocOpenDeliverModel getDocOpenDeliverModel() {
        return this.docOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setImGroupOpenDeliverModel(CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel imGroupOpenDeliverModel) {
        this.imGroupOpenDeliverModel = imGroupOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel getImGroupOpenDeliverModel() {
        return this.imGroupOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setImGroupOpenSpaceModel(CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel imGroupOpenSpaceModel) {
        this.imGroupOpenSpaceModel = imGroupOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel getImGroupOpenSpaceModel() {
        return this.imGroupOpenSpaceModel;
    }

    public CreateAndDeliverWithDelegateRequest setImRobotOpenDeliverModel(CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel imRobotOpenDeliverModel) {
        this.imRobotOpenDeliverModel = imRobotOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel getImRobotOpenDeliverModel() {
        return this.imRobotOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setImRobotOpenSpaceModel(CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel imRobotOpenSpaceModel) {
        this.imRobotOpenSpaceModel = imRobotOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel getImRobotOpenSpaceModel() {
        return this.imRobotOpenSpaceModel;
    }

    public CreateAndDeliverWithDelegateRequest setImSingleOpenDeliverModel(CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel imSingleOpenDeliverModel) {
        this.imSingleOpenDeliverModel = imSingleOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel getImSingleOpenDeliverModel() {
        return this.imSingleOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setImSingleOpenSpaceModel(CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel imSingleOpenSpaceModel) {
        this.imSingleOpenSpaceModel = imSingleOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel getImSingleOpenSpaceModel() {
        return this.imSingleOpenSpaceModel;
    }

    public CreateAndDeliverWithDelegateRequest setOpenDynamicDataConfig(CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig openDynamicDataConfig) {
        this.openDynamicDataConfig = openDynamicDataConfig;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig getOpenDynamicDataConfig() {
        return this.openDynamicDataConfig;
    }

    public CreateAndDeliverWithDelegateRequest setOpenSpaceId(String openSpaceId) {
        this.openSpaceId = openSpaceId;
        return this;
    }
    public String getOpenSpaceId() {
        return this.openSpaceId;
    }

    public CreateAndDeliverWithDelegateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CreateAndDeliverWithDelegateRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public CreateAndDeliverWithDelegateRequest setTopOpenDeliverModel(CreateAndDeliverWithDelegateRequestTopOpenDeliverModel topOpenDeliverModel) {
        this.topOpenDeliverModel = topOpenDeliverModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel getTopOpenDeliverModel() {
        return this.topOpenDeliverModel;
    }

    public CreateAndDeliverWithDelegateRequest setTopOpenSpaceModel(CreateAndDeliverWithDelegateRequestTopOpenSpaceModel topOpenSpaceModel) {
        this.topOpenSpaceModel = topOpenSpaceModel;
        return this;
    }
    public CreateAndDeliverWithDelegateRequestTopOpenSpaceModel getTopOpenSpaceModel() {
        return this.topOpenSpaceModel;
    }

    public CreateAndDeliverWithDelegateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateAndDeliverWithDelegateRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class CreateAndDeliverWithDelegateRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static CreateAndDeliverWithDelegateRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestCardData self = new CreateAndDeliverWithDelegateRequestCardData();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel extends TeaModel {
        @NameInMap("bizTag")
        public String bizTag;

        @NameInMap("gmtTimeLine")
        public Long gmtTimeLine;

        public static CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel setGmtTimeLine(Long gmtTimeLine) {
            this.gmtTimeLine = gmtTimeLine;
            return this;
        }
        public Long getGmtTimeLine() {
            return this.gmtTimeLine;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel extends TeaModel {
        @NameInMap("coolAppCode")
        public String coolAppCode;

        @NameInMap("title")
        public String title;

        public static CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel self = new CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestDocOpenDeliverModel extends TeaModel {
        @NameInMap("userId")
        public String userId;

        public static CreateAndDeliverWithDelegateRequestDocOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestDocOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestDocOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestDocOpenDeliverModel setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("recipients")
        public java.util.List<String> recipients;

        @NameInMap("robotCode")
        public String robotCode;

        public static CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel setRecipients(java.util.List<String> recipients) {
            this.recipients = recipients;
            return this;
        }
        public java.util.List<String> getRecipients() {
            return this.recipients;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification self = new CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport self = new CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel self = new CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel setNotification(CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel setSearchSupport(CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel extends TeaModel {
        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("robotCode")
        public String robotCode;

        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification self = new CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport self = new CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel self = new CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel setNotification(CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel setSearchSupport(CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        public static CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification extends TeaModel {
        @NameInMap("alertContent")
        public String alertContent;

        @NameInMap("notificationOff")
        public Boolean notificationOff;

        public static CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification self = new CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification setAlertContent(String alertContent) {
            this.alertContent = alertContent;
            return this;
        }
        public String getAlertContent() {
            return this.alertContent;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification setNotificationOff(Boolean notificationOff) {
            this.notificationOff = notificationOff;
            return this;
        }
        public Boolean getNotificationOff() {
            return this.notificationOff;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport extends TeaModel {
        @NameInMap("searchDesc")
        public String searchDesc;

        @NameInMap("searchIcon")
        public String searchIcon;

        @NameInMap("searchTypeName")
        public String searchTypeName;

        public static CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport self = new CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchDesc(String searchDesc) {
            this.searchDesc = searchDesc;
            return this;
        }
        public String getSearchDesc() {
            return this.searchDesc;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchIcon(String searchIcon) {
            this.searchIcon = searchIcon;
            return this;
        }
        public String getSearchIcon() {
            return this.searchIcon;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport setSearchTypeName(String searchTypeName) {
            this.searchTypeName = searchTypeName;
            return this;
        }
        public String getSearchTypeName() {
            return this.searchTypeName;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel extends TeaModel {
        @NameInMap("lastMessageI18n")
        public java.util.Map<String, String> lastMessageI18n;

        @NameInMap("notification")
        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification notification;

        @NameInMap("searchSupport")
        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport searchSupport;

        @NameInMap("supportForward")
        public Boolean supportForward;

        public static CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel self = new CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
            this.lastMessageI18n = lastMessageI18n;
            return this;
        }
        public java.util.Map<String, String> getLastMessageI18n() {
            return this.lastMessageI18n;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel setNotification(CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification notification) {
            this.notification = notification;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification getNotification() {
            return this.notification;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel setSearchSupport(CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport searchSupport) {
            this.searchSupport = searchSupport;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport getSearchSupport() {
            return this.searchSupport;
        }

        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends TeaModel {
        @NameInMap("interval")
        public Integer interval;

        @NameInMap("pullStrategy")
        public String pullStrategy;

        @NameInMap("timeUnit")
        public String timeUnit;

        public static CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig self = new CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setPullStrategy(String pullStrategy) {
            this.pullStrategy = pullStrategy;
            return this;
        }
        public String getPullStrategy() {
            return this.pullStrategy;
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends TeaModel {
        @NameInMap("constParams")
        public java.util.Map<String, String> constParams;

        @NameInMap("dynamicDataSourceId")
        public String dynamicDataSourceId;

        @NameInMap("pullConfig")
        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig;

        public static CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs self = new CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setConstParams(java.util.Map<String, String> constParams) {
            this.constParams = constParams;
            return this;
        }
        public java.util.Map<String, String> getConstParams() {
            return this.constParams;
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setDynamicDataSourceId(String dynamicDataSourceId) {
            this.dynamicDataSourceId = dynamicDataSourceId;
            return this;
        }
        public String getDynamicDataSourceId() {
            return this.dynamicDataSourceId;
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs setPullConfig(CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig pullConfig) {
            this.pullConfig = pullConfig;
            return this;
        }
        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig getPullConfig() {
            return this.pullConfig;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig extends TeaModel {
        @NameInMap("dynamicDataSourceConfigs")
        public java.util.List<CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs;

        public static CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig self = new CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig setDynamicDataSourceConfigs(java.util.List<CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> dynamicDataSourceConfigs) {
            this.dynamicDataSourceConfigs = dynamicDataSourceConfigs;
            return this;
        }
        public java.util.List<CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> getDynamicDataSourceConfigs() {
            return this.dynamicDataSourceConfigs;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestTopOpenDeliverModel extends TeaModel {
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        @NameInMap("platforms")
        public java.util.List<String> platforms;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static CreateAndDeliverWithDelegateRequestTopOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestTopOpenDeliverModel self = new CreateAndDeliverWithDelegateRequestTopOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel setExpiredTimeMillis(Long expiredTimeMillis) {
            this.expiredTimeMillis = expiredTimeMillis;
            return this;
        }
        public Long getExpiredTimeMillis() {
            return this.expiredTimeMillis;
        }

        public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel setPlatforms(java.util.List<String> platforms) {
            this.platforms = platforms;
            return this;
        }
        public java.util.List<String> getPlatforms() {
            return this.platforms;
        }

        public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

    public static class CreateAndDeliverWithDelegateRequestTopOpenSpaceModel extends TeaModel {
        @NameInMap("spaceType")
        public String spaceType;

        public static CreateAndDeliverWithDelegateRequestTopOpenSpaceModel build(java.util.Map<String, ?> map) throws Exception {
            CreateAndDeliverWithDelegateRequestTopOpenSpaceModel self = new CreateAndDeliverWithDelegateRequestTopOpenSpaceModel();
            return TeaModel.build(map, self);
        }

        public CreateAndDeliverWithDelegateRequestTopOpenSpaceModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

}
