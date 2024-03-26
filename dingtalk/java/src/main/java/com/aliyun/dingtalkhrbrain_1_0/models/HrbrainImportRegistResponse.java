// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportRegistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportRegistResponseBody body;

    public static HrbrainImportRegistResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportRegistResponse self = new HrbrainImportRegistResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportRegistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportRegistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportRegistResponse setBody(HrbrainImportRegistResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportRegistResponseBody getBody() {
        return this.body;
    }

}
