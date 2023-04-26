// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessUpdateTerminationInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public HrmProcessUpdateTerminationInfoResponseBody body;

    public static HrmProcessUpdateTerminationInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessUpdateTerminationInfoResponse self = new HrmProcessUpdateTerminationInfoResponse();
        return TeaModel.build(map, self);
    }

    public HrmProcessUpdateTerminationInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmProcessUpdateTerminationInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmProcessUpdateTerminationInfoResponse setBody(HrmProcessUpdateTerminationInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessUpdateTerminationInfoResponseBody getBody() {
        return this.body;
    }

}
