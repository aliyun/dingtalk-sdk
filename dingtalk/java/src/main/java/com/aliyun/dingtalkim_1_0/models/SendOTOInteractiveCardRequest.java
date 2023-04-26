// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendOTOInteractiveCardRequest extends TeaModel {
    @NameInMap("atOpenIds")
    public java.util.Map<String, String> atOpenIds;

    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("cardData")
    public SendOTOInteractiveCardRequestCardData cardData;

    @NameInMap("cardOptions")
    public SendOTOInteractiveCardRequestCardOptions cardOptions;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

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
