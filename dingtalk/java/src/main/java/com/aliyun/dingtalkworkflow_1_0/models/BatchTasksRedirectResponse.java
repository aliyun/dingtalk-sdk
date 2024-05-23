// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchTasksRedirectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchTasksRedirectResponseBody body;

    public static BatchTasksRedirectResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchTasksRedirectResponse self = new BatchTasksRedirectResponse();
        return TeaModel.build(map, self);
    }

    public BatchTasksRedirectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchTasksRedirectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchTasksRedirectResponse setBody(BatchTasksRedirectResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchTasksRedirectResponseBody getBody() {
        return this.body;
    }

}
