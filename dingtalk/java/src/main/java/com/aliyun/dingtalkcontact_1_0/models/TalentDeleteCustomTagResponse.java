// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeleteCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentDeleteCustomTagResponseBody body;

    public static TalentDeleteCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentDeleteCustomTagResponse self = new TalentDeleteCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentDeleteCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentDeleteCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentDeleteCustomTagResponse setBody(TalentDeleteCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentDeleteCustomTagResponseBody getBody() {
        return this.body;
    }

}
