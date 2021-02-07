// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCropStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCropStatusResponseBody body;

    public static GetCropStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCropStatusResponse self = new GetCropStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetCropStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCropStatusResponse setBody(GetCropStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCropStatusResponseBody getBody() {
        return this.body;
    }

}
