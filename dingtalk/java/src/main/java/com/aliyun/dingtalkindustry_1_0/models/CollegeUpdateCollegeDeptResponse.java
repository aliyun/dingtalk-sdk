// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateCollegeDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeUpdateCollegeDeptResponseBody body;

    public static CollegeUpdateCollegeDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateCollegeDeptResponse self = new CollegeUpdateCollegeDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateCollegeDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeUpdateCollegeDeptResponse setBody(CollegeUpdateCollegeDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateCollegeDeptResponseBody getBody() {
        return this.body;
    }

}