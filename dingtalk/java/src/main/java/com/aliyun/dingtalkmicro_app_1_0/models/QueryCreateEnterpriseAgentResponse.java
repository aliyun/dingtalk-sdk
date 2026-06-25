// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateEnterpriseAgentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCreateEnterpriseAgentResponseBody body;

    public static QueryCreateEnterpriseAgentResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateEnterpriseAgentResponse self = new QueryCreateEnterpriseAgentResponse();
        return TeaModel.build(map, self);
    }

    public QueryCreateEnterpriseAgentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCreateEnterpriseAgentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCreateEnterpriseAgentResponse setBody(QueryCreateEnterpriseAgentResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCreateEnterpriseAgentResponseBody getBody() {
        return this.body;
    }

}
