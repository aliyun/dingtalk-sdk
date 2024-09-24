// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactExclusiveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeContactExclusiveResponseBody body;

    public static UpdateCollegeContactExclusiveResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactExclusiveResponse self = new UpdateCollegeContactExclusiveResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactExclusiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeContactExclusiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeContactExclusiveResponse setBody(UpdateCollegeContactExclusiveResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeContactExclusiveResponseBody getBody() {
        return this.body;
    }

}
