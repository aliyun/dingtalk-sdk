// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetIntelligentRobotInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd1234</p>
     */
    @NameInMap("robotAppKey")
    public String robotAppKey;

    public static GetIntelligentRobotInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetIntelligentRobotInfoRequest self = new GetIntelligentRobotInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetIntelligentRobotInfoRequest setRobotAppKey(String robotAppKey) {
        this.robotAppKey = robotAppKey;
        return this;
    }
    public String getRobotAppKey() {
        return this.robotAppKey;
    }

}
