// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOfficialAccountOTOMessageRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("detail")
    public BatchSendOfficialAccountOTOMessageRequestDetail detail;

    public static BatchSendOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOfficialAccountOTOMessageRequest self = new BatchSendOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public BatchSendOfficialAccountOTOMessageRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setDetail(BatchSendOfficialAccountOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public BatchSendOfficialAccountOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        @NameInMap("actionUrl")
        public String actionUrl;

        @NameInMap("title")
        public String title;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends TeaModel {
        @NameInMap("buttonList")
        public java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        @NameInMap("markdown")
        public String markdown;

        @NameInMap("singleTitle")
        public String singleTitle;

        @NameInMap("singleUrl")
        public String singleUrl;

        @NameInMap("title")
        public String title;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        @NameInMap("messageUrl")
        public String messageUrl;

        @NameInMap("picUrl")
        public String picUrl;

        @NameInMap("text")
        public String text;

        @NameInMap("title")
        public String title;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        @NameInMap("text")
        public String text;

        @NameInMap("title")
        public String title;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText extends TeaModel {
        @NameInMap("content")
        public String content;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody extends TeaModel {
        @NameInMap("actionCard")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        @NameInMap("link")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        @NameInMap("markdown")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        @NameInMap("text")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText text;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBody self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setActionCard(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setLink(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setMarkdown(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setText(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetail extends TeaModel {
        @NameInMap("bizRequestId")
        public String bizRequestId;

        @NameInMap("messageBody")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        @NameInMap("msgType")
        public String msgType;

        @NameInMap("sendToAll")
        public Boolean sendToAll;

        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        @NameInMap("uuid")
        public String uuid;

        public static BatchSendOfficialAccountOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetail self = new BatchSendOfficialAccountOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setBizRequestId(String bizRequestId) {
            this.bizRequestId = bizRequestId;
            return this;
        }
        public String getBizRequestId() {
            return this.bizRequestId;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setMessageBody(BatchSendOfficialAccountOTOMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setSendToAll(Boolean sendToAll) {
            this.sendToAll = sendToAll;
            return this;
        }
        public Boolean getSendToAll() {
            return this.sendToAll;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
