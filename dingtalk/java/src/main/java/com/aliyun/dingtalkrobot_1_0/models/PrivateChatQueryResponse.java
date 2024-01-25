// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public PrivateChatQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PrivateChatQueryResponse setBody(PrivateChatQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public PrivateChatQueryResponseBody getBody() {
        return this.body;
    }

}
