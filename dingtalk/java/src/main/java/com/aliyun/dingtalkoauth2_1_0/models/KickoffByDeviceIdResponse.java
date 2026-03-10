// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class KickoffByDeviceIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public KickoffByDeviceIdResponseBody body;

    public static KickoffByDeviceIdResponse build(java.util.Map<String, ?> map) throws Exception {
        KickoffByDeviceIdResponse self = new KickoffByDeviceIdResponse();
        return TeaModel.build(map, self);
    }

    public KickoffByDeviceIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public KickoffByDeviceIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public KickoffByDeviceIdResponse setBody(KickoffByDeviceIdResponseBody body) {
        this.body = body;
        return this;
    }
    public KickoffByDeviceIdResponseBody getBody() {
        return this.body;
    }

}
