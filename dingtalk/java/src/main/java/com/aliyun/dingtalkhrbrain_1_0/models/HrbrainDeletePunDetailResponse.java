// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePunDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeletePunDetailResponseBody body;

    public static HrbrainDeletePunDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePunDetailResponse self = new HrbrainDeletePunDetailResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePunDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeletePunDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeletePunDetailResponse setBody(HrbrainDeletePunDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeletePunDetailResponseBody getBody() {
        return this.body;
    }

}
