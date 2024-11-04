// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteDimissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteDimissionResponseBody body;

    public static HrbrainDeleteDimissionResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteDimissionResponse self = new HrbrainDeleteDimissionResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteDimissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteDimissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteDimissionResponse setBody(HrbrainDeleteDimissionResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteDimissionResponseBody getBody() {
        return this.body;
    }

}
