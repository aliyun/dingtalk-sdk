// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOfficialAccountOTOMessageRequest extends TeaModel {
    // 消息详情
    @NameInMap("detail")
    public BatchSendOfficialAccountOTOMessageRequestDetail detail;

    // 服务窗授权的调用方标识，可空
    @NameInMap("bizId")
    public String bizId;

    // 服务窗帐号ID
    @NameInMap("accountId")
    public String accountId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static BatchSendOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOfficialAccountOTOMessageRequest self = new BatchSendOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public BatchSendOfficialAccountOTOMessageRequest setDetail(BatchSendOfficialAccountOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public BatchSendOfficialAccountOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public BatchSendOfficialAccountOTOMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public BatchSendOfficialAccountOTOMessageRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public BatchSendOfficialAccountOTOMessageRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
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
