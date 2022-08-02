// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeRemoveStudentResponseBody body;

    public static CollegeRemoveStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveStudentResponse self = new CollegeRemoveStudentResponse();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeRemoveStudentResponse setBody(CollegeRemoveStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeRemoveStudentResponseBody getBody() {
        return this.body;
    }

}
