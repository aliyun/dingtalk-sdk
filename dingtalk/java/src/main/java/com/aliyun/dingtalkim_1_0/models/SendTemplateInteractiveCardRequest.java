// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendTemplateInteractiveCardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="https://xxxx.com/.../">https://xxxx.com/.../</a></p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>根据具体的cardTemplateId参考文档格式</p>
     */
    @NameInMap("cardData")
    public String cardData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>TuWenCard01</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <strong>example:</strong>
     * <p>cidXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cardXXXX01</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("sendOptions")
    public SendTemplateInteractiveCardRequestSendOptions sendOptions;

    /**
     * <strong>example:</strong>
     * <p>以userId为例：{&quot;userId&quot;:&quot;userId0001&quot;}；以unionId为例{&quot;unionId&quot;:&quot;unionId001&quot;}</p>
     */
    @NameInMap("singleChatReceiver")
    public String singleChatReceiver;

    public static SendTemplateInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendTemplateInteractiveCardRequest self = new SendTemplateInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendTemplateInteractiveCardRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public SendTemplateInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendTemplateInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendTemplateInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendTemplateInteractiveCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public SendTemplateInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendTemplateInteractiveCardRequest setSendOptions(SendTemplateInteractiveCardRequestSendOptions sendOptions) {
        this.sendOptions = sendOptions;
        return this;
    }
    public SendTemplateInteractiveCardRequestSendOptions getSendOptions() {
        return this.sendOptions;
    }

    public SendTemplateInteractiveCardRequest setSingleChatReceiver(String singleChatReceiver) {
        this.singleChatReceiver = singleChatReceiver;
        return this;
    }
    public String getSingleChatReceiver() {
        return this.singleChatReceiver;
    }

    public static class SendTemplateInteractiveCardRequestSendOptions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("atAll")
        public Boolean atAll;

        /**
         * <strong>example:</strong>
         * <p>[{&quot;nickName&quot;:&quot;张三&quot;,&quot;userId&quot;:&quot;userId0001&quot;},{&quot;nickName&quot;:&quot;李四&quot;,&quot;unionId&quot;:&quot;unionId001&quot;}]</p>
         */
        @NameInMap("atUserListJson")
        public String atUserListJson;

        /**
         * <strong>example:</strong>
         * <p>{}</p>
         */
        @NameInMap("cardPropertyJson")
        public String cardPropertyJson;

        /**
         * <strong>example:</strong>
         * <p>[{&quot;userId&quot;:&quot;userId0001&quot;},{&quot;unionId&quot;:&quot;unionId001&quot;}]</p>
         */
        @NameInMap("receiverListJson")
        public String receiverListJson;

        public static SendTemplateInteractiveCardRequestSendOptions build(java.util.Map<String, ?> map) throws Exception {
            SendTemplateInteractiveCardRequestSendOptions self = new SendTemplateInteractiveCardRequestSendOptions();
            return TeaModel.build(map, self);
        }

        public SendTemplateInteractiveCardRequestSendOptions setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public SendTemplateInteractiveCardRequestSendOptions setAtUserListJson(String atUserListJson) {
            this.atUserListJson = atUserListJson;
            return this;
        }
        public String getAtUserListJson() {
            return this.atUserListJson;
        }

        public SendTemplateInteractiveCardRequestSendOptions setCardPropertyJson(String cardPropertyJson) {
            this.cardPropertyJson = cardPropertyJson;
            return this;
        }
        public String getCardPropertyJson() {
            return this.cardPropertyJson;
        }

        public SendTemplateInteractiveCardRequestSendOptions setReceiverListJson(String receiverListJson) {
            this.receiverListJson = receiverListJson;
            return this;
        }
        public String getReceiverListJson() {
            return this.receiverListJson;
        }

    }

}
