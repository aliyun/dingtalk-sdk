// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardNewResponseBody extends TeaModel {
    @NameInMap("isDeleted")
    public Boolean isDeleted;

    @NameInMap("success")
    public Boolean success;

    public static DeleteGroupBlackboardNewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardNewResponseBody self = new DeleteGroupBlackboardNewResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardNewResponseBody setIsDeleted(Boolean isDeleted) {
        this.isDeleted = isDeleted;
        return this;
    }
    public Boolean getIsDeleted() {
        return this.isDeleted;
    }

    public DeleteGroupBlackboardNewResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
