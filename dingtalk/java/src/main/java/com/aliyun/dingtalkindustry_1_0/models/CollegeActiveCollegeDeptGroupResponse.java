// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeActiveCollegeDeptGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeActiveCollegeDeptGroupResponseBody body;

    public static CollegeActiveCollegeDeptGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeActiveCollegeDeptGroupResponse self = new CollegeActiveCollegeDeptGroupResponse();
        return TeaModel.build(map, self);
    }

    public CollegeActiveCollegeDeptGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeActiveCollegeDeptGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeActiveCollegeDeptGroupResponse setBody(CollegeActiveCollegeDeptGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeActiveCollegeDeptGroupResponseBody getBody() {
        return this.body;
    }

}
