// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListAccountInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListAccountInfoResponseBody body;

    public static ListAccountInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAccountInfoResponse self = new ListAccountInfoResponse();
        return TeaModel.build(map, self);
    }

    public ListAccountInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAccountInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAccountInfoResponse setBody(ListAccountInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAccountInfoResponseBody getBody() {
        return this.body;
    }

}
