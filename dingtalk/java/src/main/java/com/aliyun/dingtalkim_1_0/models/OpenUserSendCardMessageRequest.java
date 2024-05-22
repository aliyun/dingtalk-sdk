// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenUserSendCardMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardContent")
    public OpenUserSendCardMessageRequestCardContent cardContent;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("receiveUserId")
    public String receiveUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OpenUserSendCardMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenUserSendCardMessageRequest self = new OpenUserSendCardMessageRequest();
        return TeaModel.build(map, self);
    }

    public OpenUserSendCardMessageRequest setCardContent(OpenUserSendCardMessageRequestCardContent cardContent) {
        this.cardContent = cardContent;
        return this;
    }
    public OpenUserSendCardMessageRequestCardContent getCardContent() {
        return this.cardContent;
    }

    public OpenUserSendCardMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OpenUserSendCardMessageRequest setReceiveUserId(String receiveUserId) {
        this.receiveUserId = receiveUserId;
        return this;
    }
    public String getReceiveUserId() {
        return this.receiveUserId;
    }

    public OpenUserSendCardMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class OpenUserSendCardMessageRequestCardContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("lastMessage")
        public String lastMessage;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("outTrackId")
        public String outTrackId;

        public static OpenUserSendCardMessageRequestCardContent build(java.util.Map<String, ?> map) throws Exception {
            OpenUserSendCardMessageRequestCardContent self = new OpenUserSendCardMessageRequestCardContent();
            return TeaModel.build(map, self);
        }

        public OpenUserSendCardMessageRequestCardContent setLastMessage(String lastMessage) {
            this.lastMessage = lastMessage;
            return this;
        }
        public String getLastMessage() {
            return this.lastMessage;
        }

        public OpenUserSendCardMessageRequestCardContent setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

    }

}
