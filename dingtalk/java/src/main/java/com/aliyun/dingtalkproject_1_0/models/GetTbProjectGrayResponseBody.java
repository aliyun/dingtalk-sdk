// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectGrayResponseBody extends TeaModel {
    // 是否灰度
    @NameInMap("result")
    public Boolean result;

    @NameInMap("requestId")
    public String requestId;

    public static GetTbProjectGrayResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectGrayResponseBody self = new GetTbProjectGrayResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTbProjectGrayResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public GetTbProjectGrayResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
