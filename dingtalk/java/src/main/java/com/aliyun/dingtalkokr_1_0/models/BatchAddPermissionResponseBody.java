// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchAddPermissionResponseBody extends TeaModel {
    // 返回的数据。
    @NameInMap("data")
    public BatchAddPermissionResponseBodyData data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static BatchAddPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddPermissionResponseBody self = new BatchAddPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddPermissionResponseBody setData(BatchAddPermissionResponseBodyData data) {
        this.data = data;
        return this;
    }
    public BatchAddPermissionResponseBodyData getData() {
        return this.data;
    }

    public BatchAddPermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("nickname")
        public String nickname;

        @NameInMap("type")
        public String type;

        public static BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList self = new BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList setNickname(String nickname) {
            this.nickname = nickname;
            return this;
        }
        public String getNickname() {
            return this.nickname;
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class BatchAddPermissionResponseBodyDataPermissionTreePolicyList extends TeaModel {
        @NameInMap("memberList")
        public java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList> memberList;

        @NameInMap("name")
        public String name;

        @NameInMap("type")
        public Long type;

        public static BatchAddPermissionResponseBodyDataPermissionTreePolicyList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionResponseBodyDataPermissionTreePolicyList self = new BatchAddPermissionResponseBodyDataPermissionTreePolicyList();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyList setMemberList(java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList> memberList) {
            this.memberList = memberList;
            return this;
        }
        public java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList> getMemberList() {
            return this.memberList;
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchAddPermissionResponseBodyDataPermissionTreePolicyList setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

    }

    public static class BatchAddPermissionResponseBodyDataPermissionTree extends TeaModel {
        // 权限 ID。
        @NameInMap("id")
        public String id;

        // 权限列表
        @NameInMap("policyList")
        public java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyList> policyList;

        // 是否可见的标识。
        @NameInMap("privacy")
        public String privacy;

        // 哪种类型的权限。
        @NameInMap("type")
        public String type;

        public static BatchAddPermissionResponseBodyDataPermissionTree build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionResponseBodyDataPermissionTree self = new BatchAddPermissionResponseBodyDataPermissionTree();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionResponseBodyDataPermissionTree setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public BatchAddPermissionResponseBodyDataPermissionTree setPolicyList(java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyList> policyList) {
            this.policyList = policyList;
            return this;
        }
        public java.util.List<BatchAddPermissionResponseBodyDataPermissionTreePolicyList> getPolicyList() {
            return this.policyList;
        }

        public BatchAddPermissionResponseBodyDataPermissionTree setPrivacy(String privacy) {
            this.privacy = privacy;
            return this;
        }
        public String getPrivacy() {
            return this.privacy;
        }

        public BatchAddPermissionResponseBodyDataPermissionTree setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class BatchAddPermissionResponseBodyData extends TeaModel {
        // 是否有无效的成员。
        @NameInMap("hasInvalidUser")
        public Boolean hasInvalidUser;

        // 权限信息。
        @NameInMap("permissionTree")
        public BatchAddPermissionResponseBodyDataPermissionTree permissionTree;

        public static BatchAddPermissionResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionResponseBodyData self = new BatchAddPermissionResponseBodyData();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionResponseBodyData setHasInvalidUser(Boolean hasInvalidUser) {
            this.hasInvalidUser = hasInvalidUser;
            return this;
        }
        public Boolean getHasInvalidUser() {
            return this.hasInvalidUser;
        }

        public BatchAddPermissionResponseBodyData setPermissionTree(BatchAddPermissionResponseBodyDataPermissionTree permissionTree) {
            this.permissionTree = permissionTree;
            return this;
        }
        public BatchAddPermissionResponseBodyDataPermissionTree getPermissionTree() {
            return this.permissionTree;
        }

    }

}
