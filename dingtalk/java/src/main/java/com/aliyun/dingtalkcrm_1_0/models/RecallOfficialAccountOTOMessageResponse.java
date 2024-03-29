// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class RecallOfficialAccountOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RecallOfficialAccountOTOMessageResponseBody body;

    public static RecallOfficialAccountOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        RecallOfficialAccountOTOMessageResponse self = new RecallOfficialAccountOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public RecallOfficialAccountOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecallOfficialAccountOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RecallOfficialAccountOTOMessageResponse setBody(RecallOfficialAccountOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallOfficialAccountOTOMessageResponseBody getBody() {
        return this.body;
    }

}
