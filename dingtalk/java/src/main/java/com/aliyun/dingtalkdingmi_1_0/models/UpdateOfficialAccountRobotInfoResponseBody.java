// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class UpdateOfficialAccountRobotInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public String result;

    public static UpdateOfficialAccountRobotInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOfficialAccountRobotInfoResponseBody self = new UpdateOfficialAccountRobotInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOfficialAccountRobotInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
