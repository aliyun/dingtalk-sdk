// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateProcessInstanceVariablesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumUpdateProcessInstanceVariablesResponseBody body;

    public static PremiumUpdateProcessInstanceVariablesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateProcessInstanceVariablesResponse self = new PremiumUpdateProcessInstanceVariablesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateProcessInstanceVariablesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumUpdateProcessInstanceVariablesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumUpdateProcessInstanceVariablesResponse setBody(PremiumUpdateProcessInstanceVariablesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumUpdateProcessInstanceVariablesResponseBody getBody() {
        return this.body;
    }

}
