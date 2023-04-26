// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InteractiveCardCreateInstanceRequest extends TeaModel {
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    @NameInMap("cardData")
    public InteractiveCardCreateInstanceRequestCardData cardData;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("chatBotId")
    public String chatBotId;

    @NameInMap("conversationType")
    public Integer conversationType;

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

    public static InteractiveCardCreateInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        InteractiveCardCreateInstanceRequest self = new InteractiveCardCreateInstanceRequest();
        return TeaModel.build(map, self);
    }

    public InteractiveCardCreateInstanceRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public InteractiveCardCreateInstanceRequest setCardData(InteractiveCardCreateInstanceRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public InteractiveCardCreateInstanceRequestCardData getCardData() {
        return this.cardData;
    }

    public InteractiveCardCreateInstanceRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public InteractiveCardCreateInstanceRequest setChatBotId(String chatBotId) {
        this.chatBotId = chatBotId;
        return this;
    }
    public String getChatBotId() {
        return this.chatBotId;
    }

    public InteractiveCardCreateInstanceRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public InteractiveCardCreateInstanceRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public InteractiveCardCreateInstanceRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public InteractiveCardCreateInstanceRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public InteractiveCardCreateInstanceRequest setPullStrategy(Boolean pullStrategy) {
        this.pullStrategy = pullStrategy;
        return this;
    }
    public Boolean getPullStrategy() {
        return this.pullStrategy;
    }

    public InteractiveCardCreateInstanceRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public InteractiveCardCreateInstanceRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public InteractiveCardCreateInstanceRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class InteractiveCardCreateInstanceRequestCardData extends TeaModel {
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, String> cardMediaIdParamMap;

        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static InteractiveCardCreateInstanceRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            InteractiveCardCreateInstanceRequestCardData self = new InteractiveCardCreateInstanceRequestCardData();
            return TeaModel.build(map, self);
        }

        public InteractiveCardCreateInstanceRequestCardData setCardMediaIdParamMap(java.util.Map<String, String> cardMediaIdParamMap) {
            this.cardMediaIdParamMap = cardMediaIdParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardMediaIdParamMap() {
            return this.cardMediaIdParamMap;
        }

        public InteractiveCardCreateInstanceRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

}
