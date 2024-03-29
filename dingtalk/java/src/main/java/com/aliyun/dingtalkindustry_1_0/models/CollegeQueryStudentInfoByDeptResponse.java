// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeQueryStudentInfoByDeptResponseBody body;

    public static CollegeQueryStudentInfoByDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByDeptResponse self = new CollegeQueryStudentInfoByDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeQueryStudentInfoByDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeQueryStudentInfoByDeptResponse setBody(CollegeQueryStudentInfoByDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryStudentInfoByDeptResponseBody getBody() {
        return this.body;
    }

}
