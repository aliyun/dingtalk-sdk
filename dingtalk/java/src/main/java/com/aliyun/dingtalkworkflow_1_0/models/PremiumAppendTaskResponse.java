// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAppendTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumAppendTaskResponseBody body;

    public static PremiumAppendTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumAppendTaskResponse self = new PremiumAppendTaskResponse();
        return TeaModel.build(map, self);
    }

    public PremiumAppendTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumAppendTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumAppendTaskResponse setBody(PremiumAppendTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumAppendTaskResponseBody getBody() {
        return this.body;
    }

}
