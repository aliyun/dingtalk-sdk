// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupRemoveStaticGroupMembersResponseBody extends TeaModel {
    @NameInMap("result")
    public UserGroupRemoveStaticGroupMembersResponseBodyResult result;

    public static UserGroupRemoveStaticGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UserGroupRemoveStaticGroupMembersResponseBody self = new UserGroupRemoveStaticGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public UserGroupRemoveStaticGroupMembersResponseBody setResult(UserGroupRemoveStaticGroupMembersResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UserGroupRemoveStaticGroupMembersResponseBodyResult getResult() {
        return this.result;
    }

    public static class UserGroupRemoveStaticGroupMembersResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static UserGroupRemoveStaticGroupMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UserGroupRemoveStaticGroupMembersResponseBodyResult self = new UserGroupRemoveStaticGroupMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UserGroupRemoveStaticGroupMembersResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
