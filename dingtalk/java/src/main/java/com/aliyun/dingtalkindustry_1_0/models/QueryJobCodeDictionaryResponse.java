// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryJobCodeDictionaryResponse setBody(QueryJobCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
