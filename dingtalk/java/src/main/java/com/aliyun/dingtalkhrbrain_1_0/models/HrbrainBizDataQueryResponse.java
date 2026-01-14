// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainBizDataQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainBizDataQueryResponseBody body;

    public static HrbrainBizDataQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainBizDataQueryResponse self = new HrbrainBizDataQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainBizDataQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainBizDataQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainBizDataQueryResponse setBody(HrbrainBizDataQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainBizDataQueryResponseBody getBody() {
        return this.body;
    }

}
