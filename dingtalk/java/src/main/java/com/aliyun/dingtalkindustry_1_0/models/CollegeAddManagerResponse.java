// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddManagerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeAddManagerResponseBody body;

    public static CollegeAddManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddManagerResponse self = new CollegeAddManagerResponse();
        return TeaModel.build(map, self);
    }

    public CollegeAddManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeAddManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeAddManagerResponse setBody(CollegeAddManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeAddManagerResponseBody getBody() {
        return this.body;
    }

}
