// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountRobotInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>机器人类型参数，服务窗机器人：1，客户群内机器人：2</p>
     */
    @NameInMap("type")
    public String type;

    public static GetOfficialAccountRobotInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountRobotInfoRequest self = new GetOfficialAccountRobotInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountRobotInfoRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
