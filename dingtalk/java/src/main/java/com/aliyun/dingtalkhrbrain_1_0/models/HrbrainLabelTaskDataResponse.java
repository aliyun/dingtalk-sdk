// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelTaskDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelTaskDataResponseBody body;

    public static HrbrainLabelTaskDataResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelTaskDataResponse self = new HrbrainLabelTaskDataResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelTaskDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelTaskDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelTaskDataResponse setBody(HrbrainLabelTaskDataResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelTaskDataResponseBody getBody() {
        return this.body;
    }

}
