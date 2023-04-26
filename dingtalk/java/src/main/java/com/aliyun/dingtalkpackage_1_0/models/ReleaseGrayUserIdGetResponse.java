// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayUserIdGetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReleaseGrayUserIdGetResponseBody body;

    public static ReleaseGrayUserIdGetResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayUserIdGetResponse self = new ReleaseGrayUserIdGetResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayUserIdGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayUserIdGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayUserIdGetResponse setBody(ReleaseGrayUserIdGetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayUserIdGetResponseBody getBody() {
        return this.body;
    }

}
