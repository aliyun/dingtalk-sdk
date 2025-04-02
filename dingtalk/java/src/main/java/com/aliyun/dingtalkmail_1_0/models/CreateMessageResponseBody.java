// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateMessageResponseBody extends TeaModel {
    @NameInMap("message")
    public Message message;

    @NameInMap("requestId")
    public String requestId;

    public static CreateMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMessageResponseBody self = new CreateMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMessageResponseBody setMessage(Message message) {
        this.message = message;
        return this;
    }
    public Message getMessage() {
        return this.message;
    }

    public CreateMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
