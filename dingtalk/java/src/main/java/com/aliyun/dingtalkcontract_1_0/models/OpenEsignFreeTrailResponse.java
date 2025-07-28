// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class OpenEsignFreeTrailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenEsignFreeTrailResponseBody body;

    public static OpenEsignFreeTrailResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenEsignFreeTrailResponse self = new OpenEsignFreeTrailResponse();
        return TeaModel.build(map, self);
    }

    public OpenEsignFreeTrailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenEsignFreeTrailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenEsignFreeTrailResponse setBody(OpenEsignFreeTrailResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenEsignFreeTrailResponseBody getBody() {
        return this.body;
    }

}
