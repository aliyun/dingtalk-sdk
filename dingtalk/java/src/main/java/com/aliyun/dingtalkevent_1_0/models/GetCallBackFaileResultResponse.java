// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class GetCallBackFaileResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCallBackFaileResultResponseBody body;

    public static GetCallBackFaileResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCallBackFaileResultResponse self = new GetCallBackFaileResultResponse();
        return TeaModel.build(map, self);
    }

    public GetCallBackFaileResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCallBackFaileResultResponse setBody(GetCallBackFaileResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCallBackFaileResultResponseBody getBody() {
        return this.body;
    }

}
