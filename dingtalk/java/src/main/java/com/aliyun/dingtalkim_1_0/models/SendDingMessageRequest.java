// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendDingMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;msg_type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello world&quot;}</p>
     */
    @NameInMap("message")
    public String message;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("messageType")
    public String messageType;

    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("receiverId")
    public String receiverId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1745****8777</p>
     */
    @NameInMap("senderId")
    public String senderId;

    public static SendDingMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendDingMessageRequest self = new SendDingMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendDingMessageRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public SendDingMessageRequest setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public SendDingMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public SendDingMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendDingMessageRequest setReceiverId(String receiverId) {
        this.receiverId = receiverId;
        return this;
    }
    public String getReceiverId() {
        return this.receiverId;
    }

    public SendDingMessageRequest setSenderId(String senderId) {
        this.senderId = senderId;
        return this;
    }
    public String getSenderId() {
        return this.senderId;
    }

}
