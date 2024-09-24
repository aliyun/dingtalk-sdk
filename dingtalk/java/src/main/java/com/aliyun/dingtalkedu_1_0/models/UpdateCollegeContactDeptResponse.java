// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeContactDeptResponseBody body;

    public static UpdateCollegeContactDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactDeptResponse self = new UpdateCollegeContactDeptResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeContactDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeContactDeptResponse setBody(UpdateCollegeContactDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeContactDeptResponseBody getBody() {
        return this.body;
    }

}
