// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportWorkExpResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportWorkExpResponseBody body;

    public static HrbrainImportWorkExpResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportWorkExpResponse self = new HrbrainImportWorkExpResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportWorkExpResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportWorkExpResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportWorkExpResponse setBody(HrbrainImportWorkExpResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportWorkExpResponseBody getBody() {
        return this.body;
    }

}
