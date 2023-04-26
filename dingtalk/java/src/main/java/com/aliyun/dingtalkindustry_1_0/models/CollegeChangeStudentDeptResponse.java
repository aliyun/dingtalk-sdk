// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeChangeStudentDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeChangeStudentDeptResponseBody body;

    public static CollegeChangeStudentDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeChangeStudentDeptResponse self = new CollegeChangeStudentDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeChangeStudentDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeChangeStudentDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeChangeStudentDeptResponse setBody(CollegeChangeStudentDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeChangeStudentDeptResponseBody getBody() {
        return this.body;
    }

}
