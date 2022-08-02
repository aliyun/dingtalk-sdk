// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByStudentIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CollegeQueryStudentInfoByStudentIdResponse setBody(CollegeQueryStudentInfoByStudentIdResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeQueryStudentInfoByStudentIdResponseBody getBody() {
        return this.body;
    }

}
