// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspacesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetWorkspacesResponseBody body;

    public static BatchGetWorkspacesResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspacesResponse self = new BatchGetWorkspacesResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetWorkspacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetWorkspacesResponse setBody(BatchGetWorkspacesResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetWorkspacesResponseBody getBody() {
        return this.body;
    }

}
