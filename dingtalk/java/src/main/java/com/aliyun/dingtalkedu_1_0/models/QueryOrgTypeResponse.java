// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOrgTypeResponseBody body;

    public static QueryOrgTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTypeResponse self = new QueryOrgTypeResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgTypeResponse setBody(QueryOrgTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgTypeResponseBody getBody() {
        return this.body;
    }

}
