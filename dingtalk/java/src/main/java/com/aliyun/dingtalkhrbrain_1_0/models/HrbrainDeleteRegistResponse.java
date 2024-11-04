// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteRegistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteRegistResponseBody body;

    public static HrbrainDeleteRegistResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteRegistResponse self = new HrbrainDeleteRegistResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteRegistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteRegistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteRegistResponse setBody(HrbrainDeleteRegistResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteRegistResponseBody getBody() {
        return this.body;
    }

}
