// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteRegularResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteRegularResponseBody body;

    public static HrbrainDeleteRegularResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteRegularResponse self = new HrbrainDeleteRegularResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteRegularResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteRegularResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteRegularResponse setBody(HrbrainDeleteRegularResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteRegularResponseBody getBody() {
        return this.body;
    }

}
