// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCollegeContactDeptResponseBody body;

    public static CreateCollegeContactDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactDeptResponse self = new CreateCollegeContactDeptResponse();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCollegeContactDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCollegeContactDeptResponse setBody(CreateCollegeContactDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCollegeContactDeptResponseBody getBody() {
        return this.body;
    }

}
