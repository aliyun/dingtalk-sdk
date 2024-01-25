// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserProbCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserProbCodeDictionaryResponseBody body;

    public static QueryUserProbCodeDictionaryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserProbCodeDictionaryResponse self = new QueryUserProbCodeDictionaryResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserProbCodeDictionaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserProbCodeDictionaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserProbCodeDictionaryResponse setBody(QueryUserProbCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserProbCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
