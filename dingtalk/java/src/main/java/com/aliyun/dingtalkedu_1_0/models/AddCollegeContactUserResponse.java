// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeContactUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCollegeContactUserResponseBody body;

    public static AddCollegeContactUserResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeContactUserResponse self = new AddCollegeContactUserResponse();
        return TeaModel.build(map, self);
    }

    public AddCollegeContactUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCollegeContactUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCollegeContactUserResponse setBody(AddCollegeContactUserResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCollegeContactUserResponseBody getBody() {
        return this.body;
    }

}
