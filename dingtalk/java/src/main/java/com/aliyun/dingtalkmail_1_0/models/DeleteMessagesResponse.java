// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DeleteMessagesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMessagesResponseBody body;

    public static DeleteMessagesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMessagesResponse self = new DeleteMessagesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMessagesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMessagesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMessagesResponse setBody(DeleteMessagesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMessagesResponseBody getBody() {
        return this.body;
    }

}
