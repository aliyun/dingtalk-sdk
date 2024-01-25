// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeDeleteCollegeDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeDeleteCollegeDeptResponseBody body;

    public static CollegeDeleteCollegeDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeDeleteCollegeDeptResponse self = new CollegeDeleteCollegeDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeDeleteCollegeDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeDeleteCollegeDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeDeleteCollegeDeptResponse setBody(CollegeDeleteCollegeDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeDeleteCollegeDeptResponseBody getBody() {
        return this.body;
    }

}
