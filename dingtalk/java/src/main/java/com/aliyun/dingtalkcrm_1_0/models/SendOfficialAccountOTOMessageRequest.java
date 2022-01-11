// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageRequest extends TeaModel {
    // 服务窗帐号ID
    @NameInMap("accountId")
    public String accountId;

    // API调用标识，可选参数
    @NameInMap("bizId")
    public String bizId;

    // 消息详情
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

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
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
        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

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
        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        // 首屏会话透出的展示内容。
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
        // 消息内容，建议500字符以内。
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
        // 卡片消息
        @NameInMap("actionCard")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        // 链接消息类型
        @NameInMap("link")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        // 文本消息体  对于文本类型消息时必填
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
        // 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
        @NameInMap("bizRequestId")
        public String bizRequestId;

        // 消息体
        @NameInMap("messageBody")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        // 全员群发
        @NameInMap("sendToAll")
        public Boolean sendToAll;

        // 消息接收人列表，最多支持1000人
        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        // 消息请求唯一ID
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

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
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
        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

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

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends TeaModel {
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
        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        // 首屏会话透出的展示内容。
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
        // 消息内容，建议500字符以内。
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
        // 卡片消息
        @NameInMap("actionCard")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        // 链接消息类型
        @NameInMap("link")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        // 文本消息体  对于文本类型消息时必填
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
        // 消息体
        @NameInMap("messageBody")
        public SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        // 消息接收人unionId
        @NameInMap("unionId")
        public String unionId;

        // 消息接收人id
        @NameInMap("userId")
        public String userId;

        // 请求唯一 ID
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
