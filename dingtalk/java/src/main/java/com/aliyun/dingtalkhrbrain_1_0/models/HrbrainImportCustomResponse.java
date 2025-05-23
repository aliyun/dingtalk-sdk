// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportCustomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportCustomResponseBody body;

    public static HrbrainImportCustomResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportCustomResponse self = new HrbrainImportCustomResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportCustomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportCustomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportCustomResponse setBody(HrbrainImportCustomResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportCustomResponseBody getBody() {
        return this.body;
    }

}
