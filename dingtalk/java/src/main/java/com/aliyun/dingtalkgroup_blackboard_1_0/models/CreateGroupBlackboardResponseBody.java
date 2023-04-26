// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupBlackboardResponseBody extends TeaModel {
    @NameInMap("dataId")
    public String dataId;

    @NameInMap("success")
    public Boolean success;

    public static CreateGroupBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupBlackboardResponseBody self = new CreateGroupBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupBlackboardResponseBody setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public CreateGroupBlackboardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
