// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCollegeAlumniDeptsResponseBody body;

    public static AddCollegeAlumniDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniDeptsResponse self = new AddCollegeAlumniDeptsResponse();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCollegeAlumniDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCollegeAlumniDeptsResponse setBody(AddCollegeAlumniDeptsResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCollegeAlumniDeptsResponseBody getBody() {
        return this.body;
    }

}
