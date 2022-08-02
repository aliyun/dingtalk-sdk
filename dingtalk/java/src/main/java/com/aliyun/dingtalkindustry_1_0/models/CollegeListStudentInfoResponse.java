// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListStudentInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeListStudentInfoResponseBody body;

    public static CollegeListStudentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeListStudentInfoResponse self = new CollegeListStudentInfoResponse();
        return TeaModel.build(map, self);
    }

    public CollegeListStudentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeListStudentInfoResponse setBody(CollegeListStudentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeListStudentInfoResponseBody getBody() {
        return this.body;
    }

}
