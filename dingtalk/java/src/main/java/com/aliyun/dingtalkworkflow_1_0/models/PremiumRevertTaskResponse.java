// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRevertTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumRevertTaskResponseBody body;

    public static PremiumRevertTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumRevertTaskResponse self = new PremiumRevertTaskResponse();
        return TeaModel.build(map, self);
    }

    public PremiumRevertTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumRevertTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumRevertTaskResponse setBody(PremiumRevertTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumRevertTaskResponseBody getBody() {
        return this.body;
    }

}
