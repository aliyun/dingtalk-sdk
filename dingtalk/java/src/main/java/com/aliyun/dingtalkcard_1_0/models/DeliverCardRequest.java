// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardRequest extends TeaModel {
    @NameInMap("coFeedOpenDeliverModel")
    public DeliverCardRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    @NameInMap("docOpenDeliverModel")
    public DeliverCardRequestDocOpenDeliverModel docOpenDeliverModel;

    @NameInMap("imGroupOpenDeliverModel")
    public DeliverCardRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    @NameInMap("imRobotOpenDeliverModel")
    public DeliverCardRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    @NameInMap("imSingleOpenDeliverModel")
    public DeliverCardRequestImSingleOpenDeliverModel imSingleOpenDeliverModel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dtv1.card//im_group.cidp4Gh<em><strong><strong><strong>VCQ==;im_robot.manager</strong></strong>67;co_feed.manager</strong></em><em>67;one_box.cidp4Gh</em>******VCQ==</p>
     */
    @NameInMap("openSpaceId")
    public String openSpaceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>out_track_id_123456</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("topOpenDeliverModel")
    public DeliverCardRequestTopOpenDeliverModel topOpenDeliverModel;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("userIdType")
    public Integer userIdType;

    public static DeliverCardRequest build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardRequest self = new DeliverCardRequest();
        return TeaModel.build(map, self);
    }

    public DeliverCardRequest setCoFeedOpenDeliverModel(DeliverCardRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel) {
        this.coFeedOpenDeliverModel = coFeedOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestCoFeedOpenDeliverModel getCoFeedOpenDeliverModel() {
        return this.coFeedOpenDeliverModel;
    }

    public DeliverCardRequest setDocOpenDeliverModel(DeliverCardRequestDocOpenDeliverModel docOpenDeliverModel) {
        this.docOpenDeliverModel = docOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestDocOpenDeliverModel getDocOpenDeliverModel() {
        return this.docOpenDeliverModel;
    }

    public DeliverCardRequest setImGroupOpenDeliverModel(DeliverCardRequestImGroupOpenDeliverModel imGroupOpenDeliverModel) {
        this.imGroupOpenDeliverModel = imGroupOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestImGroupOpenDeliverModel getImGroupOpenDeliverModel() {
        return this.imGroupOpenDeliverModel;
    }

    public DeliverCardRequest setImRobotOpenDeliverModel(DeliverCardRequestImRobotOpenDeliverModel imRobotOpenDeliverModel) {
        this.imRobotOpenDeliverModel = imRobotOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestImRobotOpenDeliverModel getImRobotOpenDeliverModel() {
        return this.imRobotOpenDeliverModel;
    }

    public DeliverCardRequest setImSingleOpenDeliverModel(DeliverCardRequestImSingleOpenDeliverModel imSingleOpenDeliverModel) {
        this.imSingleOpenDeliverModel = imSingleOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestImSingleOpenDeliverModel getImSingleOpenDeliverModel() {
        return this.imSingleOpenDeliverModel;
    }

    public DeliverCardRequest setOpenSpaceId(String openSpaceId) {
        this.openSpaceId = openSpaceId;
        return this;
    }
    public String getOpenSpaceId() {
        return this.openSpaceId;
    }

    public DeliverCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public DeliverCardRequest setTopOpenDeliverModel(DeliverCardRequestTopOpenDeliverModel topOpenDeliverModel) {
        this.topOpenDeliverModel = topOpenDeliverModel;
        return this;
    }
    public DeliverCardRequestTopOpenDeliverModel getTopOpenDeliverModel() {
        return this.topOpenDeliverModel;
    }

    public DeliverCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class DeliverCardRequestCoFeedOpenDeliverModel extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxx_biz_tag</p>
         */
        @NameInMap("bizTag")
        public String bizTag;

        /**
         * <strong>example:</strong>
         * <p>1665473229000</p>
         */
        @NameInMap("gmtTimeLine")
        public Long gmtTimeLine;

        public static DeliverCardRequestCoFeedOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestCoFeedOpenDeliverModel self = new DeliverCardRequestCoFeedOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestCoFeedOpenDeliverModel setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public DeliverCardRequestCoFeedOpenDeliverModel setGmtTimeLine(Long gmtTimeLine) {
            this.gmtTimeLine = gmtTimeLine;
            return this;
        }
        public Long getGmtTimeLine() {
            return this.gmtTimeLine;
        }

    }

    public static class DeliverCardRequestDocOpenDeliverModel extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxx_biz_tag</p>
         */
        @NameInMap("userId")
        public String userId;

        public static DeliverCardRequestDocOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestDocOpenDeliverModel self = new DeliverCardRequestDocOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestDocOpenDeliverModel setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class DeliverCardRequestImGroupOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("recipients")
        public java.util.List<String> recipients;

        /**
         * <strong>example:</strong>
         * <p>dingg3xmqdkpaojuakm8</p>
         */
        @NameInMap("robotCode")
        public String robotCode;

        public static DeliverCardRequestImGroupOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestImGroupOpenDeliverModel self = new DeliverCardRequestImGroupOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestImGroupOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public DeliverCardRequestImGroupOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public DeliverCardRequestImGroupOpenDeliverModel setRecipients(java.util.List<String> recipients) {
            this.recipients = recipients;
            return this;
        }
        public java.util.List<String> getRecipients() {
            return this.recipients;
        }

        public DeliverCardRequestImGroupOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

    public static class DeliverCardRequestImRobotOpenDeliverModel extends TeaModel {
        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        /**
         * <strong>example:</strong>
         * <p>dingg3xmqdkpaojuakm8</p>
         */
        @NameInMap("robotCode")
        public String robotCode;

        /**
         * <strong>example:</strong>
         * <p>IM_ROBOT</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        public static DeliverCardRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestImRobotOpenDeliverModel self = new DeliverCardRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestImRobotOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public DeliverCardRequestImRobotOpenDeliverModel setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

        public DeliverCardRequestImRobotOpenDeliverModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

    public static class DeliverCardRequestImSingleOpenDeliverModel extends TeaModel {
        @NameInMap("atUserIds")
        public java.util.Map<String, String> atUserIds;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        public static DeliverCardRequestImSingleOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestImSingleOpenDeliverModel self = new DeliverCardRequestImSingleOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestImSingleOpenDeliverModel setAtUserIds(java.util.Map<String, String> atUserIds) {
            this.atUserIds = atUserIds;
            return this;
        }
        public java.util.Map<String, String> getAtUserIds() {
            return this.atUserIds;
        }

        public DeliverCardRequestImSingleOpenDeliverModel setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

    }

    public static class DeliverCardRequestTopOpenDeliverModel extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1665473229000</p>
         */
        @NameInMap("expiredTimeMillis")
        public Long expiredTimeMillis;

        @NameInMap("platforms")
        public java.util.List<String> platforms;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static DeliverCardRequestTopOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestTopOpenDeliverModel self = new DeliverCardRequestTopOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestTopOpenDeliverModel setExpiredTimeMillis(Long expiredTimeMillis) {
            this.expiredTimeMillis = expiredTimeMillis;
            return this;
        }
        public Long getExpiredTimeMillis() {
            return this.expiredTimeMillis;
        }

        public DeliverCardRequestTopOpenDeliverModel setPlatforms(java.util.List<String> platforms) {
            this.platforms = platforms;
            return this;
        }
        public java.util.List<String> getPlatforms() {
            return this.platforms;
        }

        public DeliverCardRequestTopOpenDeliverModel setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
