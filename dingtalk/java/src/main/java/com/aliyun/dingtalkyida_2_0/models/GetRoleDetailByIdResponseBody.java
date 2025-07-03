// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetRoleDetailByIdResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRoleDetailByIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetRoleDetailByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRoleDetailByIdResponseBody self = new GetRoleDetailByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRoleDetailByIdResponseBody setResult(GetRoleDetailByIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRoleDetailByIdResponseBodyResult getResult() {
        return this.result;
    }

    public GetRoleDetailByIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetRoleDetailByIdResponseBodyResultMembers extends TeaModel {
        @NameInMap("currentPage")
        public Integer currentPage;

        @NameInMap("data")
        public Object data;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static GetRoleDetailByIdResponseBodyResultMembers build(java.util.Map<String, ?> map) throws Exception {
            GetRoleDetailByIdResponseBodyResultMembers self = new GetRoleDetailByIdResponseBodyResultMembers();
            return TeaModel.build(map, self);
        }

        public GetRoleDetailByIdResponseBodyResultMembers setCurrentPage(Integer currentPage) {
            this.currentPage = currentPage;
            return this;
        }
        public Integer getCurrentPage() {
            return this.currentPage;
        }

        public GetRoleDetailByIdResponseBodyResultMembers setData(Object data) {
            this.data = data;
            return this;
        }
        public Object getData() {
            return this.data;
        }

        public GetRoleDetailByIdResponseBodyResultMembers setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetRoleDetailByIdResponseBodyResult extends TeaModel {
        @NameInMap("canModifyOwners")
        public Object canModifyOwners;

        @NameInMap("description")
        public String description;

        @NameInMap("memberTotalCount")
        public Integer memberTotalCount;

        @NameInMap("members")
        public GetRoleDetailByIdResponseBodyResultMembers members;

        @NameInMap("name")
        public String name;

        @NameInMap("parentUuid")
        public String parentUuid;

        @NameInMap("roleUuid")
        public String roleUuid;

        public static GetRoleDetailByIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRoleDetailByIdResponseBodyResult self = new GetRoleDetailByIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRoleDetailByIdResponseBodyResult setCanModifyOwners(Object canModifyOwners) {
            this.canModifyOwners = canModifyOwners;
            return this;
        }
        public Object getCanModifyOwners() {
            return this.canModifyOwners;
        }

        public GetRoleDetailByIdResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetRoleDetailByIdResponseBodyResult setMemberTotalCount(Integer memberTotalCount) {
            this.memberTotalCount = memberTotalCount;
            return this;
        }
        public Integer getMemberTotalCount() {
            return this.memberTotalCount;
        }

        public GetRoleDetailByIdResponseBodyResult setMembers(GetRoleDetailByIdResponseBodyResultMembers members) {
            this.members = members;
            return this;
        }
        public GetRoleDetailByIdResponseBodyResultMembers getMembers() {
            return this.members;
        }

        public GetRoleDetailByIdResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRoleDetailByIdResponseBodyResult setParentUuid(String parentUuid) {
            this.parentUuid = parentUuid;
            return this;
        }
        public String getParentUuid() {
            return this.parentUuid;
        }

        public GetRoleDetailByIdResponseBodyResult setRoleUuid(String roleUuid) {
            this.roleUuid = roleUuid;
            return this;
        }
        public String getRoleUuid() {
            return this.roleUuid;
        }

    }

}
