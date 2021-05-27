// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFlowDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFlowDetailResponseBody body;

    public static GetFlowDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDetailResponse self = new GetFlowDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowDetailResponse setBody(GetFlowDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowDetailResponseBody getBody() {
        return this.body;
    }

}
