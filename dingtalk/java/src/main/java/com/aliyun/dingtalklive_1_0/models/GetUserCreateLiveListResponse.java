// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserCreateLiveListResponseBody body;

    public static GetUserCreateLiveListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListResponse self = new GetUserCreateLiveListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserCreateLiveListResponse setBody(GetUserCreateLiveListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserCreateLiveListResponseBody getBody() {
        return this.body;
    }

}
