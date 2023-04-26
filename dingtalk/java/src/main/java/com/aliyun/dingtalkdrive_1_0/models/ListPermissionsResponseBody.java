// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListPermissionsResponseBody extends TeaModel {
    @NameInMap("members")
    public java.util.List<ListPermissionsResponseBodyMembers> members;

    @NameInMap("outMembers")
    public java.util.List<ListPermissionsResponseBodyOutMembers> outMembers;

    public static ListPermissionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPermissionsResponseBody self = new ListPermissionsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPermissionsResponseBody setMembers(java.util.List<ListPermissionsResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<ListPermissionsResponseBodyMembers> getMembers() {
        return this.members;
    }

    public ListPermissionsResponseBody setOutMembers(java.util.List<ListPermissionsResponseBodyOutMembers> outMembers) {
        this.outMembers = outMembers;
        return this;
    }
    public java.util.List<ListPermissionsResponseBodyOutMembers> getOutMembers() {
        return this.outMembers;
    }

    public static class ListPermissionsResponseBodyMembersMember extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberName")
        public String memberName;

        @NameInMap("memberType")
        public String memberType;

        public static ListPermissionsResponseBodyMembersMember build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyMembersMember self = new ListPermissionsResponseBodyMembersMember();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyMembersMember setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPermissionsResponseBodyMembersMember setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListPermissionsResponseBodyMembersMember setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public ListPermissionsResponseBodyMembersMember setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class ListPermissionsResponseBodyMembers extends TeaModel {
        @NameInMap("extend")
        public Boolean extend;

        @NameInMap("member")
        public ListPermissionsResponseBodyMembersMember member;

        @NameInMap("role")
        public String role;

        public static ListPermissionsResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyMembers self = new ListPermissionsResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyMembers setExtend(Boolean extend) {
            this.extend = extend;
            return this;
        }
        public Boolean getExtend() {
            return this.extend;
        }

        public ListPermissionsResponseBodyMembers setMember(ListPermissionsResponseBodyMembersMember member) {
            this.member = member;
            return this;
        }
        public ListPermissionsResponseBodyMembersMember getMember() {
            return this.member;
        }

        public ListPermissionsResponseBodyMembers setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

    public static class ListPermissionsResponseBodyOutMembersMember extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberName")
        public String memberName;

        @NameInMap("memberType")
        public String memberType;

        public static ListPermissionsResponseBodyOutMembersMember build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyOutMembersMember self = new ListPermissionsResponseBodyOutMembersMember();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyOutMembersMember setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPermissionsResponseBodyOutMembersMember setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListPermissionsResponseBodyOutMembersMember setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public ListPermissionsResponseBodyOutMembersMember setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class ListPermissionsResponseBodyOutMembers extends TeaModel {
        @NameInMap("extend")
        public Boolean extend;

        @NameInMap("member")
        public ListPermissionsResponseBodyOutMembersMember member;

        @NameInMap("role")
        public String role;

        public static ListPermissionsResponseBodyOutMembers build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyOutMembers self = new ListPermissionsResponseBodyOutMembers();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyOutMembers setExtend(Boolean extend) {
            this.extend = extend;
            return this;
        }
        public Boolean getExtend() {
            return this.extend;
        }

        public ListPermissionsResponseBodyOutMembers setMember(ListPermissionsResponseBodyOutMembersMember member) {
            this.member = member;
            return this;
        }
        public ListPermissionsResponseBodyOutMembersMember getMember() {
            return this.member;
        }

        public ListPermissionsResponseBodyOutMembers setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

}
