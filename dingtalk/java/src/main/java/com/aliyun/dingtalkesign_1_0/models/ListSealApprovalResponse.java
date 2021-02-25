// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListSealApprovalResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListSealApprovalResponse setBody(ListSealApprovalResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSealApprovalResponseBody getBody() {
        return this.body;
    }

}
