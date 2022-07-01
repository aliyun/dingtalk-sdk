// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryRecentListResponseBody body;

    public static QueryRecentListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentListResponse self = new QueryRecentListResponse();
        return TeaModel.build(map, self);
    }

    public QueryRecentListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRecentListResponse setBody(QueryRecentListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRecentListResponseBody getBody() {
        return this.body;
    }

}
