// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ReverseTrialAdvancedLeaveResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static ReverseTrialAdvancedLeaveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReverseTrialAdvancedLeaveResponseBody self = new ReverseTrialAdvancedLeaveResponseBody();
        return TeaModel.build(map, self);
    }

    public ReverseTrialAdvancedLeaveResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ReverseTrialAdvancedLeaveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
