// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentMoblieResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CollegeUpdateStudentMoblieResponse setBody(CollegeUpdateStudentMoblieResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeUpdateStudentMoblieResponseBody getBody() {
        return this.body;
    }

}
