// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MoveDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DentryOpenVOResult body;

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

    public MoveDentryResponse setBody(DentryOpenVOResult body) {
        this.body = body;
        return this;
    }
    public DentryOpenVOResult getBody() {
        return this.body;
    }

}
