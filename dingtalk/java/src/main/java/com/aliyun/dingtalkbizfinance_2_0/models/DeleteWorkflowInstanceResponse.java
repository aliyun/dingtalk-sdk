// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteWorkflowInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteWorkflowInstanceResponseBody body;

    public static DeleteWorkflowInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkflowInstanceResponse self = new DeleteWorkflowInstanceResponse();
        return TeaModel.build(map, self);
    }

    public DeleteWorkflowInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteWorkflowInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteWorkflowInstanceResponse setBody(DeleteWorkflowInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteWorkflowInstanceResponseBody getBody() {
        return this.body;
    }

}
