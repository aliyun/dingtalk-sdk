// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCollegeAlumniDeptResponseBody body;

    public static DeleteCollegeAlumniDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniDeptResponse self = new DeleteCollegeAlumniDeptResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCollegeAlumniDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCollegeAlumniDeptResponse setBody(DeleteCollegeAlumniDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCollegeAlumniDeptResponseBody getBody() {
        return this.body;
    }

}
