// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ExtractFacialFeatureResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExtractFacialFeatureResponseBody body;

    public static ExtractFacialFeatureResponse build(java.util.Map<String, ?> map) throws Exception {
        ExtractFacialFeatureResponse self = new ExtractFacialFeatureResponse();
        return TeaModel.build(map, self);
    }

    public ExtractFacialFeatureResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExtractFacialFeatureResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExtractFacialFeatureResponse setBody(ExtractFacialFeatureResponseBody body) {
        this.body = body;
        return this;
    }
    public ExtractFacialFeatureResponseBody getBody() {
        return this.body;
    }

}
