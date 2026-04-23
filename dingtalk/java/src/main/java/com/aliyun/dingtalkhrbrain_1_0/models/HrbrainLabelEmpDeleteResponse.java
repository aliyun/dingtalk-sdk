// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelEmpDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelEmpDeleteResponseBody body;

    public static HrbrainLabelEmpDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelEmpDeleteResponse self = new HrbrainLabelEmpDeleteResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelEmpDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelEmpDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelEmpDeleteResponse setBody(HrbrainLabelEmpDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelEmpDeleteResponseBody getBody() {
        return this.body;
    }

}
