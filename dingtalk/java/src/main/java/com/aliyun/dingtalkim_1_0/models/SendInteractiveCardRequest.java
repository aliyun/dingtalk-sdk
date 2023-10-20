// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveCardRequest extends TeaModel {
    @NameInMap("atOpenIds")
    public java.util.Map<String, String> atOpenIds;

    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("cardData")
    public SendInteractiveCardRequestCardData cardData;

    @NameInMap("cardOptions")
    public SendInteractiveCardRequestCardOptions cardOptions;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("chatBotId")
    public String chatBotId;

    @NameInMap("conversationType")
    public Integer conversationType;

    @NameInMap("digitalWorkerCode")
    public String digitalWorkerCode;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("pullStrategy")
    public Boolean pullStrategy;

    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    @NameInMap("robotCode")
    public String robotCode;

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

    public SendInteractiveCardRequest setDigitalWorkerCode(String digitalWorkerCode) {
        this.digitalWorkerCode = digitalWorkerCode;
        return this;
    }
    public String getDigitalWorkerCode() {
        return this.digitalWorkerCode;
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
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, String> cardMediaIdParamMap;

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
