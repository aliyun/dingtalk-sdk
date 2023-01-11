// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class BatchSendRequest extends TeaModel {
    /**
     * <p>接受者列表，外部用户</p>
     */
    @NameInMap("appUids")
    public java.util.List<String> appUids;

    /**
     * <p>消息内容</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>接收消息的群聊列表</p>
     */
    @NameInMap("conversationIds")
    public java.util.List<String> conversationIds;

    /**
     * <p>发送者，企业员工账号</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchSendRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendRequest self = new BatchSendRequest();
        return TeaModel.build(map, self);
    }

    public BatchSendRequest setAppUids(java.util.List<String> appUids) {
        this.appUids = appUids;
        return this;
    }
    public java.util.List<String> getAppUids() {
        return this.appUids;
    }

    public BatchSendRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public BatchSendRequest setConversationIds(java.util.List<String> conversationIds) {
        this.conversationIds = conversationIds;
        return this;
    }
    public java.util.List<String> getConversationIds() {
        return this.conversationIds;
    }

    public BatchSendRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
