// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendDingTipRequest extends TeaModel {
    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    @NameInMap("link")
    public SendDingTipRequestLink link;

    @NameInMap("messageId")
    public String messageId;

    @NameInMap("receiverUserId")
    public java.util.List<String> receiverUserId;

    @NameInMap("textContent")
    public String textContent;

    public static SendDingTipRequest build(java.util.Map<String, ?> map) throws Exception {
        SendDingTipRequest self = new SendDingTipRequest();
        return TeaModel.build(map, self);
    }

    public SendDingTipRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public SendDingTipRequest setLink(SendDingTipRequestLink link) {
        this.link = link;
        return this;
    }
    public SendDingTipRequestLink getLink() {
        return this.link;
    }

    public SendDingTipRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
    public String getMessageId() {
        return this.messageId;
    }

    public SendDingTipRequest setReceiverUserId(java.util.List<String> receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public java.util.List<String> getReceiverUserId() {
        return this.receiverUserId;
    }

    public SendDingTipRequest setTextContent(String textContent) {
        this.textContent = textContent;
        return this;
    }
    public String getTextContent() {
        return this.textContent;
    }

    public static class SendDingTipRequestLink extends TeaModel {
        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("linkUrl")
        public String linkUrl;

        @NameInMap("picMediaId")
        public String picMediaId;

        @NameInMap("text")
        public String text;

        public static SendDingTipRequestLink build(java.util.Map<String, ?> map) throws Exception {
            SendDingTipRequestLink self = new SendDingTipRequestLink();
            return TeaModel.build(map, self);
        }

        public SendDingTipRequestLink setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public SendDingTipRequestLink setLinkUrl(String linkUrl) {
            this.linkUrl = linkUrl;
            return this;
        }
        public String getLinkUrl() {
            return this.linkUrl;
        }

        public SendDingTipRequestLink setPicMediaId(String picMediaId) {
            this.picMediaId = picMediaId;
            return this;
        }
        public String getPicMediaId() {
            return this.picMediaId;
        }

        public SendDingTipRequestLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
