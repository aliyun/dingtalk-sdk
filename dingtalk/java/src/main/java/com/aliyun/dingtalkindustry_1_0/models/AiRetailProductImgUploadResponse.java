// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductImgUploadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiRetailProductImgUploadResponseBody body;

    public static AiRetailProductImgUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductImgUploadResponse self = new AiRetailProductImgUploadResponse();
        return TeaModel.build(map, self);
    }

    public AiRetailProductImgUploadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiRetailProductImgUploadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiRetailProductImgUploadResponse setBody(AiRetailProductImgUploadResponseBody body) {
        this.body = body;
        return this;
    }
    public AiRetailProductImgUploadResponseBody getBody() {
        return this.body;
    }

}
