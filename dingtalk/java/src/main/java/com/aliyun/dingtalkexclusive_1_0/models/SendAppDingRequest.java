// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendAppDingRequest extends TeaModel {
    /**
     * <p>消息内容</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>接收DING消息的用户列表</p>
     */
    @NameInMap("userids")
    public java.util.List<String> userids;

    public static SendAppDingRequest build(java.util.Map<String, ?> map) throws Exception {
        SendAppDingRequest self = new SendAppDingRequest();
        return TeaModel.build(map, self);
    }

    public SendAppDingRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendAppDingRequest setUserids(java.util.List<String> userids) {
        this.userids = userids;
        return this;
    }
    public java.util.List<String> getUserids() {
        return this.userids;
    }

}
