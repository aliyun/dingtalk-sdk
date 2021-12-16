// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserCardHolderListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserCardHolderListResponseBody body;

    public static GetUserCardHolderListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserCardHolderListResponse self = new GetUserCardHolderListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserCardHolderListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserCardHolderListResponse setBody(GetUserCardHolderListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserCardHolderListResponseBody getBody() {
        return this.body;
    }

}
