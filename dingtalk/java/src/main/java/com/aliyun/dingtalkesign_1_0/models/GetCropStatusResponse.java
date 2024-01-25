// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCropStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetCropStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCropStatusResponse setBody(GetCropStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCropStatusResponseBody getBody() {
        return this.body;
    }

}
