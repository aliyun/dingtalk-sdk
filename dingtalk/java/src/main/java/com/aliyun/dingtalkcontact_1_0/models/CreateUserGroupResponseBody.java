// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateUserGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateUserGroupResponseBodyResult result;

    public static CreateUserGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateUserGroupResponseBody self = new CreateUserGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateUserGroupResponseBody setResult(CreateUserGroupResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateUserGroupResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateUserGroupResponseBodyResult extends TeaModel {
        @NameInMap("groupCode")
        public String groupCode;

        public static CreateUserGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateUserGroupResponseBodyResult self = new CreateUserGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateUserGroupResponseBodyResult setGroupCode(String groupCode) {
            this.groupCode = groupCode;
            return this;
        }
        public String getGroupCode() {
            return this.groupCode;
        }

    }

}
