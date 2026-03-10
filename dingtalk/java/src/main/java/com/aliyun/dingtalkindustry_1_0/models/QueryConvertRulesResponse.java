// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryConvertRulesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryConvertRulesResponseBody body;

    public static QueryConvertRulesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConvertRulesResponse self = new QueryConvertRulesResponse();
        return TeaModel.build(map, self);
    }

    public QueryConvertRulesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConvertRulesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryConvertRulesResponse setBody(QueryConvertRulesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConvertRulesResponseBody getBody() {
        return this.body;
    }

}
