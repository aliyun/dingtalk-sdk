// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCollegeAlumniDeptsResponseBody body;

    public static GetCollegeAlumniDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniDeptsResponse self = new GetCollegeAlumniDeptsResponse();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCollegeAlumniDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCollegeAlumniDeptsResponse setBody(GetCollegeAlumniDeptsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCollegeAlumniDeptsResponseBody getBody() {
        return this.body;
    }

}
