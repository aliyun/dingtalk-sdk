// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeRemoveManagerResponseBody body;

    public static CollegeRemoveManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveManagerResponse self = new CollegeRemoveManagerResponse();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeRemoveManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeRemoveManagerResponse setBody(CollegeRemoveManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeRemoveManagerResponseBody getBody() {
        return this.body;
    }

}
