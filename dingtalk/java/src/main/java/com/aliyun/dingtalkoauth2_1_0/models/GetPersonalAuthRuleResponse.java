// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalAuthRuleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetPersonalAuthRuleResponseBody body;

    public static GetPersonalAuthRuleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalAuthRuleResponse self = new GetPersonalAuthRuleResponse();
        return TeaModel.build(map, self);
    }

    public GetPersonalAuthRuleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPersonalAuthRuleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPersonalAuthRuleResponse setBody(GetPersonalAuthRuleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPersonalAuthRuleResponseBody getBody() {
        return this.body;
    }

}
