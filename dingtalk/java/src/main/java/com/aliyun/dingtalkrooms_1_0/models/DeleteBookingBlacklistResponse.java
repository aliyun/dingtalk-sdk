// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteBookingBlacklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteBookingBlacklistResponseBody body;

    public static DeleteBookingBlacklistResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBookingBlacklistResponse self = new DeleteBookingBlacklistResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBookingBlacklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteBookingBlacklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteBookingBlacklistResponse setBody(DeleteBookingBlacklistResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteBookingBlacklistResponseBody getBody() {
        return this.body;
    }

}
