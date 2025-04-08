// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMessageResponseBody extends TeaModel {
    @NameInMap("message")
    public Message message;

    @NameInMap("requestId")
    public String requestId;

    public static UpdateMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMessageResponseBody self = new UpdateMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMessageResponseBody setMessage(Message message) {
        this.message = message;
        return this;
    }
    public Message getMessage() {
        return this.message;
    }

    public UpdateMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
