// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListUncheckedStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeListUncheckedStudentResponseBody body;

    public static CollegeListUncheckedStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeListUncheckedStudentResponse self = new CollegeListUncheckedStudentResponse();
        return TeaModel.build(map, self);
    }

    public CollegeListUncheckedStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeListUncheckedStudentResponse setBody(CollegeListUncheckedStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeListUncheckedStudentResponseBody getBody() {
        return this.body;
    }

}
