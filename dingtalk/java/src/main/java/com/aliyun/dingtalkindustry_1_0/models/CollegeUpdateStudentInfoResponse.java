// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeUpdateStudentInfoResponseBody body;

    public static CollegeUpdateStudentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentInfoResponse self = new CollegeUpdateStudentInfoResponse();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeUpdateStudentInfoResponse setBody(CollegeUpdateStudentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentInfoResponseBody getBody() {
        return this.body;
    }

}
