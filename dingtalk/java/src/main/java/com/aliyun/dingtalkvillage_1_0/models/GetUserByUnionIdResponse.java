// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserByUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserByUnionIdResponseBody body;

    public static GetUserByUnionIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserByUnionIdResponse self = new GetUserByUnionIdResponse();
        return TeaModel.build(map, self);
    }

    public GetUserByUnionIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserByUnionIdResponse setBody(GetUserByUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserByUnionIdResponseBody getBody() {
        return this.body;
    }

}
