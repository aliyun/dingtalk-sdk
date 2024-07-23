// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PersonalSendCardMessageRequest extends TeaModel {
    @NameInMap("atUserIds")
    public java.util.List<String> atUserIds;

    @NameInMap("cardContent")
    public PersonalSendCardMessageRequestCardContent cardContent;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("receiveUserId")
    public String receiveUserId;

    public static PersonalSendCardMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PersonalSendCardMessageRequest self = new PersonalSendCardMessageRequest();
        return TeaModel.build(map, self);
    }

    public PersonalSendCardMessageRequest setAtUserIds(java.util.List<String> atUserIds) {
        this.atUserIds = atUserIds;
        return this;
    }
    public java.util.List<String> getAtUserIds() {
        return this.atUserIds;
    }

    public PersonalSendCardMessageRequest setCardContent(PersonalSendCardMessageRequestCardContent cardContent) {
        this.cardContent = cardContent;
        return this;
    }
    public PersonalSendCardMessageRequestCardContent getCardContent() {
        return this.cardContent;
    }

    public PersonalSendCardMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PersonalSendCardMessageRequest setReceiveUserId(String receiveUserId) {
        this.receiveUserId = receiveUserId;
        return this;
    }
    public String getReceiveUserId() {
        return this.receiveUserId;
    }

    public static class PersonalSendCardMessageRequestCardContent extends TeaModel {
        @NameInMap("lastMessage")
        public String lastMessage;

        @NameInMap("outTrackId")
        public String outTrackId;

        public static PersonalSendCardMessageRequestCardContent build(java.util.Map<String, ?> map) throws Exception {
            PersonalSendCardMessageRequestCardContent self = new PersonalSendCardMessageRequestCardContent();
            return TeaModel.build(map, self);
        }

        public PersonalSendCardMessageRequestCardContent setLastMessage(String lastMessage) {
            this.lastMessage = lastMessage;
            return this;
        }
        public String getLastMessage() {
            return this.lastMessage;
        }

        public PersonalSendCardMessageRequestCardContent setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

    }

}
