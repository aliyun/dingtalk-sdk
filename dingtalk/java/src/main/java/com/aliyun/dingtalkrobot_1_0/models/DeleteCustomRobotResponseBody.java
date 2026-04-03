// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class DeleteCustomRobotResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteCustomRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCustomRobotResponseBody self = new DeleteCustomRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCustomRobotResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
