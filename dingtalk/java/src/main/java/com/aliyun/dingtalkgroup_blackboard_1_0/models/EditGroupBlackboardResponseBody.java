// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class EditGroupBlackboardResponseBody extends TeaModel {
    @NameInMap("dataId")
    public String dataId;

    @NameInMap("success")
    public Boolean success;

    public static EditGroupBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditGroupBlackboardResponseBody self = new EditGroupBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public EditGroupBlackboardResponseBody setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public EditGroupBlackboardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
