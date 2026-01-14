// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SendCentralControlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendCentralControlResponseBody body;

    public static SendCentralControlResponse build(java.util.Map<String, ?> map) throws Exception {
        SendCentralControlResponse self = new SendCentralControlResponse();
        return TeaModel.build(map, self);
    }

    public SendCentralControlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendCentralControlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendCentralControlResponse setBody(SendCentralControlResponseBody body) {
        this.body = body;
        return this;
    }
    public SendCentralControlResponseBody getBody() {
        return this.body;
    }

}
