// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageRequest extends TeaModel {
    // 消息详情
    @NameInMap("detail")
    public SendOfficialAccountOTOMessageRequestDetail detail;

    // API调用标识，可选参数
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static SendOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountOTOMessageRequest self = new SendOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountOTOMessageRequest setDetail(SendOfficialAccountOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendOfficialAccountOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public SendOfficialAccountOTOMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendOfficialAccountOTOMessageRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public SendOfficialAccountOTOMessageRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public SendOfficialAccountOTOMessageRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SendOfficialAccountOTOMessageRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
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

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        // 首屏会话透出的展示内容。
        @NameInMap("title")
        public String title;

        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        // 图片地址
        @NameInMap("picUrl")
        public String picUrl;

        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        @NameInMap("messageUrl")
        public String messageUrl;

        // 消息标题，建议100字符以内。
        @NameInMap("title")
        public String title;

        // 消息描述，建议500字符以内。
        @NameInMap("text")
        public String text;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyLink self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
        @NameInMap("title")
        public String title;

        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends TeaModel {
        // 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        @NameInMap("singleUrl")
        public String singleUrl;

        // 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        @NameInMap("singleTitle")
        public String singleTitle;

        // 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        @NameInMap("markdown")
        public String markdown;

        // 透出到会话列表和通知的文案
        @NameInMap("title")
        public String title;

        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard self = new SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetailMessageBody extends TeaModel {
        // 文本消息体  对于文本类型消息时必填
        @NameInMap("text")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyText text;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        // 链接消息类型
        @NameInMap("link")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        // 卡片消息
        @NameInMap("actionCard")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        public static SendOfficialAccountOTOMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetailMessageBody self = new SendOfficialAccountOTOMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setText(SendOfficialAccountOTOMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setMarkdown(SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setLink(SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public SendOfficialAccountOTOMessageRequestDetailMessageBody setActionCard(SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

    }

    public static class SendOfficialAccountOTOMessageRequestDetail extends TeaModel {
        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        // 请求唯一 ID
        @NameInMap("uuid")
        public String uuid;

        // 消息接收人id
        @NameInMap("userId")
        public String userId;

        // 消息体
        @NameInMap("messageBody")
        public SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        public static SendOfficialAccountOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageRequestDetail self = new SendOfficialAccountOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public SendOfficialAccountOTOMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public SendOfficialAccountOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendOfficialAccountOTOMessageRequestDetail setMessageBody(SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public SendOfficialAccountOTOMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
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

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends TeaModel {
        // 首屏会话透出的展示内容。
        @NameInMap("title")
        public String title;

        // markdown格式的消息，建议500字符以内。
        @NameInMap("text")
        public String text;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends TeaModel {
        // 图片地址
        @NameInMap("picUrl")
        public String picUrl;

        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        @NameInMap("messageUrl")
        public String messageUrl;

        // 消息标题，建议100字符以内。
        @NameInMap("title")
        public String title;

        // 消息描述，建议500字符以内。
        @NameInMap("text")
        public String text;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        // 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
        @NameInMap("title")
        public String title;

        // 使用独立跳转ActionCard样式时的跳转链接。
        @NameInMap("actionUrl")
        public String actionUrl;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends TeaModel {
        // 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        // 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        @NameInMap("singleUrl")
        public String singleUrl;

        // 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        @NameInMap("singleTitle")
        public String singleTitle;

        // 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        @NameInMap("markdown")
        public String markdown;

        // 透出到会话列表和通知的文案
        @NameInMap("title")
        public String title;

        // 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        @NameInMap("buttonList")
        public java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard setButtonList(java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody extends TeaModel {
        // 文本消息体  对于文本类型消息时必填
        @NameInMap("text")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText text;

        // markdown消息，仅对消息类型为markdown时有效
        @NameInMap("markdown")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        // 链接消息类型
        @NameInMap("link")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        // 卡片消息
        @NameInMap("actionCard")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        public static BatchSendOfficialAccountOTOMessageRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetailMessageBody self = new BatchSendOfficialAccountOTOMessageRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setText(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText getText() {
            return this.text;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setMarkdown(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setLink(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody setActionCard(BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

    }

    public static class BatchSendOfficialAccountOTOMessageRequestDetail extends TeaModel {
        // 消息类型
        @NameInMap("msgType")
        public String msgType;

        // 消息请求唯一ID
        @NameInMap("uuid")
        public String uuid;

        // 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
        @NameInMap("bizRequestId")
        public String bizRequestId;

        // 消息接收人列表，最多支持1000人
        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        // 消息体
        @NameInMap("messageBody")
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        // 全员群发
        @NameInMap("sendToAll")
        public Boolean sendToAll;

        public static BatchSendOfficialAccountOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageRequestDetail self = new BatchSendOfficialAccountOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setBizRequestId(String bizRequestId) {
            this.bizRequestId = bizRequestId;
            return this;
        }
        public String getBizRequestId() {
            return this.bizRequestId;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setMessageBody(BatchSendOfficialAccountOTOMessageRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public BatchSendOfficialAccountOTOMessageRequestDetail setSendToAll(Boolean sendToAll) {
            this.sendToAll = sendToAll;
            return this;
        }
        public Boolean getSendToAll() {
            return this.sendToAll;
        }

    }

}
