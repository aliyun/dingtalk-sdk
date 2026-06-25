// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SubmitCreateEnterpriseAgentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitCreateEnterpriseAgentResponseBody body;

    public static SubmitCreateEnterpriseAgentResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitCreateEnterpriseAgentResponse self = new SubmitCreateEnterpriseAgentResponse();
        return TeaModel.build(map, self);
    }

    public SubmitCreateEnterpriseAgentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitCreateEnterpriseAgentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitCreateEnterpriseAgentResponse setBody(SubmitCreateEnterpriseAgentResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitCreateEnterpriseAgentResponseBody getBody() {
        return this.body;
    }

}
