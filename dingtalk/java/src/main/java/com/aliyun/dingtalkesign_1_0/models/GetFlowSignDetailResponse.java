// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowSignDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFlowSignDetailResponseBody body;

    public static GetFlowSignDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowSignDetailResponse self = new GetFlowSignDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowSignDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowSignDetailResponse setBody(GetFlowSignDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowSignDetailResponseBody getBody() {
        return this.body;
    }

}
