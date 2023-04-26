// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateRelationDatasResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchUpdateRelationDatasResponseBody body;

    public static BatchUpdateRelationDatasResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateRelationDatasResponse self = new BatchUpdateRelationDatasResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateRelationDatasResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateRelationDatasResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateRelationDatasResponse setBody(BatchUpdateRelationDatasResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateRelationDatasResponseBody getBody() {
        return this.body;
    }

}
