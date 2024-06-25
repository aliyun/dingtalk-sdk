// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCollegeAlumniUserInfoResponseBody body;

    public static DeleteCollegeAlumniUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniUserInfoResponse self = new DeleteCollegeAlumniUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCollegeAlumniUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCollegeAlumniUserInfoResponse setBody(DeleteCollegeAlumniUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCollegeAlumniUserInfoResponseBody getBody() {
        return this.body;
    }

}
