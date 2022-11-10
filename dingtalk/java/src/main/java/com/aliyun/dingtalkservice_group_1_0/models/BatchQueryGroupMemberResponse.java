// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchQueryGroupMemberResponseBody body;

    public static BatchQueryGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryGroupMemberResponse self = new BatchQueryGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryGroupMemberResponse setBody(BatchQueryGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryGroupMemberResponseBody getBody() {
        return this.body;
    }

}
