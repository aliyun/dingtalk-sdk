// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobPositionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllJobPositionResponseBody body;

    public static GetAllJobPositionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobPositionResponse self = new GetAllJobPositionResponse();
        return TeaModel.build(map, self);
    }

    public GetAllJobPositionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllJobPositionResponse setBody(GetAllJobPositionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllJobPositionResponseBody getBody() {
        return this.body;
    }

}
