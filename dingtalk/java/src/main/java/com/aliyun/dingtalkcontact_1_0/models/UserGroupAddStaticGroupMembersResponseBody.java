// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupAddStaticGroupMembersResponseBody extends TeaModel {
    @NameInMap("result")
    public UserGroupAddStaticGroupMembersResponseBodyResult result;

    public static UserGroupAddStaticGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UserGroupAddStaticGroupMembersResponseBody self = new UserGroupAddStaticGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public UserGroupAddStaticGroupMembersResponseBody setResult(UserGroupAddStaticGroupMembersResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UserGroupAddStaticGroupMembersResponseBodyResult getResult() {
        return this.result;
    }

    public static class UserGroupAddStaticGroupMembersResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static UserGroupAddStaticGroupMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UserGroupAddStaticGroupMembersResponseBodyResult self = new UserGroupAddStaticGroupMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UserGroupAddStaticGroupMembersResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
