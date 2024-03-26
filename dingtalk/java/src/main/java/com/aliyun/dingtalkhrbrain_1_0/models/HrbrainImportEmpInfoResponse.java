// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportEmpInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportEmpInfoResponseBody body;

    public static HrbrainImportEmpInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportEmpInfoResponse self = new HrbrainImportEmpInfoResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportEmpInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportEmpInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportEmpInfoResponse setBody(HrbrainImportEmpInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportEmpInfoResponseBody getBody() {
        return this.body;
    }

}
