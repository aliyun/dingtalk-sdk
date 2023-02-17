// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatQueryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PrivateChatQueryResponseBody body;

    public static PrivateChatQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatQueryResponse self = new PrivateChatQueryResponse();
        return TeaModel.build(map, self);
    }

    public PrivateChatQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PrivateChatQueryResponse setBody(PrivateChatQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public PrivateChatQueryResponseBody getBody() {
        return this.body;
    }

}
