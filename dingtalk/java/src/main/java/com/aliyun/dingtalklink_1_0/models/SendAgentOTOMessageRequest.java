// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public SendAgentOTOMessageRequestDetail detail;

    public static SendAgentOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendAgentOTOMessageRequest self = new SendAgentOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendAgentOTOMessageRequest setDetail(SendAgentOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendAgentOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <strong>example:</strong>
         * <p>查看详情</p>
         */
        @NameInMap("title")
        public String title;

        public static SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList self = new SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyActionCard extends TeaModel {
        @NameInMap("buttonList")
        public java.util.List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        /**
         * <strong>example:</strong>
         * <p><strong>提示信息</strong></p>
         */
        @NameInMap("markdown")
        public String markdown;

        /**
         * <strong>example:</strong>
         * <p>查看详情</p>
         */
        @NameInMap("singleTitle")
        public String singleTitle;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.yourdomain.com">https://www.yourdomain.com</a></p>
         */
        @NameInMap("singleUrl")
        public String singleUrl;

        /**
         * <strong>example:</strong>
         * <p>欢迎使用</p>
         */
        @NameInMap("title")
        public String title;

        public static SendAgentOTOMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyActionCard self = new SendAgentOTOMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyImage extends TeaModel {
        @NameInMap("mediaId")
        public String mediaId;

        public static SendAgentOTOMessageRequestDetailMessageBodyImage build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyImage self = new SendAgentOTOMessageRequestDetailMessageBodyImage();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyImage setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage extends TeaModel {
        @NameInMap("callbackUrl")
        public String callbackUrl;

        @NameInMap("cardBizId")
        public String cardBizId;

        @NameInMap("cardData")
        public String cardData;

        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        public static SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage self = new SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage setCardData(String cardData) {
            this.cardData = cardData;
            return this;
        }
        public String getCardData() {
            return this.cardData;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://www.yourdomain.com">https://www.yourdomain.com</a></p>
         */
        @NameInMap("messageUrl")
        public String messageUrl;

        /**
         * <strong>example:</strong>
         * <p>@1234-456</p>
         */
        @NameInMap("picUrl")
        public String picUrl;

        /**
         * <strong>example:</strong>
         * <p>欢迎使用</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <strong>example:</strong>
         * <p>点击查看</p>
         */
        @NameInMap("title")
        public String title;

        public static SendAgentOTOMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyLink self = new SendAgentOTOMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>欢迎使用。</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <strong>example:</strong>
         * <p>欢迎使用。</p>
         */
        @NameInMap("title")
        public String title;

        public static SendAgentOTOMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyMarkdown self = new SendAgentOTOMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBodyText extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>你好，欢迎使用服务窗。</p>
         */
        @NameInMap("content")
        public String content;

        public static SendAgentOTOMessageRequestDetailMessageBodyText build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBodyText self = new SendAgentOTOMessageRequestDetailMessageBodyText();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBodyText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

    public static class SendAgentOTOMessageRequestDetailMessageBody extends TeaModel {
        @NameInMap("actionCard")
        public SendAgentOTOMessageRequestDetailMessageBodyActionCard actionCard;

        @NameInMap("image")
        public SendAgentOTOMessageRequestDetailMessageBodyImage image;

        @NameInMap("interactiveMessage")
        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage interactiveMessage;

        @NameInMap("link")
        public SendAgentOTOMessageRequestDetailMessageBodyLink link;

        @NameInMap("markdown")
        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown markdown;

        @NameInMap("text")
        public SendAgentOTOMessageRequestDetailMessageBodyText text;

        public static SendAgentOTOMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetailMessageBody self = new SendAgentOTOMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetailMessageBody setActionCard(SendAgentOTOMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

        public SendAgentOTOMessageRequestDetailMessageBody setImage(SendAgentOTOMessageRequestDetailMessageBodyImage image) {
            this.image = image;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyImage getImage() {
            return this.image;
        }

        public SendAgentOTOMessageRequestDetailMessageBody setInteractiveMessage(SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage interactiveMessage) {
            this.interactiveMessage = interactiveMessage;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage getInteractiveMessage() {
            return this.interactiveMessage;
        }

        public SendAgentOTOMessageRequestDetailMessageBody setLink(SendAgentOTOMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public SendAgentOTOMessageRequestDetailMessageBody setMarkdown(SendAgentOTOMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public SendAgentOTOMessageRequestDetailMessageBody setText(SendAgentOTOMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

    }

    public static class SendAgentOTOMessageRequestDetail extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("messageBody")
        public SendAgentOTOMessageRequestDetailMessageBody messageBody;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>text</p>
         */
        @NameInMap("msgType")
        public String msgType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>sid002b6dbb4f963e93e0</p>
         */
        @NameInMap("sessionId")
        public String sessionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user0001</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234-5678-000</p>
         */
        @NameInMap("uuid")
        public String uuid;

        public static SendAgentOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageRequestDetail self = new SendAgentOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageRequestDetail setMessageBody(SendAgentOTOMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public SendAgentOTOMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public SendAgentOTOMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public SendAgentOTOMessageRequestDetail setSessionId(String sessionId) {
            this.sessionId = sessionId;
            return this;
        }
        public String getSessionId() {
            return this.sessionId;
        }

        public SendAgentOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendAgentOTOMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
