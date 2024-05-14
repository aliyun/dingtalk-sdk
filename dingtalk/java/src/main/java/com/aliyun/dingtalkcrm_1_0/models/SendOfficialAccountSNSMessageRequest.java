// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountSNSMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bindingToken")
    public String bindingToken;

    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public SendOfficialAccountSNSMessageRequestDetail detail;

    public static SendOfficialAccountSNSMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountSNSMessageRequest self = new SendOfficialAccountSNSMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountSNSMessageRequest setBindingToken(String bindingToken) {
        this.bindingToken = bindingToken;
        return this;
    }
    public String getBindingToken() {
        return this.bindingToken;
    }

    public SendOfficialAccountSNSMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendOfficialAccountSNSMessageRequest setDetail(SendOfficialAccountSNSMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendOfficialAccountSNSMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        @NameInMap("actionUrl")
        public String actionUrl;

        @NameInMap("title")
        public String title;

        public static SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList self = new SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard extends TeaModel {
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

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

        public static SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard self = new SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBodyLink extends TeaModel {
        @NameInMap("messageUrl")
        public String messageUrl;

        @NameInMap("picUrl")
        public String picUrl;

        @NameInMap("text")
        public String text;

        @NameInMap("title")
        public String title;

        public static SendOfficialAccountSNSMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBodyLink self = new SendOfficialAccountSNSMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        @NameInMap("text")
        public String text;

        @NameInMap("title")
        public String title;

        public static SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown self = new SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBodyText extends TeaModel {
        @NameInMap("content")
        public String content;

        public static SendOfficialAccountSNSMessageRequestDetailMessageBodyText build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBodyText self = new SendOfficialAccountSNSMessageRequestDetailMessageBodyText();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBodyText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetailMessageBody extends TeaModel {
        @NameInMap("actionCard")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard actionCard;

        @NameInMap("link")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink link;

        @NameInMap("markdown")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown markdown;

        @NameInMap("text")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyText text;

        public static SendOfficialAccountSNSMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetailMessageBody self = new SendOfficialAccountSNSMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBody setActionCard(SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBody setLink(SendOfficialAccountSNSMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBody setMarkdown(SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountSNSMessageRequestDetailMessageBody setText(SendOfficialAccountSNSMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

    }

    public static class SendOfficialAccountSNSMessageRequestDetail extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("messageBody")
        public SendOfficialAccountSNSMessageRequestDetailMessageBody messageBody;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("msgType")
        public String msgType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uuid")
        public String uuid;

        public static SendOfficialAccountSNSMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageRequestDetail self = new SendOfficialAccountSNSMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageRequestDetail setMessageBody(SendOfficialAccountSNSMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public SendOfficialAccountSNSMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public SendOfficialAccountSNSMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public SendOfficialAccountSNSMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
