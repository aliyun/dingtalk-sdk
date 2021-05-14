// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class ReplyRobotResponseBody extends TeaModel {
    // 回复是否成功结果
    @NameInMap("result")
    public Boolean result;

    public static ReplyRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReplyRobotResponseBody self = new ReplyRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public ReplyRobotResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
