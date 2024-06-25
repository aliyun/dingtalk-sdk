// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCollegeAlumniUserInfoResponseBody body;

    public static GetCollegeAlumniUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniUserInfoResponse self = new GetCollegeAlumniUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCollegeAlumniUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCollegeAlumniUserInfoResponse setBody(GetCollegeAlumniUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCollegeAlumniUserInfoResponseBody getBody() {
        return this.body;
    }

}
