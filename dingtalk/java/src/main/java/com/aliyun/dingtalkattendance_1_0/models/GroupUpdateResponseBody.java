// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public java.util.List<GroupUpdateResponseBodyResult> result;

    public static GroupUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupUpdateResponseBody self = new GroupUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupUpdateResponseBody setResult(java.util.List<GroupUpdateResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GroupUpdateResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GroupUpdateResponseBodyResult extends TeaModel {
        // 考勤组id
        @NameInMap("groupId")
        public Long groupId;

        // 考勤组名
        @NameInMap("groupName")
        public String groupName;

        public static GroupUpdateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateResponseBodyResult self = new GroupUpdateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GroupUpdateResponseBodyResult setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public GroupUpdateResponseBodyResult setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
