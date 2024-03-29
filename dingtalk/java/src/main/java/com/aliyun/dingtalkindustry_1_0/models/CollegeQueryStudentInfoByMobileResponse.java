// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByMobileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeQueryStudentInfoByMobileResponseBody body;

    public static CollegeQueryStudentInfoByMobileResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByMobileResponse self = new CollegeQueryStudentInfoByMobileResponse();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByMobileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeQueryStudentInfoByMobileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeQueryStudentInfoByMobileResponse setBody(CollegeQueryStudentInfoByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryStudentInfoByMobileResponseBody getBody() {
        return this.body;
    }

}
