// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserWatchLiveListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserWatchLiveListResponseBody body;

    public static GetUserWatchLiveListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserWatchLiveListResponse self = new GetUserWatchLiveListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserWatchLiveListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserWatchLiveListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserWatchLiveListResponse setBody(GetUserWatchLiveListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserWatchLiveListResponseBody getBody() {
        return this.body;
    }

}
