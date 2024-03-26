// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPunDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportPunDetailResponseBody body;

    public static HrbrainImportPunDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPunDetailResponse self = new HrbrainImportPunDetailResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPunDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportPunDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportPunDetailResponse setBody(HrbrainImportPunDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportPunDetailResponseBody getBody() {
        return this.body;
    }

}
