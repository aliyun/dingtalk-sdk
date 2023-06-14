// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class ListActivityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListActivityResponseBody body;

    public static ListActivityResponse build(java.util.Map<String, ?> map) throws Exception {
        ListActivityResponse self = new ListActivityResponse();
        return TeaModel.build(map, self);
    }

    public ListActivityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListActivityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListActivityResponse setBody(ListActivityResponseBody body) {
        this.body = body;
        return this;
    }
    public ListActivityResponseBody getBody() {
        return this.body;
    }

}
