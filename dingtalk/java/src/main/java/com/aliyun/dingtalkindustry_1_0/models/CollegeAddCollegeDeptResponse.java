// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddCollegeDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CollegeAddCollegeDeptResponse setBody(CollegeAddCollegeDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeAddCollegeDeptResponseBody getBody() {
        return this.body;
    }

}
