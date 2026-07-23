// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveBannerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExclusiveBannerResponseBody body;

    public static ExclusiveBannerResponse build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveBannerResponse self = new ExclusiveBannerResponse();
        return TeaModel.build(map, self);
    }

    public ExclusiveBannerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExclusiveBannerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExclusiveBannerResponse setBody(ExclusiveBannerResponseBody body) {
        this.body = body;
        return this;
    }
    public ExclusiveBannerResponseBody getBody() {
        return this.body;
    }

}
