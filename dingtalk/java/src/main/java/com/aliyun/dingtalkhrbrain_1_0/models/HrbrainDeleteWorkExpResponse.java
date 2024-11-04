// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteWorkExpResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteWorkExpResponseBody body;

    public static HrbrainDeleteWorkExpResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteWorkExpResponse self = new HrbrainDeleteWorkExpResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteWorkExpResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteWorkExpResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteWorkExpResponse setBody(HrbrainDeleteWorkExpResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteWorkExpResponseBody getBody() {
        return this.body;
    }

}
