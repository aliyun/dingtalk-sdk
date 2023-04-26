// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotInteractiveCardRequest extends TeaModel {
    @NameInMap("callbackUrl")
    public String callbackUrl;

    @NameInMap("cardBizId")
    public String cardBizId;

    @NameInMap("cardData")
    public String cardData;

    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("pullStrategy")
    public Boolean pullStrategy;

    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("sendOptions")
    public SendRobotInteractiveCardRequestSendOptions sendOptions;

    @NameInMap("singleChatReceiver")
    public String singleChatReceiver;

    @NameInMap("unionIdPrivateDataMap")
    public String unionIdPrivateDataMap;

    @NameInMap("userIdPrivateDataMap")
    public String userIdPrivateDataMap;

    public static SendRobotInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotInteractiveCardRequest self = new SendRobotInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotInteractiveCardRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public SendRobotInteractiveCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public SendRobotInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendRobotInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendRobotInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendRobotInteractiveCardRequest setPullStrategy(Boolean pullStrategy) {
        this.pullStrategy = pullStrategy;
        return this;
    }
    public Boolean getPullStrategy() {
        return this.pullStrategy;
    }

    public SendRobotInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendRobotInteractiveCardRequest setSendOptions(SendRobotInteractiveCardRequestSendOptions sendOptions) {
        this.sendOptions = sendOptions;
        return this;
    }
    public SendRobotInteractiveCardRequestSendOptions getSendOptions() {
        return this.sendOptions;
    }

    public SendRobotInteractiveCardRequest setSingleChatReceiver(String singleChatReceiver) {
        this.singleChatReceiver = singleChatReceiver;
        return this;
    }
    public String getSingleChatReceiver() {
        return this.singleChatReceiver;
    }

    public SendRobotInteractiveCardRequest setUnionIdPrivateDataMap(String unionIdPrivateDataMap) {
        this.unionIdPrivateDataMap = unionIdPrivateDataMap;
        return this;
    }
    public String getUnionIdPrivateDataMap() {
        return this.unionIdPrivateDataMap;
    }

    public SendRobotInteractiveCardRequest setUserIdPrivateDataMap(String userIdPrivateDataMap) {
        this.userIdPrivateDataMap = userIdPrivateDataMap;
        return this;
    }
    public String getUserIdPrivateDataMap() {
        return this.userIdPrivateDataMap;
    }

    public static class SendRobotInteractiveCardRequestSendOptions extends TeaModel {
        @NameInMap("atAll")
        public Boolean atAll;

        @NameInMap("atUserListJson")
        public String atUserListJson;

        @NameInMap("cardPropertyJson")
        public String cardPropertyJson;

        @NameInMap("receiverListJson")
        public String receiverListJson;

        public static SendRobotInteractiveCardRequestSendOptions build(java.util.Map<String, ?> map) throws Exception {
            SendRobotInteractiveCardRequestSendOptions self = new SendRobotInteractiveCardRequestSendOptions();
            return TeaModel.build(map, self);
        }

        public SendRobotInteractiveCardRequestSendOptions setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public SendRobotInteractiveCardRequestSendOptions setAtUserListJson(String atUserListJson) {
            this.atUserListJson = atUserListJson;
            return this;
        }
        public String getAtUserListJson() {
            return this.atUserListJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setCardPropertyJson(String cardPropertyJson) {
            this.cardPropertyJson = cardPropertyJson;
            return this;
        }
        public String getCardPropertyJson() {
            return this.cardPropertyJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setReceiverListJson(String receiverListJson) {
            this.receiverListJson = receiverListJson;
            return this;
        }
        public String getReceiverListJson() {
            return this.receiverListJson;
        }

    }

}
