// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportRegularResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportRegularResponseBody body;

    public static HrbrainImportRegularResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportRegularResponse self = new HrbrainImportRegularResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportRegularResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportRegularResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportRegularResponse setBody(HrbrainImportRegularResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportRegularResponseBody getBody() {
        return this.body;
    }

}
