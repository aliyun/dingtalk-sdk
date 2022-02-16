// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetBookkeepingUserListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetBookkeepingUserListResponseBody body;

    public static GetBookkeepingUserListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBookkeepingUserListResponse self = new GetBookkeepingUserListResponse();
        return TeaModel.build(map, self);
    }

    public GetBookkeepingUserListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBookkeepingUserListResponse setBody(GetBookkeepingUserListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBookkeepingUserListResponseBody getBody() {
        return this.body;
    }

}
