// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobStatusCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryJobStatusCodeDictionaryResponseBody body;

    public static QueryJobStatusCodeDictionaryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryJobStatusCodeDictionaryResponse self = new QueryJobStatusCodeDictionaryResponse();
        return TeaModel.build(map, self);
    }

    public QueryJobStatusCodeDictionaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryJobStatusCodeDictionaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryJobStatusCodeDictionaryResponse setBody(QueryJobStatusCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobStatusCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
