// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeUpdateStudentDeptInfoResponseBody body;

    public static CollegeUpdateStudentDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentDeptInfoResponse self = new CollegeUpdateStudentDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeUpdateStudentDeptInfoResponse setBody(CollegeUpdateStudentDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentDeptInfoResponseBody getBody() {
        return this.body;
    }

}