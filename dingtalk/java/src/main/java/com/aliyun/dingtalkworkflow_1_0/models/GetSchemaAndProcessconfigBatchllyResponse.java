// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSchemaAndProcessconfigBatchllyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSchemaAndProcessconfigBatchllyResponseBody body;

    public static GetSchemaAndProcessconfigBatchllyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaAndProcessconfigBatchllyResponse self = new GetSchemaAndProcessconfigBatchllyResponse();
        return TeaModel.build(map, self);
    }

    public GetSchemaAndProcessconfigBatchllyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSchemaAndProcessconfigBatchllyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSchemaAndProcessconfigBatchllyResponse setBody(GetSchemaAndProcessconfigBatchllyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSchemaAndProcessconfigBatchllyResponseBody getBody() {
        return this.body;
    }

}
