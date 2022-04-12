// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendDingMessageResponseBody extends TeaModel {
    // 发送消息请求Id
    @NameInMap("requestId")
    public String requestId;

    public static SendDingMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendDingMessageResponseBody self = new SendDingMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendDingMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
