// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PublishInnerAppVersionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PublishInnerAppVersionResponseBody body;

    public static PublishInnerAppVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishInnerAppVersionResponse self = new PublishInnerAppVersionResponse();
        return TeaModel.build(map, self);
    }

    public PublishInnerAppVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PublishInnerAppVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PublishInnerAppVersionResponse setBody(PublishInnerAppVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishInnerAppVersionResponseBody getBody() {
        return this.body;
    }

}
