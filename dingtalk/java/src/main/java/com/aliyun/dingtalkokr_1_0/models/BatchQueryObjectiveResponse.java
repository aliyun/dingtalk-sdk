// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchQueryObjectiveResponseBody body;

    public static BatchQueryObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryObjectiveResponse self = new BatchQueryObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryObjectiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryObjectiveResponse setBody(BatchQueryObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryObjectiveResponseBody getBody() {
        return this.body;
    }

}
