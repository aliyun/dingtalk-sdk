// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardWithDelegateRequest extends TeaModel {
    @NameInMap("coFeedOpenDeliverModel")
    public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    @NameInMap("docOpenDeliverModel")
    public DeliverCardWithDelegateRequestDocOpenDeliverModel docOpenDeliverModel;

    @NameInMap("imGroupOpenDeliverModel")
    public DeliverCardWithDelegateRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    @NameInMap("imRobotOpenDeliverModel")
    public DeliverCardWithDelegateRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    @NameInMap("imSingleOpenDeliverModel")
    public DeliverCardWithDelegateRequestImSingleOpenDeliverModel imSingleOpenDeliverModel;

    @NameInMap("openSpaceId")
    public String openSpaceId;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("topOpenDeliverModel")
    public DeliverCardWithDelegateRequestTopOpenDeliverModel topOpenDeliverModel;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static DeliverCardWithDelegateRequest build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardWithDelegateRequest self = new DeliverCardWithDelegateRequest();
        return TeaModel.build(map, self);
    }

    public DeliverCardWithDelegateRequest setCoFeedOpenDeliverModel(DeliverCardWithDelegateRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel) {
        this.coFeedOpenDeliverModel = coFeedOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel getCoFeedOpenDeliverModel() {
        return this.coFeedOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setDocOpenDeliverModel(DeliverCardWithDelegateRequestDocOpenDeliverModel docOpenDeliverModel) {
        this.docOpenDeliverModel = docOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestDocOpenDeliverModel getDocOpenDeliverModel() {
        return this.docOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setImGroupOpenDeliverModel(DeliverCardWithDelegateRequestImGroupOpenDeliverModel imGroupOpenDeliverModel) {
        this.imGroupOpenDeliverModel = imGroupOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestImGroupOpenDeliverModel getImGroupOpenDeliverModel() {
        return this.imGroupOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setImRobotOpenDeliverModel(DeliverCardWithDelegateRequestImRobotOpenDeliverModel imRobotOpenDeliverModel) {
        this.imRobotOpenDeliverModel = imRobotOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestImRobotOpenDeliverModel getImRobotOpenDeliverModel() {
        return this.imRobotOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setImSingleOpenDeliverModel(DeliverCardWithDelegateRequestImSingleOpenDeliverModel imSingleOpenDeliverModel) {
        this.imSingleOpenDeliverModel = imSingleOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestImSingleOpenDeliverModel getImSingleOpenDeliverModel() {
        return this.imSingleOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setOpenSpaceId(String openSpaceId) {
        this.openSpaceId = openSpaceId;
        return this;
    }
    public String getOpenSpaceId() {
        return this.openSpaceId;
    }

    public DeliverCardWithDelegateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public DeliverCardWithDelegateRequest setTopOpenDeliverModel(DeliverCardWithDelegateRequestTopOpenDeliverModel topOpenDeliverModel) {
        this.topOpenDeliverModel = topOpenDeliverModel;
        return this;
    }
    public DeliverCardWithDelegateRequestTopOpenDeliverModel getTopOpenDeliverModel() {
        return this.topOpenDeliverModel;
    }

    public DeliverCardWithDelegateRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class DeliverCardWithDelegateRequestCoFeedOpenDeliverModel extends TeaModel {
        @NameInMap("bizTag")
        public String bizTag;

        @NameInMap("gmtTimeLine")
        public Long gmtTimeLine;

        public static DeliverCardWithDelegateRequestCoFeedOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestCoFeedOpenDeliverModel self = new DeliverCardWithDelegateRequestCoFeedOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel setGmtTimeLine(Long gmtTimeLine) {
            this.gmtTimeLine = gmtTimeLine;
            return this;
        }
        public Long getGmtTimeLine() {
            return this.gmtTimeLine;
        }

    }

    public static class DeliverCardWithDelegateRequestDocOpenDeliverModel extends TeaModel {
        @NameInMap("userId")
        public String userId;

        public static DeliverCardWithDelegateRequestDocOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestDocOpenDeliverModel self = new DeliverCardWithDelegateRequestDocOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestDocOpenDeliverModel setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class DeliverCardWithDelegateRequestImGroupOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("recipients")
        public java.util.List<String> recipients;

        @NameInMap("robotCode")
        public String robotCode;

        public static DeliverCardWithDelegateRequestImGroupOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestImGroupOpenDeliverModel self = new DeliverCardWithDelegateRequestImGroupOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel setRecipients(java.util.List<String> recipients) {
            this.recipients = recipients;
            return this;
        }
        public java.util.List<String> getRecipients() {
            return this.recipients;
        }

        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

    public static class DeliverCardWithDelegateRequestImRobotOpenDeliverModel extends TeaModel {
        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("robotCode")
        public String robotCode;

        @NameInMap("spaceType")
        public String spaceType;

        public static DeliverCardWithDelegateRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestImRobotOpenDeliverModel self = new DeliverCardWithDelegateRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestImRobotOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public DeliverCardWithDelegateRequestImRobotOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

        public DeliverCardWithDelegateRequestImRobotOpenDeliverModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

    public static class DeliverCardWithDelegateRequestImSingleOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        public static DeliverCardWithDelegateRequestImSingleOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestImSingleOpenDeliverModel self = new DeliverCardWithDelegateRequestImSingleOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestImSingleOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public DeliverCardWithDelegateRequestImSingleOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

    }

    public static class DeliverCardWithDelegateRequestTopOpenDeliverModel extends TeaModel {
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        @NameInMap("platforms")
        public java.util.List<String> platforms;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static DeliverCardWithDelegateRequestTopOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardWithDelegateRequestTopOpenDeliverModel self = new DeliverCardWithDelegateRequestTopOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardWithDelegateRequestTopOpenDeliverModel setExpiredTimeMillis(Long expiredTimeMillis) {
            this.expiredTimeMillis = expiredTimeMillis;
            return this;
        }
        public Long getExpiredTimeMillis() {
            return this.expiredTimeMillis;
        }

        public DeliverCardWithDelegateRequestTopOpenDeliverModel setPlatforms(java.util.List<String> platforms) {
            this.platforms = platforms;
            return this;
        }
        public java.util.List<String> getPlatforms() {
            return this.platforms;
        }

        public DeliverCardWithDelegateRequestTopOpenDeliverModel setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
