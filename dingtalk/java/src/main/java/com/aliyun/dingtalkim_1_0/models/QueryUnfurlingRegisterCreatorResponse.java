// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnfurlingRegisterCreatorResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUnfurlingRegisterCreatorResponseBody body;

    public static QueryUnfurlingRegisterCreatorResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUnfurlingRegisterCreatorResponse self = new QueryUnfurlingRegisterCreatorResponse();
        return TeaModel.build(map, self);
    }

    public QueryUnfurlingRegisterCreatorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUnfurlingRegisterCreatorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUnfurlingRegisterCreatorResponse setBody(QueryUnfurlingRegisterCreatorResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnfurlingRegisterCreatorResponseBody getBody() {
        return this.body;
    }

}
