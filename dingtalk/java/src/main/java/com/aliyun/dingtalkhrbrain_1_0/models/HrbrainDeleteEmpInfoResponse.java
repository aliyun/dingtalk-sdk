// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteEmpInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteEmpInfoResponseBody body;

    public static HrbrainDeleteEmpInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteEmpInfoResponse self = new HrbrainDeleteEmpInfoResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteEmpInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteEmpInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteEmpInfoResponse setBody(HrbrainDeleteEmpInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteEmpInfoResponseBody getBody() {
        return this.body;
    }

}
