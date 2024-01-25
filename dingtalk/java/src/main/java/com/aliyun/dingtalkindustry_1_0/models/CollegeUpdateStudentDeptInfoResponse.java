// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CollegeUpdateStudentDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeUpdateStudentDeptInfoResponse setBody(CollegeUpdateStudentDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentDeptInfoResponseBody getBody() {
        return this.body;
    }

}
