// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateBookingBlacklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateBookingBlacklistResponseBody body;

    public static CreateBookingBlacklistResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateBookingBlacklistResponse self = new CreateBookingBlacklistResponse();
        return TeaModel.build(map, self);
    }

    public CreateBookingBlacklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateBookingBlacklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateBookingBlacklistResponse setBody(CreateBookingBlacklistResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBookingBlacklistResponseBody getBody() {
        return this.body;
    }

}
