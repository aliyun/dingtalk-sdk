// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ReleaseCommodityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ReleaseCommodityResponseBody body;

    public static ReleaseCommodityResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseCommodityResponse self = new ReleaseCommodityResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseCommodityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseCommodityResponse setBody(ReleaseCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseCommodityResponseBody getBody() {
        return this.body;
    }

}
