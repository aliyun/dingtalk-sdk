// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateClueDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateClueDataResponseBody body;

    public static BatchCreateClueDataResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateClueDataResponse self = new BatchCreateClueDataResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateClueDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateClueDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateClueDataResponse setBody(BatchCreateClueDataResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateClueDataResponseBody getBody() {
        return this.body;
    }

}
