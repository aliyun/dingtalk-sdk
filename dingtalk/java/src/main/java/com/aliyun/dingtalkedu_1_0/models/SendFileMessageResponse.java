// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendFileMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendFileMessageResponseBody body;

    public static SendFileMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendFileMessageResponse self = new SendFileMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendFileMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendFileMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendFileMessageResponse setBody(SendFileMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendFileMessageResponseBody getBody() {
        return this.body;
    }

}
