// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchSendResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBatchSendResultResponseBody body;

    public static QueryBatchSendResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchSendResultResponse self = new QueryBatchSendResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryBatchSendResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBatchSendResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBatchSendResultResponse setBody(QueryBatchSendResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBatchSendResultResponseBody getBody() {
        return this.body;
    }

}
