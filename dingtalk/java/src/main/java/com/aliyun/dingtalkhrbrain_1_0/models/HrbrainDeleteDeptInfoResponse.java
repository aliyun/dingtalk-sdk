// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteDeptInfoResponseBody body;

    public static HrbrainDeleteDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteDeptInfoResponse self = new HrbrainDeleteDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteDeptInfoResponse setBody(HrbrainDeleteDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteDeptInfoResponseBody getBody() {
        return this.body;
    }

}
