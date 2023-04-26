// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CleanProcessDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CleanProcessDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CleanProcessDataResponseBody self = new CleanProcessDataResponseBody();
        return TeaModel.build(map, self);
    }

    public CleanProcessDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
