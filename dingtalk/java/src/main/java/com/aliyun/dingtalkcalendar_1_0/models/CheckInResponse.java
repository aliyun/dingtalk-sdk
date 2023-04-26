// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CheckInResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CheckInResponseBody body;

    public static CheckInResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckInResponse self = new CheckInResponse();
        return TeaModel.build(map, self);
    }

    public CheckInResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckInResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckInResponse setBody(CheckInResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckInResponseBody getBody() {
        return this.body;
    }

}
