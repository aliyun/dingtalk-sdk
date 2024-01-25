// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateNewGradeManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ValidateNewGradeManagerResponseBody body;

    public static ValidateNewGradeManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateNewGradeManagerResponse self = new ValidateNewGradeManagerResponse();
        return TeaModel.build(map, self);
    }

    public ValidateNewGradeManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateNewGradeManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateNewGradeManagerResponse setBody(ValidateNewGradeManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateNewGradeManagerResponseBody getBody() {
        return this.body;
    }

}
