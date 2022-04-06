// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotDingtalkIdResponseBody extends TeaModel {
    // 机器人dingtalkId
    @NameInMap("dingtalkId")
    public String dingtalkId;

    public static QueryRobotDingtalkIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotDingtalkIdResponseBody self = new QueryRobotDingtalkIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRobotDingtalkIdResponseBody setDingtalkId(String dingtalkId) {
        this.dingtalkId = dingtalkId;
        return this;
    }
    public String getDingtalkId() {
        return this.dingtalkId;
    }

}
