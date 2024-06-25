// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrcs_call_1_0.models;

import com.aliyun.tea.*;

public class RunCallUserResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true、false</p>
     */
    @NameInMap("success")
    public String success;

    public static RunCallUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RunCallUserResponseBody self = new RunCallUserResponseBody();
        return TeaModel.build(map, self);
    }

    public RunCallUserResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
