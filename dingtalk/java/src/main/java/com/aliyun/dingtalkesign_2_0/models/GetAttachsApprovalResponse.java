// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAttachsApprovalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAttachsApprovalResponseBody body;

    public static GetAttachsApprovalResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAttachsApprovalResponse self = new GetAttachsApprovalResponse();
        return TeaModel.build(map, self);
    }

    public GetAttachsApprovalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAttachsApprovalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAttachsApprovalResponse setBody(GetAttachsApprovalResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAttachsApprovalResponseBody getBody() {
        return this.body;
    }

}
