// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CollegeUpdateStudentInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeUpdateStudentInfoResponse setBody(CollegeUpdateStudentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentInfoResponseBody getBody() {
        return this.body;
    }

}
