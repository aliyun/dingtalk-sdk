// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardResponseBody extends TeaModel {
    // 是否成功删除
    @NameInMap("isDeleted")
    public Boolean isDeleted;

    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    public static DeleteGroupBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardResponseBody self = new DeleteGroupBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardResponseBody setIsDeleted(Boolean isDeleted) {
        this.isDeleted = isDeleted;
        return this;
    }
    public Boolean getIsDeleted() {
        return this.isDeleted;
    }

    public DeleteGroupBlackboardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
