// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeNotifyRequest extends TeaModel {
    // 通知内容
    @NameInMap("content")
    public String content;

    // 消息ID
    @NameInMap("msgId")
    public String msgId;

    // 消息类型
    @NameInMap("msgType")
    public String msgType;

    // 员工ID
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
