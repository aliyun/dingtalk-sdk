// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobStatusCodeDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryJobStatusCodeDictionaryResponse setBody(QueryJobStatusCodeDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobStatusCodeDictionaryResponseBody getBody() {
        return this.body;
    }

}
