// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCollegeAlumniUserInfoResponseBody body;

    public static AddCollegeAlumniUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniUserInfoResponse self = new AddCollegeAlumniUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCollegeAlumniUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCollegeAlumniUserInfoResponse setBody(AddCollegeAlumniUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCollegeAlumniUserInfoResponseBody getBody() {
        return this.body;
    }

}
