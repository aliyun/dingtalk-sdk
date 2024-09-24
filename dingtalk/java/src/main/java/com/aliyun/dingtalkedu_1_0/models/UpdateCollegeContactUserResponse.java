// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeContactUserResponseBody body;

    public static UpdateCollegeContactUserResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactUserResponse self = new UpdateCollegeContactUserResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeContactUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeContactUserResponse setBody(UpdateCollegeContactUserResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeContactUserResponseBody getBody() {
        return this.body;
    }

}
