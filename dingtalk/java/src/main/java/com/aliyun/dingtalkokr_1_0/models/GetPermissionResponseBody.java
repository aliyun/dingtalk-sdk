// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetPermissionResponseBody extends TeaModel {
    /**
     * <p>返回的数据。</p>
     */
    @NameInMap("data")
    public GetPermissionResponseBodyData data;

    /**
     * <p>请求成功的标识。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionResponseBody self = new GetPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPermissionResponseBody setData(GetPermissionResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetPermissionResponseBodyData getData() {
        return this.data;
    }

    public GetPermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetPermissionResponseBodyDataPolicyListMemberList extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("nickname")
        public String nickname;

        @NameInMap("type")
        public String type;

        public static GetPermissionResponseBodyDataPolicyListMemberList build(java.util.Map<String, ?> map) throws Exception {
            GetPermissionResponseBodyDataPolicyListMemberList self = new GetPermissionResponseBodyDataPolicyListMemberList();
            return TeaModel.build(map, self);
        }

        public GetPermissionResponseBodyDataPolicyListMemberList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetPermissionResponseBodyDataPolicyListMemberList setNickname(String nickname) {
            this.nickname = nickname;
            return this;
        }
        public String getNickname() {
            return this.nickname;
        }

        public GetPermissionResponseBodyDataPolicyListMemberList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetPermissionResponseBodyDataPolicyList extends TeaModel {
        @NameInMap("memberList")
        public java.util.List<GetPermissionResponseBodyDataPolicyListMemberList> memberList;

        @NameInMap("name")
        public String name;

        @NameInMap("type")
        public Long type;

        public static GetPermissionResponseBodyDataPolicyList build(java.util.Map<String, ?> map) throws Exception {
            GetPermissionResponseBodyDataPolicyList self = new GetPermissionResponseBodyDataPolicyList();
            return TeaModel.build(map, self);
        }

        public GetPermissionResponseBodyDataPolicyList setMemberList(java.util.List<GetPermissionResponseBodyDataPolicyListMemberList> memberList) {
            this.memberList = memberList;
            return this;
        }
        public java.util.List<GetPermissionResponseBodyDataPolicyListMemberList> getMemberList() {
            return this.memberList;
        }

        public GetPermissionResponseBodyDataPolicyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetPermissionResponseBodyDataPolicyList setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

    }

    public static class GetPermissionResponseBodyData extends TeaModel {
        @NameInMap("id")
        public String id;

        /**
         * <p>权限列表</p>
         */
        @NameInMap("policyList")
        public java.util.List<GetPermissionResponseBodyDataPolicyList> policyList;

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

        public static GetPermissionResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPermissionResponseBodyData self = new GetPermissionResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPermissionResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetPermissionResponseBodyData setPolicyList(java.util.List<GetPermissionResponseBodyDataPolicyList> policyList) {
            this.policyList = policyList;
            return this;
        }
        public java.util.List<GetPermissionResponseBodyDataPolicyList> getPolicyList() {
            return this.policyList;
        }

        public GetPermissionResponseBodyData setPrivacy(String privacy) {
            this.privacy = privacy;
            return this;
        }
        public String getPrivacy() {
            return this.privacy;
        }

        public GetPermissionResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
