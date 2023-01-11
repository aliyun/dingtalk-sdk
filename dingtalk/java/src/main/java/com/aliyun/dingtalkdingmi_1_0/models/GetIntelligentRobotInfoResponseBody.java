// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetIntelligentRobotInfoResponseBody extends TeaModel {
    /**
     * <p>机器人id</p>
     */
    @NameInMap("result")
    public String result;

    public static GetIntelligentRobotInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIntelligentRobotInfoResponseBody self = new GetIntelligentRobotInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIntelligentRobotInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
