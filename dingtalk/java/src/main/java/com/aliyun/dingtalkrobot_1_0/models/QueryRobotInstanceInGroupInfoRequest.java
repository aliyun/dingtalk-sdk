// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotInstanceInGroupInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResult")
    public Integer maxResult;

    /**
     * <strong>example:</strong>
     * <p>v1:123456</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxcll27gm</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static QueryRobotInstanceInGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotInstanceInGroupInfoRequest self = new QueryRobotInstanceInGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryRobotInstanceInGroupInfoRequest setMaxResult(Integer maxResult) {
        this.maxResult = maxResult;
        return this;
    }
    public Integer getMaxResult() {
        return this.maxResult;
    }

    public QueryRobotInstanceInGroupInfoRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRobotInstanceInGroupInfoRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
