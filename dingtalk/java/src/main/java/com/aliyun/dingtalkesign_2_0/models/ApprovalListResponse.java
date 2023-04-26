// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ApprovalListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ApprovalListResponseBody body;

    public static ApprovalListResponse build(java.util.Map<String, ?> map) throws Exception {
        ApprovalListResponse self = new ApprovalListResponse();
        return TeaModel.build(map, self);
    }

    public ApprovalListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApprovalListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ApprovalListResponse setBody(ApprovalListResponseBody body) {
        this.body = body;
        return this;
    }
    public ApprovalListResponseBody getBody() {
        return this.body;
    }

}
