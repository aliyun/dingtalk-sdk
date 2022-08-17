// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAllLiveListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserAllLiveListResponseBody body;

    public static GetUserAllLiveListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserAllLiveListResponse self = new GetUserAllLiveListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserAllLiveListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserAllLiveListResponse setBody(GetUserAllLiveListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserAllLiveListResponseBody getBody() {
        return this.body;
    }

}
