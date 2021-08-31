// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTaskStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CheckUserTaskStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTaskStatusResponseBody self = new CheckUserTaskStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckUserTaskStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
