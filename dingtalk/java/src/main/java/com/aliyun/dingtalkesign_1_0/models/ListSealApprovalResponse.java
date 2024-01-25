// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListSealApprovalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSealApprovalResponseBody body;

    public static ListSealApprovalResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSealApprovalResponse self = new ListSealApprovalResponse();
        return TeaModel.build(map, self);
    }

    public ListSealApprovalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSealApprovalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSealApprovalResponse setBody(ListSealApprovalResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSealApprovalResponseBody getBody() {
        return this.body;
    }

}
