// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupAddResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public java.util.List<GroupAddResponseBodyResult> result;

    public static GroupAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupAddResponseBody self = new GroupAddResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupAddResponseBody setResult(java.util.List<GroupAddResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GroupAddResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GroupAddResponseBodyResult extends TeaModel {
        /**
         * <p>考勤组id</p>
         */
        @NameInMap("groupId")
        public Long groupId;

        /**
         * <p>考勤组名</p>
         */
        @NameInMap("groupName")
        public String groupName;

        public static GroupAddResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GroupAddResponseBodyResult self = new GroupAddResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GroupAddResponseBodyResult setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public GroupAddResponseBodyResult setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
