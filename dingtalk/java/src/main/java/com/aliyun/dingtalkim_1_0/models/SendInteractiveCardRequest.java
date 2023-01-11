// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveCardRequest extends TeaModel {
    /**
     * <p>消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】</p>
     */
    @NameInMap("atOpenIds")
    public java.util.Map<String, String> atOpenIds;

    /**
     * <p>可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <p>卡片公共主体部分数据</p>
     */
    @NameInMap("cardData")
    public SendInteractiveCardRequestCardData cardData;

    /**
     * <p>卡片属性</p>
     */
    @NameInMap("cardOptions")
    public SendInteractiveCardRequestCardOptions cardOptions;

    /**
     * <p>卡片模板ID</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>【robotCode & chatBotId二选一必填】机器人ID（企业机器人）</p>
     */
    @NameInMap("chatBotId")
    public String chatBotId;

    /**
     * <p>发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）</p>
     */
    @NameInMap("conversationType")
    public Integer conversationType;

    /**
     * <p>接收卡片的群的openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）</p>
     */
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    /**
     * <p>是否开启卡片纯拉模式</p>
     */
    @NameInMap("pullStrategy")
    public Boolean pullStrategy;

    /**
     * <p>互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见</p>
     */
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    /**
     * <p>【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式</p>
     */
    @NameInMap("userIdType")
    public Integer userIdType;

    public static SendInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveCardRequest self = new SendInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendInteractiveCardRequest setAtOpenIds(java.util.Map<String, String> atOpenIds) {
        this.atOpenIds = atOpenIds;
        return this;
    }
    public java.util.Map<String, String> getAtOpenIds() {
        return this.atOpenIds;
    }

    public SendInteractiveCardRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public SendInteractiveCardRequest setCardData(SendInteractiveCardRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public SendInteractiveCardRequestCardData getCardData() {
        return this.cardData;
    }

    public SendInteractiveCardRequest setCardOptions(SendInteractiveCardRequestCardOptions cardOptions) {
        this.cardOptions = cardOptions;
        return this;
    }
    public SendInteractiveCardRequestCardOptions getCardOptions() {
        return this.cardOptions;
    }

    public SendInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendInteractiveCardRequest setChatBotId(String chatBotId) {
        this.chatBotId = chatBotId;
        return this;
    }
    public String getChatBotId() {
        return this.chatBotId;
    }

    public SendInteractiveCardRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public SendInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendInteractiveCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public SendInteractiveCardRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public SendInteractiveCardRequest setPullStrategy(Boolean pullStrategy) {
        this.pullStrategy = pullStrategy;
        return this;
    }
    public Boolean getPullStrategy() {
        return this.pullStrategy;
    }

    public SendInteractiveCardRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public SendInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendInteractiveCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class SendInteractiveCardRequestCardData extends TeaModel {
        /**
         * <p>卡片模板内容替换参数-多媒体类型</p>
         */
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, String> cardMediaIdParamMap;

        /**
         * <p>卡片模板内容替换参数-普通文本类型</p>
         */
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static SendInteractiveCardRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            SendInteractiveCardRequestCardData self = new SendInteractiveCardRequestCardData();
            return TeaModel.build(map, self);
        }

        public SendInteractiveCardRequestCardData setCardMediaIdParamMap(java.util.Map<String, String> cardMediaIdParamMap) {
            this.cardMediaIdParamMap = cardMediaIdParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardMediaIdParamMap() {
            return this.cardMediaIdParamMap;
        }

        public SendInteractiveCardRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class SendInteractiveCardRequestCardOptions extends TeaModel {
        /**
         * <p>是否支持转发</p>
         */
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static SendInteractiveCardRequestCardOptions build(java.util.Map<String, ?> map) throws Exception {
            SendInteractiveCardRequestCardOptions self = new SendInteractiveCardRequestCardOptions();
            return TeaModel.build(map, self);
        }

        public SendInteractiveCardRequestCardOptions setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

}
