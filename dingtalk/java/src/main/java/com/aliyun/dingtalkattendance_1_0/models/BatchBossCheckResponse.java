// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class BatchBossCheckResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchBossCheckResponseBody body;

    public static BatchBossCheckResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchBossCheckResponse self = new BatchBossCheckResponse();
        return TeaModel.build(map, self);
    }

    public BatchBossCheckResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchBossCheckResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchBossCheckResponse setBody(BatchBossCheckResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchBossCheckResponseBody getBody() {
        return this.body;
    }

}
