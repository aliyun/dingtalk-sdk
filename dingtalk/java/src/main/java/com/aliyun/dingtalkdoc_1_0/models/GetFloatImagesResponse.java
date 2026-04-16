// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFloatImagesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFloatImagesResponseBody body;

    public static GetFloatImagesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFloatImagesResponse self = new GetFloatImagesResponse();
        return TeaModel.build(map, self);
    }

    public GetFloatImagesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFloatImagesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFloatImagesResponse setBody(GetFloatImagesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFloatImagesResponseBody getBody() {
        return this.body;
    }

}
