// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SortUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SortUserResponseBody body;

    public static SortUserResponse build(java.util.Map<String, ?> map) throws Exception {
        SortUserResponse self = new SortUserResponse();
        return TeaModel.build(map, self);
    }

    public SortUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SortUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SortUserResponse setBody(SortUserResponseBody body) {
        this.body = body;
        return this;
    }
    public SortUserResponseBody getBody() {
        return this.body;
    }

}
