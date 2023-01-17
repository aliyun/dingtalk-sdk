// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardRequest extends TeaModel {
    /**
     * <p>协作投放参数</p>
     */
    @NameInMap("coFeedOpenDeliverModel")
    public DeliverCardRequestCoFeedOpenDeliverModel coFeedOpenDeliverModel;

    /**
     * <p>群聊投放参数</p>
     */
    @NameInMap("imGroupOpenDeliverModel")
    public DeliverCardRequestImGroupOpenDeliverModel imGroupOpenDeliverModel;

    /**
     * <p>单聊机器人场域投放参数</p>
     * <br>
     * <p>【注意】 机器人与人的单聊，直接用支持机器人单聊的应用来发送</p>
     */
    @NameInMap("imRobotOpenDeliverModel")
    public DeliverCardRequestImRobotOpenDeliverModel imRobotOpenDeliverModel;

    /**
     * <p>dt.card//spaceType.spaceId;spaceType.spaceId</p>
     */
    @NameInMap("openSpaceId")
    public String openSpaceId;

    /**
     * <p>外部卡片实例Id</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>吊顶投放参数</p>
     */
    @NameInMap("topOpenDeliverModel")
    public DeliverCardRequestTopOpenDeliverModel topOpenDeliverModel;

    /**
     * <p>用户id类型：</p>
     * <br>
     * <p>1（默认）：userid模式</p>
     * <br>
     * <p>2：unionId模式</p>
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
         * <p>【必填】业务标识</p>
         */
        @NameInMap("bizTag")
        public String bizTag;

        /**
         * <p>【必填】协作场域下的排序时间</p>
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

    public static class DeliverCardRequestImGroupOpenDeliverModel extends TeaModel {
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
        /**
         * <p>【条件必填】IM机器人单聊暂无其他投放属性，仅需设置spaeType为IM_ROBOT</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        public static DeliverCardRequestImRobotOpenDeliverModel build(java.util.Map<String, ?> map) throws Exception {
            DeliverCardRequestImRobotOpenDeliverModel self = new DeliverCardRequestImRobotOpenDeliverModel();
            return TeaModel.build(map, self);
        }

        public DeliverCardRequestImRobotOpenDeliverModel setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

    }

    public static class DeliverCardRequestTopOpenDeliverModel extends TeaModel {
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
