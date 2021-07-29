// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class BatchSendRequest extends TeaModel {
    // 发送者，企业员工账号
    @NameInMap("userId")
    public String userId;

    // 接受者列表，外部用户
    @NameInMap("appUids")
    public java.util.List<String> appUids;

    // 消息内容
    @NameInMap("content")
    public String content;

    public static BatchSendRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendRequest self = new BatchSendRequest();
        return TeaModel.build(map, self);
    }

    public BatchSendRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
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

}
