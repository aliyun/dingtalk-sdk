// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class TopboxOpenResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static TopboxOpenResponse build(java.util.Map<String, ?> map) throws Exception {
        TopboxOpenResponse self = new TopboxOpenResponse();
        return TeaModel.build(map, self);
    }

    public TopboxOpenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
