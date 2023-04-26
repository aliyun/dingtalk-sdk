// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CancelIntegratedTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CancelIntegratedTaskResponseBody body;

    public static CancelIntegratedTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelIntegratedTaskResponse self = new CancelIntegratedTaskResponse();
        return TeaModel.build(map, self);
    }

    public CancelIntegratedTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelIntegratedTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelIntegratedTaskResponse setBody(CancelIntegratedTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelIntegratedTaskResponseBody getBody() {
        return this.body;
    }

}
