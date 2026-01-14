// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionResponseBody extends TeaModel {
    @NameInMap("failMemberInfoList")
    public java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> failMemberInfoList;

    public static UpdatePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionResponseBody self = new UpdatePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionResponseBody setFailMemberInfoList(java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> failMemberInfoList) {
        this.failMemberInfoList = failMemberInfoList;
        return this;
    }
    public java.util.List<UpdatePermissionResponseBodyFailMemberInfoList> getFailMemberInfoList() {
        return this.failMemberInfoList;
    }

    public static class UpdatePermissionResponseBodyFailMemberInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <strong>example:</strong>
         * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
         */
        @NameInMap("memberUnionId")
        public String memberUnionId;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("policyId")
        public Long policyId;

        public static UpdatePermissionResponseBodyFailMemberInfoList build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionResponseBodyFailMemberInfoList self = new UpdatePermissionResponseBodyFailMemberInfoList();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setMemberUnionId(String memberUnionId) {
            this.memberUnionId = memberUnionId;
            return this;
        }
        public String getMemberUnionId() {
            return this.memberUnionId;
        }

        public UpdatePermissionResponseBodyFailMemberInfoList setPolicyId(Long policyId) {
            this.policyId = policyId;
            return this;
        }
        public Long getPolicyId() {
            return this.policyId;
        }

    }

}
