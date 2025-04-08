// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMessageResponseBody body;

    public static UpdateMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMessageResponse self = new UpdateMessageResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMessageResponse setBody(UpdateMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMessageResponseBody getBody() {
        return this.body;
    }

}
