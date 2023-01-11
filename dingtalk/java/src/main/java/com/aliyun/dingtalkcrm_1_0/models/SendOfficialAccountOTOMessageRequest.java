// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageRequest extends TeaModel {
    /**
     * <p>服务窗帐号ID</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>API调用标识，可选参数</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>消息详情</p>
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
         * <p>使用独立跳转ActionCard样式时的跳转链接。</p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <p>使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。</p>
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
        /**
         * <p>使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。</p>
         */
        @NameInMap("buttonList")
        public java.util.List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> buttonList;

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
         * <p>图片mediaId，可以通过上传媒体文件接口上传图片获取mediaId。</p>
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
         * <p>markdown格式的消息，建议500字符以内。</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <p>首屏会话透出的展示内容。</p>
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
         * <p>消息内容，建议500字符以内。</p>
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
        /**
         * <p>卡片消息</p>
         */
        @NameInMap("actionCard")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard actionCard;

        /**
         * <p>图片消息类型时，此参数必填。 设置此参数时，msgType必须为image类型</p>
         */
        @NameInMap("image")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage image;

        /**
         * <p>链接消息类型</p>
         */
        @NameInMap("link")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink link;

        /**
         * <p>markdown消息，仅对消息类型为markdown时有效</p>
         */
        @NameInMap("markdown")
        public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown markdown;

        /**
         * <p>文本消息体  对于文本类型消息时必填</p>
         */
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
         * <p>消息体</p>
         */
        @NameInMap("messageBody")
        public SendOfficialAccountOTOMessageRequestDetailMessageBody messageBody;

        /**
         * <p>消息类型</p>
         */
        @NameInMap("msgType")
        public String msgType;

        /**
         * <p>消息接收人unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

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
