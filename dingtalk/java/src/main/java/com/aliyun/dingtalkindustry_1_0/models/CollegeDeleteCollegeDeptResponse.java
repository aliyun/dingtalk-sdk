// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeDeleteCollegeDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CollegeDeleteCollegeDeptResponse setBody(CollegeDeleteCollegeDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeDeleteCollegeDeptResponseBody getBody() {
        return this.body;
    }

}
