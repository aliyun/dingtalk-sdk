// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendPersonalMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;content&quot;:&quot;月会通知&lt;@all&gt; &quot;,&quot;at&quot;:{&quot;atUserIds&quot;:[],&quot;isAtAll&quot;:true}}</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("msgType")
    public String msgType;

    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>1662055829854977</p>
     */
    @NameInMap("receiverUserId")
    public String receiverUserId;

    public static SendPersonalMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendPersonalMessageRequest self = new SendPersonalMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendPersonalMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendPersonalMessageRequest setMsgType(String msgType) {
        this.msgType = msgType;
        return this;
    }
    public String getMsgType() {
        return this.msgType;
    }

    public SendPersonalMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendPersonalMessageRequest setReceiverUserId(String receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public String getReceiverUserId() {
        return this.receiverUserId;
    }

}
