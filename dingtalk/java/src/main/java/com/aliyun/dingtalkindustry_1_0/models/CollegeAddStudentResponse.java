// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeAddStudentResponseBody body;

    public static CollegeAddStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddStudentResponse self = new CollegeAddStudentResponse();
        return TeaModel.build(map, self);
    }

    public CollegeAddStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeAddStudentResponse setBody(CollegeAddStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeAddStudentResponseBody getBody() {
        return this.body;
    }

}
