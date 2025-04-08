// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class Message extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bccRecipients")
    public java.util.List<Recipient> bccRecipients;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public MessageBody body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ccRecipients")
    public java.util.List<Recipient> ccRecipients;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>conversationid</p>
     */
    @NameInMap("conversationId")
    public java.io.InputStream conversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("folderId")
    public java.io.InputStream folderId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("from")
    public Recipient from;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasAttachments")
    public Boolean hasAttachments;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>mailid</p>
     */
    @NameInMap("id")
    public java.io.InputStream id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>由RFC5322定义的邮件头集合</p>
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
    @NameInMap("isForwarded")
    public Boolean isForwarded;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isRead")
    public Boolean isRead;

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
     * <p>false</p>
     */
    @NameInMap("isReplied")
    public Boolean isReplied;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2024-10-01T00:00:00Z</p>
     */
    @NameInMap("lastModifiedDateTime")
    public java.io.InputStream lastModifiedDateTime;

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
     * 
     * <strong>example:</strong>
     * <p>2024-10-01T00:00:00Z</p>
     */
    @NameInMap("receivedDateTime")
    public java.io.InputStream receivedDateTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("replyTo")
    public Recipient replyTo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2024-10-01T00:00:00Z</p>
     */
    @NameInMap("sentDateTime")
    public java.io.InputStream sentDateTime;

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
     * 
     * <strong>example:</strong>
     * <p>一般取邮件正文的前一段</p>
     */
    @NameInMap("summary")
    public java.io.InputStream summary;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tags")
    public java.util.List<String> tags;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("toRecipients")
    public java.util.List<Recipient> toRecipients;

    public static Message build(java.util.Map<String, ?> map) throws Exception {
        Message self = new Message();
        return TeaModel.build(map, self);
    }

    public Message setBccRecipients(java.util.List<Recipient> bccRecipients) {
        this.bccRecipients = bccRecipients;
        return this;
    }
    public java.util.List<Recipient> getBccRecipients() {
        return this.bccRecipients;
    }

    public Message setBody(MessageBody body) {
        this.body = body;
        return this;
    }
    public MessageBody getBody() {
        return this.body;
    }

    public Message setCcRecipients(java.util.List<Recipient> ccRecipients) {
        this.ccRecipients = ccRecipients;
        return this;
    }
    public java.util.List<Recipient> getCcRecipients() {
        return this.ccRecipients;
    }

    public Message setConversationId(java.io.InputStream conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public java.io.InputStream getConversationId() {
        return this.conversationId;
    }

    public Message setFolderId(java.io.InputStream folderId) {
        this.folderId = folderId;
        return this;
    }
    public java.io.InputStream getFolderId() {
        return this.folderId;
    }

    public Message setFrom(Recipient from) {
        this.from = from;
        return this;
    }
    public Recipient getFrom() {
        return this.from;
    }

    public Message setHasAttachments(Boolean hasAttachments) {
        this.hasAttachments = hasAttachments;
        return this;
    }
    public Boolean getHasAttachments() {
        return this.hasAttachments;
    }

    public Message setId(java.io.InputStream id) {
        this.id = id;
        return this;
    }
    public java.io.InputStream getId() {
        return this.id;
    }

    public Message setInternetMessageHeaders(java.util.Map<String, ?> internetMessageHeaders) {
        this.internetMessageHeaders = internetMessageHeaders;
        return this;
    }
    public java.util.Map<String, ?> getInternetMessageHeaders() {
        return this.internetMessageHeaders;
    }

    public Message setInternetMessageId(java.io.InputStream internetMessageId) {
        this.internetMessageId = internetMessageId;
        return this;
    }
    public java.io.InputStream getInternetMessageId() {
        return this.internetMessageId;
    }

    public Message setIsForwarded(Boolean isForwarded) {
        this.isForwarded = isForwarded;
        return this;
    }
    public Boolean getIsForwarded() {
        return this.isForwarded;
    }

    public Message setIsRead(Boolean isRead) {
        this.isRead = isRead;
        return this;
    }
    public Boolean getIsRead() {
        return this.isRead;
    }

    public Message setIsReadReceiptRequested(Boolean isReadReceiptRequested) {
        this.isReadReceiptRequested = isReadReceiptRequested;
        return this;
    }
    public Boolean getIsReadReceiptRequested() {
        return this.isReadReceiptRequested;
    }

    public Message setIsReplied(Boolean isReplied) {
        this.isReplied = isReplied;
        return this;
    }
    public Boolean getIsReplied() {
        return this.isReplied;
    }

    public Message setLastModifiedDateTime(java.io.InputStream lastModifiedDateTime) {
        this.lastModifiedDateTime = lastModifiedDateTime;
        return this;
    }
    public java.io.InputStream getLastModifiedDateTime() {
        return this.lastModifiedDateTime;
    }

    public Message setPriority(java.io.InputStream priority) {
        this.priority = priority;
        return this;
    }
    public java.io.InputStream getPriority() {
        return this.priority;
    }

    public Message setReceivedDateTime(java.io.InputStream receivedDateTime) {
        this.receivedDateTime = receivedDateTime;
        return this;
    }
    public java.io.InputStream getReceivedDateTime() {
        return this.receivedDateTime;
    }

    public Message setReplyTo(Recipient replyTo) {
        this.replyTo = replyTo;
        return this;
    }
    public Recipient getReplyTo() {
        return this.replyTo;
    }

    public Message setSentDateTime(java.io.InputStream sentDateTime) {
        this.sentDateTime = sentDateTime;
        return this;
    }
    public java.io.InputStream getSentDateTime() {
        return this.sentDateTime;
    }

    public Message setSubject(java.io.InputStream subject) {
        this.subject = subject;
        return this;
    }
    public java.io.InputStream getSubject() {
        return this.subject;
    }

    public Message setSummary(java.io.InputStream summary) {
        this.summary = summary;
        return this;
    }
    public java.io.InputStream getSummary() {
        return this.summary;
    }

    public Message setTags(java.util.List<String> tags) {
        this.tags = tags;
        return this;
    }
    public java.util.List<String> getTags() {
        return this.tags;
    }

    public Message setToRecipients(java.util.List<Recipient> toRecipients) {
        this.toRecipients = toRecipients;
        return this;
    }
    public java.util.List<Recipient> getToRecipients() {
        return this.toRecipients;
    }

    public static class MessageBody extends TeaModel {
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

        public static MessageBody build(java.util.Map<String, ?> map) throws Exception {
            MessageBody self = new MessageBody();
            return TeaModel.build(map, self);
        }

        public MessageBody setBodyHtml(java.io.InputStream bodyHtml) {
            this.bodyHtml = bodyHtml;
            return this;
        }
        public java.io.InputStream getBodyHtml() {
            return this.bodyHtml;
        }

        public MessageBody setBodyText(java.io.InputStream bodyText) {
            this.bodyText = bodyText;
            return this;
        }
        public java.io.InputStream getBodyText() {
            return this.bodyText;
        }

    }

}
