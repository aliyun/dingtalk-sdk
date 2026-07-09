// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteUserGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public DeleteUserGroupResponseBodyResult result;

    public static DeleteUserGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteUserGroupResponseBody self = new DeleteUserGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteUserGroupResponseBody setResult(DeleteUserGroupResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeleteUserGroupResponseBodyResult getResult() {
        return this.result;
    }

    public static class DeleteUserGroupResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static DeleteUserGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteUserGroupResponseBodyResult self = new DeleteUserGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeleteUserGroupResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
