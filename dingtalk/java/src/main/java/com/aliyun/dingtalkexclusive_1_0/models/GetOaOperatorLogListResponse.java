// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOaOperatorLogListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOaOperatorLogListResponseBody body;

    public static GetOaOperatorLogListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOaOperatorLogListResponse self = new GetOaOperatorLogListResponse();
        return TeaModel.build(map, self);
    }

    public GetOaOperatorLogListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOaOperatorLogListResponse setBody(GetOaOperatorLogListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOaOperatorLogListResponseBody getBody() {
        return this.body;
    }

}
