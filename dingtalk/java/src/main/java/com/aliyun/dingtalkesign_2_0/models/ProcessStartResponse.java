// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ProcessStartResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProcessStartResponseBody body;

    public static ProcessStartResponse build(java.util.Map<String, ?> map) throws Exception {
        ProcessStartResponse self = new ProcessStartResponse();
        return TeaModel.build(map, self);
    }

    public ProcessStartResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProcessStartResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProcessStartResponse setBody(ProcessStartResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessStartResponseBody getBody() {
        return this.body;
    }

}
