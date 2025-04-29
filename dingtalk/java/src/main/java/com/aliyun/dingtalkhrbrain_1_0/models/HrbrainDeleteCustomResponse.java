// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteCustomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteCustomResponseBody body;

    public static HrbrainDeleteCustomResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteCustomResponse self = new HrbrainDeleteCustomResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteCustomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteCustomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteCustomResponse setBody(HrbrainDeleteCustomResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteCustomResponseBody getBody() {
        return this.body;
    }

}
