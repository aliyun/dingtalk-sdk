// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class GetMessageResponseBody extends TeaModel {
    @NameInMap("message")
    public Message message;

    @NameInMap("requestId")
    public String requestId;

    public static GetMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMessageResponseBody self = new GetMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMessageResponseBody setMessage(Message message) {
        this.message = message;
        return this;
    }
    public Message getMessage() {
        return this.message;
    }

    public GetMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
