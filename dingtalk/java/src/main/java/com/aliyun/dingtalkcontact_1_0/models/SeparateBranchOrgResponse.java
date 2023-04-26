// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SeparateBranchOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SeparateBranchOrgResponseBody body;

    public static SeparateBranchOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        SeparateBranchOrgResponse self = new SeparateBranchOrgResponse();
        return TeaModel.build(map, self);
    }

    public SeparateBranchOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SeparateBranchOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SeparateBranchOrgResponse setBody(SeparateBranchOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public SeparateBranchOrgResponseBody getBody() {
        return this.body;
    }

}
