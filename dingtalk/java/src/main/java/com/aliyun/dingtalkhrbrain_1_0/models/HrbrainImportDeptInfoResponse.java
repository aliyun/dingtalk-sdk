// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportDeptInfoResponseBody body;

    public static HrbrainImportDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportDeptInfoResponse self = new HrbrainImportDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportDeptInfoResponse setBody(HrbrainImportDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportDeptInfoResponseBody getBody() {
        return this.body;
    }

}
