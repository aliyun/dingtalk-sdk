// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRecentsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchDeleteRecentsResponseBody body;

    public static BatchDeleteRecentsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRecentsResponse self = new BatchDeleteRecentsResponse();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRecentsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchDeleteRecentsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchDeleteRecentsResponse setBody(BatchDeleteRecentsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchDeleteRecentsResponseBody getBody() {
        return this.body;
    }

}
