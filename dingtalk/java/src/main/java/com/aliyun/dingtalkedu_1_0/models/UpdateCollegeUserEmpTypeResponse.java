// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeUserEmpTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeUserEmpTypeResponseBody body;

    public static UpdateCollegeUserEmpTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeUserEmpTypeResponse self = new UpdateCollegeUserEmpTypeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeUserEmpTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeUserEmpTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeUserEmpTypeResponse setBody(UpdateCollegeUserEmpTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeUserEmpTypeResponseBody getBody() {
        return this.body;
    }

}
