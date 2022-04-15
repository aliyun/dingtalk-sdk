// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupRecallResponseBody extends TeaModel {
    // 撤回失败的消息id及原因
    @NameInMap("failedResult")
    public java.util.Map<String, String> failedResult;

    // 撤回成功的消息id
    @NameInMap("successResult")
    public java.util.List<String> successResult;

    public static OrgGroupRecallResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupRecallResponseBody self = new OrgGroupRecallResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgGroupRecallResponseBody setFailedResult(java.util.Map<String, String> failedResult) {
        this.failedResult = failedResult;
        return this;
    }
    public java.util.Map<String, String> getFailedResult() {
        return this.failedResult;
    }

    public OrgGroupRecallResponseBody setSuccessResult(java.util.List<String> successResult) {
        this.successResult = successResult;
        return this;
    }
    public java.util.List<String> getSuccessResult() {
        return this.successResult;
    }

}
