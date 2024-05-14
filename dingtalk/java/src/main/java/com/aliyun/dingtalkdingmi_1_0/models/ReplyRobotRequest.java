// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class ReplyRobotRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("proxyMessageStr")
    public String proxyMessageStr;

    public static ReplyRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        ReplyRobotRequest self = new ReplyRobotRequest();
        return TeaModel.build(map, self);
    }

    public ReplyRobotRequest setProxyMessageStr(String proxyMessageStr) {
        this.proxyMessageStr = proxyMessageStr;
        return this;
    }
    public String getProxyMessageStr() {
        return this.proxyMessageStr;
    }

}
