// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReleaseGrayPercentGetResponseBody body;

    public static ReleaseGrayPercentGetResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentGetResponse self = new ReleaseGrayPercentGetResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayPercentGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayPercentGetResponse setBody(ReleaseGrayPercentGetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayPercentGetResponseBody getBody() {
        return this.body;
    }

}
