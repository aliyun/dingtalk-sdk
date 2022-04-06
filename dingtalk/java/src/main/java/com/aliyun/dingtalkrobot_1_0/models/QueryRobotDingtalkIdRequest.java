// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotDingtalkIdRequest extends TeaModel {
    // 机器人robotCode
    @NameInMap("robotCode")
    public String robotCode;

    public static QueryRobotDingtalkIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotDingtalkIdRequest self = new QueryRobotDingtalkIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryRobotDingtalkIdRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
