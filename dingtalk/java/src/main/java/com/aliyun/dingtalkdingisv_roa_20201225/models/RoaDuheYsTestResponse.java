// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class RoaDuheYsTestResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RoaDuheYsTestResponseBody body;

    public static RoaDuheYsTestResponse build(java.util.Map<String, ?> map) throws Exception {
        RoaDuheYsTestResponse self = new RoaDuheYsTestResponse();
        return TeaModel.build(map, self);
    }

    public RoaDuheYsTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RoaDuheYsTestResponse setBody(RoaDuheYsTestResponseBody body) {
        this.body = body;
        return this;
    }
    public RoaDuheYsTestResponseBody getBody() {
        return this.body;
    }

}
