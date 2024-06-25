// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public SendOfficialAccountOTOMessageRequestDetail detail;

    public static SendOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountOTOMessageRequest self = new SendOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountOTOMessageRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public SendOfficialAccountOTOMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendOfficialAccountOTOMessageRequest setDetail(SendOfficialAccountOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendOfficialAccountOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends TeaModel {
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        @NameInMap("markdown")
        public String markdown;

        @NameInMap("singleTitle")
        public String singleTitle;

        @NameInMap("singleUrl")
        public String singleUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyImage extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>@lALPBbCc1XuaP_rNAljNAl</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyImage build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyImage self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyImage();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("messageUrl")
        public String messageUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("picUrl")
        public String picUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyLink self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyText extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyText build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyText self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyText();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBody extends TeaModel {
        @NameInMap("actionCard")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        @NameInMap("image")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage image;

        @NameInMap("link")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        @NameInMap("markdown")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        @NameInMap("text")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyText text;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBody self = new SendOfficialAccountOTOMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setActionCard(SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setImage(SendOfficialAccountOTOMessageRequestDetailMessageBodyImage image) {
            this.image = image;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage getImage() {
            return this.image;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setLink(SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setMarkdown(SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setText(SendOfficialAccountOTOMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetail extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("messageBody")
        public SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>text</p>
         */
        @NameInMap("msgType")
        public String msgType;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uuid")
        public String uuid;

        public static SendOfficialAccountOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetail self = new SendOfficialAccountOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetail setMessageBody(SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public SendOfficialAccountOTOMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public SendOfficialAccountOTOMessageRequestDetail setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public SendOfficialAccountOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendOfficialAccountOTOMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
