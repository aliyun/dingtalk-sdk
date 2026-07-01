// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetTeamMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTeamMemberResponseBodyResult result;

    public static GetTeamMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTeamMemberResponseBody self = new GetTeamMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTeamMemberResponseBody setResult(GetTeamMemberResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTeamMemberResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetTeamMemberResponseBodyResultAdmins extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetTeamMemberResponseBodyResultAdmins build(java.util.Map<String, ?> map) throws Exception {
            GetTeamMemberResponseBodyResultAdmins self = new GetTeamMemberResponseBodyResultAdmins();
            return TeaModel.build(map, self);
        }

        public GetTeamMemberResponseBodyResultAdmins setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTeamMemberResponseBodyResultAdmins setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetTeamMemberResponseBodyResultDepts extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        public static GetTeamMemberResponseBodyResultDepts build(java.util.Map<String, ?> map) throws Exception {
            GetTeamMemberResponseBodyResultDepts self = new GetTeamMemberResponseBodyResultDepts();
            return TeaModel.build(map, self);
        }

        public GetTeamMemberResponseBodyResultDepts setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetTeamMemberResponseBodyResultDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetTeamMemberResponseBodyResultMembers extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetTeamMemberResponseBodyResultMembers build(java.util.Map<String, ?> map) throws Exception {
            GetTeamMemberResponseBodyResultMembers self = new GetTeamMemberResponseBodyResultMembers();
            return TeaModel.build(map, self);
        }

        public GetTeamMemberResponseBodyResultMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTeamMemberResponseBodyResultMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetTeamMemberResponseBodyResult extends TeaModel {
        @NameInMap("admins")
        public java.util.List<GetTeamMemberResponseBodyResultAdmins> admins;

        @NameInMap("depts")
        public java.util.List<GetTeamMemberResponseBodyResultDepts> depts;

        @NameInMap("members")
        public java.util.List<GetTeamMemberResponseBodyResultMembers> members;

        public static GetTeamMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTeamMemberResponseBodyResult self = new GetTeamMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTeamMemberResponseBodyResult setAdmins(java.util.List<GetTeamMemberResponseBodyResultAdmins> admins) {
            this.admins = admins;
            return this;
        }
        public java.util.List<GetTeamMemberResponseBodyResultAdmins> getAdmins() {
            return this.admins;
        }

        public GetTeamMemberResponseBodyResult setDepts(java.util.List<GetTeamMemberResponseBodyResultDepts> depts) {
            this.depts = depts;
            return this;
        }
        public java.util.List<GetTeamMemberResponseBodyResultDepts> getDepts() {
            return this.depts;
        }

        public GetTeamMemberResponseBodyResult setMembers(java.util.List<GetTeamMemberResponseBodyResultMembers> members) {
            this.members = members;
            return this;
        }
        public java.util.List<GetTeamMemberResponseBodyResultMembers> getMembers() {
            return this.members;
        }

    }

}
