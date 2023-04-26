// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetEmploymentRecordByWorkNoResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<CfEmploymentRecordResp> content;

    @NameInMap("requestId")
    public String requestId;

    public static GetEmploymentRecordByWorkNoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEmploymentRecordByWorkNoResponseBody self = new GetEmploymentRecordByWorkNoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEmploymentRecordByWorkNoResponseBody setContent(java.util.List<CfEmploymentRecordResp> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CfEmploymentRecordResp> getContent() {
        return this.content;
    }

    public GetEmploymentRecordByWorkNoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
