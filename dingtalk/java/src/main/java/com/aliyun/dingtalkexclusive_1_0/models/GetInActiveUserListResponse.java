// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetInActiveUserListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInActiveUserListResponseBody body;

    public static GetInActiveUserListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInActiveUserListResponse self = new GetInActiveUserListResponse();
        return TeaModel.build(map, self);
    }

    public GetInActiveUserListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInActiveUserListResponse setBody(GetInActiveUserListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInActiveUserListResponseBody getBody() {
        return this.body;
    }

}
