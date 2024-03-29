// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MarkStarResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MarkStarResponseBody body;

    public static MarkStarResponse build(java.util.Map<String, ?> map) throws Exception {
        MarkStarResponse self = new MarkStarResponse();
        return TeaModel.build(map, self);
    }

    public MarkStarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MarkStarResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MarkStarResponse setBody(MarkStarResponseBody body) {
        this.body = body;
        return this;
    }
    public MarkStarResponseBody getBody() {
        return this.body;
    }

}
