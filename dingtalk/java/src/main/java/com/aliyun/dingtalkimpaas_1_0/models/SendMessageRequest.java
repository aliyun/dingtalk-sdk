// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
    @NameInMap("senderUid")
    public String senderUid;

    @NameInMap("receiverUid")
    public String receiverUid;

    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("content")
    public String content;

    @NameInMap("uuid")
    public String uuid;

    @NameInMap("createTime")
    public Long createTime;

    public static SendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageRequest self = new SendMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageRequest setSenderUid(String senderUid) {
        this.senderUid = senderUid;
        return this;
    }
    public String getSenderUid() {
        return this.senderUid;
    }

    public SendMessageRequest setReceiverUid(String receiverUid) {
        this.receiverUid = receiverUid;
        return this;
    }
    public String getReceiverUid() {
        return this.receiverUid;
    }

    public SendMessageRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public SendMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendMessageRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public SendMessageRequest setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

}
