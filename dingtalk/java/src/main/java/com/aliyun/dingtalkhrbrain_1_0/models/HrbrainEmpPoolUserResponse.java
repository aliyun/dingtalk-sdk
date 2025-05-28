// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainEmpPoolUserResponseBody body;

    public static HrbrainEmpPoolUserResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolUserResponse self = new HrbrainEmpPoolUserResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainEmpPoolUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainEmpPoolUserResponse setBody(HrbrainEmpPoolUserResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainEmpPoolUserResponseBody getBody() {
        return this.body;
    }

}
