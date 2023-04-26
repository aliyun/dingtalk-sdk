// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspaceDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchGetWorkspaceDocsResponseBody body;

    public static BatchGetWorkspaceDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspaceDocsResponse self = new BatchGetWorkspaceDocsResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspaceDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetWorkspaceDocsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetWorkspaceDocsResponse setBody(BatchGetWorkspaceDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetWorkspaceDocsResponseBody getBody() {
        return this.body;
    }

}
