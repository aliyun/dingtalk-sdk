// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ReleaseGrayPercentSetResponse setBody(ReleaseGrayPercentSetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayPercentSetResponseBody getBody() {
        return this.body;
    }

}
