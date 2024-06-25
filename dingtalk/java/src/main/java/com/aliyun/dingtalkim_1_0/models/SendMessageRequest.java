// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
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
     * <p>1745****8777</p>
     */
    @NameInMap("receiverId")
    public String receiverId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("senderId")
    public String senderId;

    /**
     * <strong>example:</strong>
     * <p>{     &quot;9d801647a64<strong><strong><strong>59c9da0207&quot;:&quot;[{&quot;action_url&quot;:&quot;<a href="http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%80%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D,%7B%5C%22action_url%5C%22:%5C%22http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%A4%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D%5D">http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;一个按钮\&quot;},{\&quot;action_url\&quot;:\&quot;http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;两个按钮\&quot;}]</a>&quot;,     &quot;9d801647a6</strong></strong></strong>59c9da020342&quot;:&quot;[{&quot;action_url&quot;:&quot;<a href="http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%80%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D,%7B%5C%22action_url%5C%22:%5C%22http://www.baidu.com%5C%22,%5C%22title%5C%22:%5C%22%E4%B8%A4%E4%B8%AA%E6%8C%89%E9%92%AE%5C%22%7D%5D">http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;一个按钮\&quot;},{\&quot;action_url\&quot;:\&quot;http://www.baidu.com\&quot;,\&quot;title\&quot;:\&quot;两个按钮\&quot;}]</a>&quot; }</p>
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
