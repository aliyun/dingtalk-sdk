// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EmpStartDismissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EmpStartDismissionResponseBody body;

    public static EmpStartDismissionResponse build(java.util.Map<String, ?> map) throws Exception {
        EmpStartDismissionResponse self = new EmpStartDismissionResponse();
        return TeaModel.build(map, self);
    }

    public EmpStartDismissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EmpStartDismissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EmpStartDismissionResponse setBody(EmpStartDismissionResponseBody body) {
        this.body = body;
        return this;
    }
    public EmpStartDismissionResponseBody getBody() {
        return this.body;
    }

}
