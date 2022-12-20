// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddLeadsResponseBody extends TeaModel {
    @NameInMap("outTaskId")
    public String outTaskId;

    public static AddLeadsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddLeadsResponseBody self = new AddLeadsResponseBody();
        return TeaModel.build(map, self);
    }

    public AddLeadsResponseBody setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

}
