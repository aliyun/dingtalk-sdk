// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DraftMessage extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bccRecipients")
    public java.util.List<Recipient> bccRecipients;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public DraftMessageBody body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ccRecipients")
    public java.util.List<Recipient> ccRecipients;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("from")
    public Recipient from;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("internetMessageHeaders")
    public java.util.Map<String, ?> internetMessageHeaders;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="mailto:uniqid@dingtalk.com">uniqid@dingtalk.com</a></p>
     */
    @NameInMap("internetMessageId")
    public java.io.InputStream internetMessageId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isReadReceiptRequested")
    public Boolean isReadReceiptRequested;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PRY_NORMAL</p>
     */
    @NameInMap("priority")
    public java.io.InputStream priority;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("replyTo")
    public Recipient replyTo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>主题</p>
     */
    @NameInMap("subject")
    public java.io.InputStream subject;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("summary")
    public java.io.InputStream summary;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tags")
    public java.util.List<java.io.InputStream> tags;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("toRecipients")
    public java.util.List<Recipient> toRecipients;

    public static DraftMessage build(java.util.Map<String, ?> map) throws Exception {
        DraftMessage self = new DraftMessage();
        return TeaModel.build(map, self);
    }

    public DraftMessage setBccRecipients(java.util.List<Recipient> bccRecipients) {
        this.bccRecipients = bccRecipients;
        return this;
    }
    public java.util.List<Recipient> getBccRecipients() {
        return this.bccRecipients;
    }

    public DraftMessage setBody(DraftMessageBody body) {
        this.body = body;
        return this;
    }
    public DraftMessageBody getBody() {
        return this.body;
    }

    public DraftMessage setCcRecipients(java.util.List<Recipient> ccRecipients) {
        this.ccRecipients = ccRecipients;
        return this;
    }
    public java.util.List<Recipient> getCcRecipients() {
        return this.ccRecipients;
    }

    public DraftMessage setFrom(Recipient from) {
        this.from = from;
        return this;
    }
    public Recipient getFrom() {
        return this.from;
    }

    public DraftMessage setInternetMessageHeaders(java.util.Map<String, ?> internetMessageHeaders) {
        this.internetMessageHeaders = internetMessageHeaders;
        return this;
    }
    public java.util.Map<String, ?> getInternetMessageHeaders() {
        return this.internetMessageHeaders;
    }

    public DraftMessage setInternetMessageId(java.io.InputStream internetMessageId) {
        this.internetMessageId = internetMessageId;
        return this;
    }
    public java.io.InputStream getInternetMessageId() {
        return this.internetMessageId;
    }

    public DraftMessage setIsReadReceiptRequested(Boolean isReadReceiptRequested) {
        this.isReadReceiptRequested = isReadReceiptRequested;
        return this;
    }
    public Boolean getIsReadReceiptRequested() {
        return this.isReadReceiptRequested;
    }

    public DraftMessage setPriority(java.io.InputStream priority) {
        this.priority = priority;
        return this;
    }
    public java.io.InputStream getPriority() {
        return this.priority;
    }

    public DraftMessage setReplyTo(Recipient replyTo) {
        this.replyTo = replyTo;
        return this;
    }
    public Recipient getReplyTo() {
        return this.replyTo;
    }

    public DraftMessage setSubject(java.io.InputStream subject) {
        this.subject = subject;
        return this;
    }
    public java.io.InputStream getSubject() {
        return this.subject;
    }

    public DraftMessage setSummary(java.io.InputStream summary) {
        this.summary = summary;
        return this;
    }
    public java.io.InputStream getSummary() {
        return this.summary;
    }

    public DraftMessage setTags(java.util.List<java.io.InputStream> tags) {
        this.tags = tags;
        return this;
    }
    public java.util.List<java.io.InputStream> getTags() {
        return this.tags;
    }

    public DraftMessage setToRecipients(java.util.List<Recipient> toRecipients) {
        this.toRecipients = toRecipients;
        return this;
    }
    public java.util.List<Recipient> getToRecipients() {
        return this.toRecipients;
    }

    public static class DraftMessageBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bodyHtml")
        public java.io.InputStream bodyHtml;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bodyText")
        public java.io.InputStream bodyText;

        public static DraftMessageBody build(java.util.Map<String, ?> map) throws Exception {
            DraftMessageBody self = new DraftMessageBody();
            return TeaModel.build(map, self);
        }

        public DraftMessageBody setBodyHtml(java.io.InputStream bodyHtml) {
            this.bodyHtml = bodyHtml;
            return this;
        }
        public java.io.InputStream getBodyHtml() {
            return this.bodyHtml;
        }

        public DraftMessageBody setBodyText(java.io.InputStream bodyText) {
            this.bodyText = bodyText;
            return this;
        }
        public java.io.InputStream getBodyText() {
            return this.bodyText;
        }

    }

}
