// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportAwardDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportAwardDetailResponseBody body;

    public static HrbrainImportAwardDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportAwardDetailResponse self = new HrbrainImportAwardDetailResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportAwardDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportAwardDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportAwardDetailResponse setBody(HrbrainImportAwardDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportAwardDetailResponseBody getBody() {
        return this.body;
    }

}
