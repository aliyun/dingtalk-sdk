// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DismissGroupConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DismissGroupConversationResponseBody body;

    public static DismissGroupConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        DismissGroupConversationResponse self = new DismissGroupConversationResponse();
        return TeaModel.build(map, self);
    }

    public DismissGroupConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DismissGroupConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DismissGroupConversationResponse setBody(DismissGroupConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public DismissGroupConversationResponseBody getBody() {
        return this.body;
    }

}
