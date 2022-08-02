// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListCollegeSubDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollegeListCollegeSubDeptResponseBody body;

    public static CollegeListCollegeSubDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeListCollegeSubDeptResponse self = new CollegeListCollegeSubDeptResponse();
        return TeaModel.build(map, self);
    }

    public CollegeListCollegeSubDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeListCollegeSubDeptResponse setBody(CollegeListCollegeSubDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeListCollegeSubDeptResponseBody getBody() {
        return this.body;
    }

}
