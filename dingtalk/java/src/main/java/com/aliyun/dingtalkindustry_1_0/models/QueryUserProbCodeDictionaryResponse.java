// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserProbCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUserProbCodeDictionaryResponse setBody(QueryUserProbCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserProbCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
