// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CancelProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelProcessInstanceResponseBody body;

    public static CancelProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelProcessInstanceResponse self = new CancelProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CancelProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelProcessInstanceResponse setBody(CancelProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
