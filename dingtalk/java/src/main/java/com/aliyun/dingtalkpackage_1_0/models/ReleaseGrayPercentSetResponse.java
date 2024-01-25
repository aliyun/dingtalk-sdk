// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentSetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReleaseGrayPercentSetResponseBody body;

    public static ReleaseGrayPercentSetResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentSetResponse self = new ReleaseGrayPercentSetResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayPercentSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayPercentSetResponse setBody(ReleaseGrayPercentSetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayPercentSetResponseBody getBody() {
        return this.body;
    }

}
