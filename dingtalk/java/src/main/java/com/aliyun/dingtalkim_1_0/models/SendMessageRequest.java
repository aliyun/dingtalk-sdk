// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
    /**
     * <p>消息内容</p>
     */
    @NameInMap("message")
    public String message;

    /**
     * <p>消息类型</p>
     */
    @NameInMap("messageType")
    public String messageType;

    /**
     * <p>群会话Id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>B端客服钉钉Id</p>
     */
    @NameInMap("receiverId")
    public String receiverId;

    /**
     * <p>C端客户appUserId</p>
     */
    @NameInMap("senderId")
    public String senderId;

    /**
     * <p>渠道按钮跳转信息</p>
     */
    @NameInMap("sourceInfos")
    public java.util.Map<String, ?> sourceInfos;

    public static SendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageRequest self = new SendMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageRequest setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public SendMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public SendMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendMessageRequest setReceiverId(String receiverId) {
        this.receiverId = receiverId;
        return this;
    }
    public String getReceiverId() {
        return this.receiverId;
    }

    public SendMessageRequest setSenderId(String senderId) {
        this.senderId = senderId;
        return this;
    }
    public String getSenderId() {
        return this.senderId;
    }

    public SendMessageRequest setSourceInfos(java.util.Map<String, ?> sourceInfos) {
        this.sourceInfos = sourceInfos;
        return this;
    }
    public java.util.Map<String, ?> getSourceInfos() {
        return this.sourceInfos;
    }

}
