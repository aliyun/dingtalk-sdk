// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeQueryCollegeDeptGroupInfoResponseBody body;

    public static CollegeQueryCollegeDeptGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptGroupInfoResponse self = new CollegeQueryCollegeDeptGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeQueryCollegeDeptGroupInfoResponse setBody(CollegeQueryCollegeDeptGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryCollegeDeptGroupInfoResponseBody getBody() {
        return this.body;
    }

}
