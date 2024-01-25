// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryJobCodeDictionaryResponseBody body;

    public static QueryJobCodeDictionaryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryJobCodeDictionaryResponse self = new QueryJobCodeDictionaryResponse();
        return TeaModel.build(map, self);
    }

    public QueryJobCodeDictionaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryJobCodeDictionaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryJobCodeDictionaryResponse setBody(QueryJobCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
