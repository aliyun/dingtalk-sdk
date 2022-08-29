// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageRequest extends TeaModel {
    // 消息详情
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
        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
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
        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        // 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        // 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        @NameInMap("markdown")
        public String markdown;

        // 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        @NameInMap("singleTitle")
        public String singleTitle;

        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        @NameInMap("singleUrl")
        public String singleUrl;

        // 透出到会话列表和通知的文案
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

    public static class SendAgentOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        @NameInMap("messageUrl")
        public String messageUrl;

        // 图片地址
        @NameInMap("picUrl")
        public String picUrl;

        // 消息描述，建议500字符以内。
        @NameInMap("text")
        public String text;

        // 消息标题，建议100字符以内。
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
        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        // 首屏会话透出的展示内容。
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
        // 消息内容，建议500字符以内。
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
        // 卡片消息
        @NameInMap("actionCard")
        public SendAgentOTOMessageRequestDetailMessageBodyActionCard actionCard;

        // 链接消息类型
        @NameInMap("link")
        public SendAgentOTOMessageRequestDetailMessageBodyLink link;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public SendAgentOTOMessageRequestDetailMessageBodyMarkdown markdown;

        // 文本消息体  对于文本类型消息时必填
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
        // 消息体
        @NameInMap("messageBody")
        public SendAgentOTOMessageRequestDetailMessageBody messageBody;

        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        @NameInMap("sessionId")
        public String sessionId;

        // 消息接收人id
        @NameInMap("userId")
        public String userId;

        // 请求唯一 ID
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
