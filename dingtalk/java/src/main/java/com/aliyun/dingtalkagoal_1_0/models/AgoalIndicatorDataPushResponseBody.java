// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorDataPushResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalIndicatorDataPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorDataPushResponseBody self = new AgoalIndicatorDataPushResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorDataPushResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalIndicatorDataPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
