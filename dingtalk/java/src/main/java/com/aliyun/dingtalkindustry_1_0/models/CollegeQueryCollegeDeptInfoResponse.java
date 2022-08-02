// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeQueryCollegeDeptInfoResponseBody body;

    public static CollegeQueryCollegeDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptInfoResponse self = new CollegeQueryCollegeDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeQueryCollegeDeptInfoResponse setBody(CollegeQueryCollegeDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryCollegeDeptInfoResponseBody getBody() {
        return this.body;
    }

}
