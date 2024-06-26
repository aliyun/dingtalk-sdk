// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendMessageTipRequest extends TeaModel {
    @NameInMap("defaultView")
    public SendMessageTipRequestDefaultView defaultView;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>msg_f9aae78558b34e20a5badead4c29244c_123</p>
     */
    @NameInMap("messageId")
    public String messageId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidVcYPzxnAySJOMhYX2QDbLwUA==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("privateFieldMap")
    public java.util.Map<String, PrivateFieldMapValue> privateFieldMap;

    @NameInMap("publicField")
    public SendMessageTipRequestPublicField publicField;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiverUserId")
    public java.util.List<String> receiverUserId;

    /**
     * <strong>example:</strong>
     * <p>0808541222161261721</p>
     */
    @NameInMap("senderUserId")
    public String senderUserId;

    public static SendMessageTipRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageTipRequest self = new SendMessageTipRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageTipRequest setDefaultView(SendMessageTipRequestDefaultView defaultView) {
        this.defaultView = defaultView;
        return this;
    }
    public SendMessageTipRequestDefaultView getDefaultView() {
        return this.defaultView;
    }

    public SendMessageTipRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
    public String getMessageId() {
        return this.messageId;
    }

    public SendMessageTipRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendMessageTipRequest setPrivateFieldMap(java.util.Map<String, PrivateFieldMapValue> privateFieldMap) {
        this.privateFieldMap = privateFieldMap;
        return this;
    }
    public java.util.Map<String, PrivateFieldMapValue> getPrivateFieldMap() {
        return this.privateFieldMap;
    }

    public SendMessageTipRequest setPublicField(SendMessageTipRequestPublicField publicField) {
        this.publicField = publicField;
        return this;
    }
    public SendMessageTipRequestPublicField getPublicField() {
        return this.publicField;
    }

    public SendMessageTipRequest setReceiverUserId(java.util.List<String> receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public java.util.List<String> getReceiverUserId() {
        return this.receiverUserId;
    }

    public SendMessageTipRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

    public static class SendMessageTipRequestDefaultView extends TeaModel {
        @NameInMap("actionName")
        public String actionName;

        @NameInMap("actionUrl")
        public String actionUrl;

        @NameInMap("authCode")
        public String authCode;

        @NameInMap("authMediaId")
        public String authMediaId;

        /**
         * <strong>example:</strong>
         * <p>闪读消息卡片1</p>
         */
        @NameInMap("cardTitle")
        public String cardTitle;

        @NameInMap("cardTitleColor")
        public String cardTitleColor;

        /**
         * <strong>example:</strong>
         * <p>查看详情</p>
         */
        @NameInMap("desc")
        public String desc;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("needShowUpdateTail")
        public String needShowUpdateTail;

        @NameInMap("summary")
        public String summary;

        /**
         * <strong>example:</strong>
         * <p>闪读消息卡片2</p>
         */
        @NameInMap("title")
        public String title;

        public static SendMessageTipRequestDefaultView build(java.util.Map<String, ?> map) throws Exception {
            SendMessageTipRequestDefaultView self = new SendMessageTipRequestDefaultView();
            return TeaModel.build(map, self);
        }

        public SendMessageTipRequestDefaultView setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public SendMessageTipRequestDefaultView setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public SendMessageTipRequestDefaultView setAuthCode(String authCode) {
            this.authCode = authCode;
            return this;
        }
        public String getAuthCode() {
            return this.authCode;
        }

        public SendMessageTipRequestDefaultView setAuthMediaId(String authMediaId) {
            this.authMediaId = authMediaId;
            return this;
        }
        public String getAuthMediaId() {
            return this.authMediaId;
        }

        public SendMessageTipRequestDefaultView setCardTitle(String cardTitle) {
            this.cardTitle = cardTitle;
            return this;
        }
        public String getCardTitle() {
            return this.cardTitle;
        }

        public SendMessageTipRequestDefaultView setCardTitleColor(String cardTitleColor) {
            this.cardTitleColor = cardTitleColor;
            return this;
        }
        public String getCardTitleColor() {
            return this.cardTitleColor;
        }

        public SendMessageTipRequestDefaultView setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public SendMessageTipRequestDefaultView setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public SendMessageTipRequestDefaultView setNeedShowUpdateTail(String needShowUpdateTail) {
            this.needShowUpdateTail = needShowUpdateTail;
            return this;
        }
        public String getNeedShowUpdateTail() {
            return this.needShowUpdateTail;
        }

        public SendMessageTipRequestDefaultView setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public SendMessageTipRequestDefaultView setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMessageTipRequestPublicField extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dingtalk://dingtalkclient/page/link33</p>
         */
        @NameInMap("detailUrl")
        public String detailUrl;

        /**
         * <strong>example:</strong>
         * <p>限时阅读5分钟</p>
         */
        @NameInMap("durationDesc")
        public String durationDesc;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        @NameInMap("isExpired")
        public Boolean isExpired;

        /**
         * <strong>example:</strong>
         * <p>dingtalk://dingtalkclient/page/linkxx</p>
         */
        @NameInMap("readActionUrl")
        public String readActionUrl;

        /**
         * <strong>example:</strong>
         * <p>已查收 0/1</p>
         */
        @NameInMap("readProgressDesc")
        public String readProgressDesc;

        public static SendMessageTipRequestPublicField build(java.util.Map<String, ?> map) throws Exception {
            SendMessageTipRequestPublicField self = new SendMessageTipRequestPublicField();
            return TeaModel.build(map, self);
        }

        public SendMessageTipRequestPublicField setDetailUrl(String detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public String getDetailUrl() {
            return this.detailUrl;
        }

        public SendMessageTipRequestPublicField setDurationDesc(String durationDesc) {
            this.durationDesc = durationDesc;
            return this;
        }
        public String getDurationDesc() {
            return this.durationDesc;
        }

        public SendMessageTipRequestPublicField setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public SendMessageTipRequestPublicField setIsExpired(Boolean isExpired) {
            this.isExpired = isExpired;
            return this;
        }
        public Boolean getIsExpired() {
            return this.isExpired;
        }

        public SendMessageTipRequestPublicField setReadActionUrl(String readActionUrl) {
            this.readActionUrl = readActionUrl;
            return this;
        }
        public String getReadActionUrl() {
            return this.readActionUrl;
        }

        public SendMessageTipRequestPublicField setReadProgressDesc(String readProgressDesc) {
            this.readProgressDesc = readProgressDesc;
            return this;
        }
        public String getReadProgressDesc() {
            return this.readProgressDesc;
        }

    }

}
