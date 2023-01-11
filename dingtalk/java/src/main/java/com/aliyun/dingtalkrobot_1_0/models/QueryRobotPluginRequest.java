// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotPluginRequest extends TeaModel {
    /**
     * <p>钉钉开放平台后台机器人的robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static QueryRobotPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotPluginRequest self = new QueryRobotPluginRequest();
        return TeaModel.build(map, self);
    }

    public QueryRobotPluginRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
