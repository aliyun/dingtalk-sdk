// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessRegularResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public HrmProcessRegularResponseBody body;

    public static HrmProcessRegularResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessRegularResponse self = new HrmProcessRegularResponse();
        return TeaModel.build(map, self);
    }

    public HrmProcessRegularResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmProcessRegularResponse setBody(HrmProcessRegularResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessRegularResponseBody getBody() {
        return this.body;
    }

}
