// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeletePermissionResponseBody extends TeaModel {
    @NameInMap("data")
    public DeletePermissionResponseBodyData data;

    /**
     * <p>请求成功的标识。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeletePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionResponseBody self = new DeletePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public DeletePermissionResponseBody setData(DeletePermissionResponseBodyData data) {
        this.data = data;
        return this;
    }
    public DeletePermissionResponseBodyData getData() {
        return this.data;
    }

    public DeletePermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeletePermissionResponseBodyDataPolicyListMemberList extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("nickname")
        public String nickname;

        @NameInMap("type")
        public String type;

        public static DeletePermissionResponseBodyDataPolicyListMemberList build(java.util.Map<String, ?> map) throws Exception {
            DeletePermissionResponseBodyDataPolicyListMemberList self = new DeletePermissionResponseBodyDataPolicyListMemberList();
            return TeaModel.build(map, self);
        }

        public DeletePermissionResponseBodyDataPolicyListMemberList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DeletePermissionResponseBodyDataPolicyListMemberList setNickname(String nickname) {
            this.nickname = nickname;
            return this;
        }
        public String getNickname() {
            return this.nickname;
        }

        public DeletePermissionResponseBodyDataPolicyListMemberList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DeletePermissionResponseBodyDataPolicyList extends TeaModel {
        @NameInMap("memberList")
        public java.util.List<DeletePermissionResponseBodyDataPolicyListMemberList> memberList;

        @NameInMap("name")
        public String name;

        @NameInMap("type")
        public Long type;

        public static DeletePermissionResponseBodyDataPolicyList build(java.util.Map<String, ?> map) throws Exception {
            DeletePermissionResponseBodyDataPolicyList self = new DeletePermissionResponseBodyDataPolicyList();
            return TeaModel.build(map, self);
        }

        public DeletePermissionResponseBodyDataPolicyList setMemberList(java.util.List<DeletePermissionResponseBodyDataPolicyListMemberList> memberList) {
            this.memberList = memberList;
            return this;
        }
        public java.util.List<DeletePermissionResponseBodyDataPolicyListMemberList> getMemberList() {
            return this.memberList;
        }

        public DeletePermissionResponseBodyDataPolicyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DeletePermissionResponseBodyDataPolicyList setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

    }

    public static class DeletePermissionResponseBodyData extends TeaModel {
        @NameInMap("id")
        public String id;

        /**
         * <p>权限列表</p>
         */
        @NameInMap("policyList")
        public java.util.List<DeletePermissionResponseBodyDataPolicyList> policyList;

        /**
         * <p>是否可见的标识。</p>
         */
        @NameInMap("privacy")
        public String privacy;

        /**
         * <p>哪种类型的权限。</p>
         */
        @NameInMap("type")
        public String type;

        public static DeletePermissionResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            DeletePermissionResponseBodyData self = new DeletePermissionResponseBodyData();
            return TeaModel.build(map, self);
        }

        public DeletePermissionResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DeletePermissionResponseBodyData setPolicyList(java.util.List<DeletePermissionResponseBodyDataPolicyList> policyList) {
            this.policyList = policyList;
            return this;
        }
        public java.util.List<DeletePermissionResponseBodyDataPolicyList> getPolicyList() {
            return this.policyList;
        }

        public DeletePermissionResponseBodyData setPrivacy(String privacy) {
            this.privacy = privacy;
            return this;
        }
        public String getPrivacy() {
            return this.privacy;
        }

        public DeletePermissionResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
