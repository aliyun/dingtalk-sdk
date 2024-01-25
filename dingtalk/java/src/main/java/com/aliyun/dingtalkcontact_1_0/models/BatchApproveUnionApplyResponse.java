// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchApproveUnionApplyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchApproveUnionApplyResponseBody body;

    public static BatchApproveUnionApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchApproveUnionApplyResponse self = new BatchApproveUnionApplyResponse();
        return TeaModel.build(map, self);
    }

    public BatchApproveUnionApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchApproveUnionApplyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchApproveUnionApplyResponse setBody(BatchApproveUnionApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchApproveUnionApplyResponseBody getBody() {
        return this.body;
    }

}
