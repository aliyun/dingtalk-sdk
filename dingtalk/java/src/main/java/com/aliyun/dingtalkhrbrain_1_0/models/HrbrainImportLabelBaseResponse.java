// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelBaseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportLabelBaseResponseBody body;

    public static HrbrainImportLabelBaseResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelBaseResponse self = new HrbrainImportLabelBaseResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelBaseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportLabelBaseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportLabelBaseResponse setBody(HrbrainImportLabelBaseResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportLabelBaseResponseBody getBody() {
        return this.body;
    }

}
