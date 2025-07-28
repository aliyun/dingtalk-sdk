// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotDingReadStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>openDingId</p>
     */
    @NameInMap("openDingId")
    public String openDingId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static QueryRobotDingReadStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotDingReadStatusRequest self = new QueryRobotDingReadStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryRobotDingReadStatusRequest setOpenDingId(String openDingId) {
        this.openDingId = openDingId;
        return this;
    }
    public String getOpenDingId() {
        return this.openDingId;
    }

    public QueryRobotDingReadStatusRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
