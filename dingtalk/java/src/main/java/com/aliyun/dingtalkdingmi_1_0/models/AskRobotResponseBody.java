// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotResponseBody extends TeaModel {
    // 答案的json string
    @NameInMap("result")
    public String result;

    public static AskRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AskRobotResponseBody self = new AskRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public AskRobotResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
