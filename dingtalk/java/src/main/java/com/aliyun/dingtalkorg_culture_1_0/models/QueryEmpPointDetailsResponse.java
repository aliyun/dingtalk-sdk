// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryEmpPointDetailsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryEmpPointDetailsResponseBody body;

    public static QueryEmpPointDetailsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEmpPointDetailsResponse self = new QueryEmpPointDetailsResponse();
        return TeaModel.build(map, self);
    }

    public QueryEmpPointDetailsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEmpPointDetailsResponse setBody(QueryEmpPointDetailsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEmpPointDetailsResponseBody getBody() {
        return this.body;
    }

}
