// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageRequest extends TeaModel {
    /**
     * <p>消息详情</p>
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
         * <p>使用独立跳转ActionCard样式时的跳转链接。</p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <p>使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。</p>
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
        /**
         * <p>使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。</p>
         */
        @NameInMap("buttonList")
        public java.util.List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        /**
         * <p>按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。</p>
         */
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        /**
         * <p>消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。</p>
         */
        @NameInMap("markdown")
        public String markdown;

        /**
         * <p>使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。</p>
         */
        @NameInMap("singleTitle")
        public String singleTitle;

        /**
         * <p>消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。</p>
         */
        @NameInMap("singleUrl")
        public String singleUrl;

        /**
         * <p>透出到会话列表和通知的文案</p>
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
        /**
         * <p>图片mediaId信息</p>
         */
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
        /**
         * <p>需要回调的互动卡片可通过此参数定义回调地址</p>
         */
        @NameInMap("callbackUrl")
        public String callbackUrl;

        /**
         * <p>卡片ID，由开发者自定义，同一卡片此ID需要保持一致。</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>互动卡片数据，必须是json object 格式</p>
         */
        @NameInMap("cardData")
        public String cardData;

        /**
         * <p>卡片模板ID，可通过互动卡片搭建后台获取。</p>
         */
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
         * <p>消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。</p>
         */
        @NameInMap("messageUrl")
        public String messageUrl;

        /**
         * <p>图片地址</p>
         */
        @NameInMap("picUrl")
        public String picUrl;

        /**
         * <p>消息描述，建议500字符以内。</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <p>消息标题，建议100字符以内。</p>
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
         * <p>markdown格式的消息，建议500字符以内。</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <p>首屏会话透出的展示内容。</p>
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
         * <p>消息内容，建议500字符以内。</p>
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
        /**
         * <p>卡片消息</p>
         */
        @NameInMap("actionCard")
        public SendAgentOTOMessageRequestDetailMessageBodyActionCard actionCard;

        /**
         * <p>图片类型的消息场景使用</p>
         */
        @NameInMap("image")
        public SendAgentOTOMessageRequestDetailMessageBodyImage image;

        @NameInMap("interactiveMessage")
        public SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage interactiveMessage;

        /**
         * <p>链接消息类型</p>
         */
        @NameInMap("link")
        public SendAgentOTOMessageRequestDetailMessageBodyLink link;

        /**
         * <p>markdown消息，仅对消息类型为markdown时有效</p>
         */
        @NameInMap("markdown")
        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown markdown;

        /**
         * <p>文本消息体  对于文本类型消息时必填</p>
         */
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
         * <p>消息体</p>
         */
        @NameInMap("messageBody")
        public SendAgentOTOMessageRequestDetailMessageBody messageBody;

        /**
         * <p>消息类型</p>
         */
        @NameInMap("msgType")
        public String msgType;

        @NameInMap("sessionId")
        public String sessionId;

        /**
         * <p>消息接收人id</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>请求唯一 ID</p>
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
