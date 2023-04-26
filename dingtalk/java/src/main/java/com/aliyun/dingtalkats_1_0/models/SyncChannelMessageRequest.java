// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncChannelMessageRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("channel")
    public String channel;

    @NameInMap("content")
    public String content;

    @NameInMap("createTime")
    public Long createTime;

    @NameInMap("receiverUserId")
    public String receiverUserId;

    @NameInMap("senderUserId")
    public String senderUserId;

    @NameInMap("uuid")
    public String uuid;

    public static SyncChannelMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncChannelMessageRequest self = new SyncChannelMessageRequest();
        return TeaModel.build(map, self);
    }

    public SyncChannelMessageRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public SyncChannelMessageRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public SyncChannelMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SyncChannelMessageRequest setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public SyncChannelMessageRequest setReceiverUserId(String receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public String getReceiverUserId() {
        return this.receiverUserId;
    }

    public SyncChannelMessageRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

    public SyncChannelMessageRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
