// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentMoblieResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeUpdateStudentMoblieResponseBody body;

    public static CollegeUpdateStudentMoblieResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentMoblieResponse self = new CollegeUpdateStudentMoblieResponse();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentMoblieResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeUpdateStudentMoblieResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeUpdateStudentMoblieResponse setBody(CollegeUpdateStudentMoblieResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentMoblieResponseBody getBody() {
        return this.body;
    }

}
