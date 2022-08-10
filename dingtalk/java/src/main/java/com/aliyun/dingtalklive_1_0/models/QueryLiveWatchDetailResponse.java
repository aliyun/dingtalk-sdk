// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryLiveWatchDetailResponseBody body;

    public static QueryLiveWatchDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchDetailResponse self = new QueryLiveWatchDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryLiveWatchDetailResponse setBody(QueryLiveWatchDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryLiveWatchDetailResponseBody getBody() {
        return this.body;
    }

}
