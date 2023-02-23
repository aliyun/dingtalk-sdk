// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageResponseBody extends TeaModel {
    /**
     * <p>本次操作是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SendRobotMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageResponseBody self = new SendRobotMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendRobotMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
