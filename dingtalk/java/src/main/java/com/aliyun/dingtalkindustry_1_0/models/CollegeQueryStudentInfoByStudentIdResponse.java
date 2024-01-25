// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByStudentIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeQueryStudentInfoByStudentIdResponseBody body;

    public static CollegeQueryStudentInfoByStudentIdResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByStudentIdResponse self = new CollegeQueryStudentInfoByStudentIdResponse();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByStudentIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeQueryStudentInfoByStudentIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeQueryStudentInfoByStudentIdResponse setBody(CollegeQueryStudentInfoByStudentIdResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryStudentInfoByStudentIdResponseBody getBody() {
        return this.body;
    }

}
