// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountSNSMessageRequest extends TeaModel {
    @NameInMap("bindingToken")
    public String bindingToken;

    // API调用标识，可选参数
    @NameInMap("bizId")
    public String bizId;

    // 消息详情
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
        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
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
        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

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
        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        // 首屏会话透出的展示内容。
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
        // 消息内容，建议500字符以内。
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
        // 卡片消息
        @NameInMap("actionCard")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard actionCard;

        // 链接消息类型
        @NameInMap("link")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyLink link;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown markdown;

        // 文本消息体  对于文本类型消息时必填
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
        // 消息体
        @NameInMap("messageBody")
        public SendOfficialAccountSNSMessageRequestDetailMessageBody messageBody;

        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        // 请求唯一 ID
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
