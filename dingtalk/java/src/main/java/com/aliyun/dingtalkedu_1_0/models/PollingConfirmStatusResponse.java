// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PollingConfirmStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PollingConfirmStatusResponseBody body;

    public static PollingConfirmStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        PollingConfirmStatusResponse self = new PollingConfirmStatusResponse();
        return TeaModel.build(map, self);
    }

    public PollingConfirmStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PollingConfirmStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PollingConfirmStatusResponse setBody(PollingConfirmStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public PollingConfirmStatusResponseBody getBody() {
        return this.body;
    }

}
