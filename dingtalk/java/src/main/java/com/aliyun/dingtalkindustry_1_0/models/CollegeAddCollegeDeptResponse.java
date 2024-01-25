// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddCollegeDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeAddCollegeDeptResponseBody body;

    public static CollegeAddCollegeDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddCollegeDeptResponse self = new CollegeAddCollegeDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeAddCollegeDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeAddCollegeDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeAddCollegeDeptResponse setBody(CollegeAddCollegeDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeAddCollegeDeptResponseBody getBody() {
        return this.body;
    }

}
