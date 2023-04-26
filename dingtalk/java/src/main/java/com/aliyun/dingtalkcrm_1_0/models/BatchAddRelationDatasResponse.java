// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddRelationDatasResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchAddRelationDatasResponseBody body;

    public static BatchAddRelationDatasResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddRelationDatasResponse self = new BatchAddRelationDatasResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddRelationDatasResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddRelationDatasResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchAddRelationDatasResponse setBody(BatchAddRelationDatasResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddRelationDatasResponseBody getBody() {
        return this.body;
    }

}
