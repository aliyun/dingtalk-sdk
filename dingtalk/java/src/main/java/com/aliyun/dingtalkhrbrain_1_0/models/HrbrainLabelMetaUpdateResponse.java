// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelMetaUpdateResponseBody body;

    public static HrbrainLabelMetaUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaUpdateResponse self = new HrbrainLabelMetaUpdateResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelMetaUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelMetaUpdateResponse setBody(HrbrainLabelMetaUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelMetaUpdateResponseBody getBody() {
        return this.body;
    }

}
