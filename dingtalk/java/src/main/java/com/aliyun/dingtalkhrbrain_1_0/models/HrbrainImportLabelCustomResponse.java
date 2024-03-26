// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelCustomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportLabelCustomResponseBody body;

    public static HrbrainImportLabelCustomResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelCustomResponse self = new HrbrainImportLabelCustomResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelCustomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportLabelCustomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportLabelCustomResponse setBody(HrbrainImportLabelCustomResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportLabelCustomResponseBody getBody() {
        return this.body;
    }

}
