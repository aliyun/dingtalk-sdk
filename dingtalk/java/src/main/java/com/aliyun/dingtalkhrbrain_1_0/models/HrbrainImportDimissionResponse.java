// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportDimissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportDimissionResponseBody body;

    public static HrbrainImportDimissionResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportDimissionResponse self = new HrbrainImportDimissionResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportDimissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportDimissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportDimissionResponse setBody(HrbrainImportDimissionResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportDimissionResponseBody getBody() {
        return this.body;
    }

}
