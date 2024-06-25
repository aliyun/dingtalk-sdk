// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeAlumniUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeAlumniUserInfoResponseBody body;

    public static UpdateCollegeAlumniUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeAlumniUserInfoResponse self = new UpdateCollegeAlumniUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeAlumniUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeAlumniUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeAlumniUserInfoResponse setBody(UpdateCollegeAlumniUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeAlumniUserInfoResponseBody getBody() {
        return this.body;
    }

}
