// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainEmpPoolQueryResponseBody body;

    public static HrbrainEmpPoolQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolQueryResponse self = new HrbrainEmpPoolQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainEmpPoolQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainEmpPoolQueryResponse setBody(HrbrainEmpPoolQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainEmpPoolQueryResponseBody getBody() {
        return this.body;
    }

}
