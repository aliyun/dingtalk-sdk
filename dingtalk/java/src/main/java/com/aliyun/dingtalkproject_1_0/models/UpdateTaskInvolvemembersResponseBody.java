// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskInvolvemembersResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskInvolvemembersResponseBodyResult result;

    public static UpdateTaskInvolvemembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskInvolvemembersResponseBody self = new UpdateTaskInvolvemembersResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskInvolvemembersResponseBody setResult(UpdateTaskInvolvemembersResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskInvolvemembersResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskInvolvemembersResponseBodyResult extends TeaModel {
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskInvolvemembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskInvolvemembersResponseBodyResult self = new UpdateTaskInvolvemembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskInvolvemembersResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public UpdateTaskInvolvemembersResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
