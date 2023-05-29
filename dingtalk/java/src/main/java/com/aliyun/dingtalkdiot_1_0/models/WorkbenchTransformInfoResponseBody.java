// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class WorkbenchTransformInfoResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static WorkbenchTransformInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WorkbenchTransformInfoResponseBody self = new WorkbenchTransformInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public WorkbenchTransformInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
