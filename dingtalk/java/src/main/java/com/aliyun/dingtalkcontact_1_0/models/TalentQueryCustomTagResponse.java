// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentQueryCustomTagResponseBody body;

    public static TalentQueryCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryCustomTagResponse self = new TalentQueryCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentQueryCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentQueryCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentQueryCustomTagResponse setBody(TalentQueryCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentQueryCustomTagResponseBody getBody() {
        return this.body;
    }

}
