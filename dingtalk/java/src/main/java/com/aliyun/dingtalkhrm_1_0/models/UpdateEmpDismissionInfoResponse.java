// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpDismissionInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateEmpDismissionInfoResponseBody body;

    public static UpdateEmpDismissionInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpDismissionInfoResponse self = new UpdateEmpDismissionInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateEmpDismissionInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateEmpDismissionInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateEmpDismissionInfoResponse setBody(UpdateEmpDismissionInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateEmpDismissionInfoResponseBody getBody() {
        return this.body;
    }

}
