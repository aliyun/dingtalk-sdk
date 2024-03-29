// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MoveDentryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DentryVO body;

    public static MoveDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        MoveDentryResponse self = new MoveDentryResponse();
        return TeaModel.build(map, self);
    }

    public MoveDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MoveDentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MoveDentryResponse setBody(DentryVO body) {
        this.body = body;
        return this;
    }
    public DentryVO getBody() {
        return this.body;
    }

}
