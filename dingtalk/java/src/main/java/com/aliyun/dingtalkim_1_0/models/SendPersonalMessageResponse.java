// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendPersonalMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendPersonalMessageResponseBody body;

    public static SendPersonalMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendPersonalMessageResponse self = new SendPersonalMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendPersonalMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendPersonalMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendPersonalMessageResponse setBody(SendPersonalMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendPersonalMessageResponseBody getBody() {
        return this.body;
    }

}
