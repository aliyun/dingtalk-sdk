// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchUserListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryLiveWatchUserListResponseBody body;

    public static QueryLiveWatchUserListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchUserListResponse self = new QueryLiveWatchUserListResponse();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchUserListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryLiveWatchUserListResponse setBody(QueryLiveWatchUserListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryLiveWatchUserListResponseBody getBody() {
        return this.body;
    }

}
