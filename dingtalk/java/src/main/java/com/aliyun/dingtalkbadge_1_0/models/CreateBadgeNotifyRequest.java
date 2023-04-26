// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeNotifyRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("msgId")
    public String msgId;

    @NameInMap("msgType")
    public String msgType;

    @NameInMap("userId")
    public String userId;

    public static CreateBadgeNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeNotifyRequest self = new CreateBadgeNotifyRequest();
        return TeaModel.build(map, self);
    }

    public CreateBadgeNotifyRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateBadgeNotifyRequest setMsgId(String msgId) {
        this.msgId = msgId;
        return this;
    }
    public String getMsgId() {
        return this.msgId;
    }

    public CreateBadgeNotifyRequest setMsgType(String msgType) {
        this.msgType = msgType;
        return this;
    }
    public String getMsgType() {
        return this.msgType;
    }

    public CreateBadgeNotifyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
