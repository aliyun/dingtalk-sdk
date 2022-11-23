// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendOTOInteractiveCardRequest extends TeaModel {
    // 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
    @NameInMap("atOpenIds")
    public java.util.Map<String, String> atOpenIds;

    // 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    // 卡片公共主体部分数据
    @NameInMap("cardData")
    public SendOTOInteractiveCardRequestCardData cardData;

    // 卡片属性
    @NameInMap("cardOptions")
    public SendOTOInteractiveCardRequestCardOptions cardOptions;

    // 卡片模板ID
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 接收卡片的群的openConversationId
    @NameInMap("openConversationId")
    public String openConversationId;

    // 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
    @NameInMap("outTrackId")
    public String outTrackId;

    // 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    // 是否开启卡片纯拉模式
    @NameInMap("pullStrategy")
    public Boolean pullStrategy;

    // 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    // 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
    @NameInMap("robotCode")
    public String robotCode;

    // 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
    @NameInMap("userIdType")
    public Integer userIdType;

    public static SendOTOInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendOTOInteractiveCardRequest self = new SendOTOInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendOTOInteractiveCardRequest setAtOpenIds(java.util.Map<String, String> atOpenIds) {
        this.atOpenIds = atOpenIds;
        return this;
    }
    public java.util.Map<String, String> getAtOpenIds() {
        return this.atOpenIds;
    }

    public SendOTOInteractiveCardRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public SendOTOInteractiveCardRequest setCardData(SendOTOInteractiveCardRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public SendOTOInteractiveCardRequestCardData getCardData() {
        return this.cardData;
    }

    public SendOTOInteractiveCardRequest setCardOptions(SendOTOInteractiveCardRequestCardOptions cardOptions) {
        this.cardOptions = cardOptions;
        return this;
    }
    public SendOTOInteractiveCardRequestCardOptions getCardOptions() {
        return this.cardOptions;
    }

    public SendOTOInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendOTOInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendOTOInteractiveCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public SendOTOInteractiveCardRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public SendOTOInteractiveCardRequest setPullStrategy(Boolean pullStrategy) {
        this.pullStrategy = pullStrategy;
        return this;
    }
    public Boolean getPullStrategy() {
        return this.pullStrategy;
    }

    public SendOTOInteractiveCardRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public SendOTOInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendOTOInteractiveCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class SendOTOInteractiveCardRequestCardData extends TeaModel {
        // 卡片模板内容替换参数-普通文本类型
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static SendOTOInteractiveCardRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            SendOTOInteractiveCardRequestCardData self = new SendOTOInteractiveCardRequestCardData();
            return TeaModel.build(map, self);
        }

        public SendOTOInteractiveCardRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class SendOTOInteractiveCardRequestCardOptions extends TeaModel {
        // 是否支持转发
        @NameInMap("supportForward")
        public Boolean supportForward;

        public static SendOTOInteractiveCardRequestCardOptions build(java.util.Map<String, ?> map) throws Exception {
            SendOTOInteractiveCardRequestCardOptions self = new SendOTOInteractiveCardRequestCardOptions();
            return TeaModel.build(map, self);
        }

        public SendOTOInteractiveCardRequestCardOptions setSupportForward(Boolean supportForward) {
            this.supportForward = supportForward;
            return this;
        }
        public Boolean getSupportForward() {
            return this.supportForward;
        }

    }

}
