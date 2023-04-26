// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListDeptMembersResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<SupplyListDeptMembersResponseBodyList> list;

    public static SupplyListDeptMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListDeptMembersResponseBody self = new SupplyListDeptMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListDeptMembersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SupplyListDeptMembersResponseBody setList(java.util.List<SupplyListDeptMembersResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<SupplyListDeptMembersResponseBodyList> getList() {
        return this.list;
    }

    public static class SupplyListDeptMembersResponseBodyList extends TeaModel {
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        @NameInMap("isActive")
        public Boolean isActive;

        @NameInMap("memberName")
        public String memberName;

        @NameInMap("memberWorkNumber")
        public String memberWorkNumber;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static SupplyListDeptMembersResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            SupplyListDeptMembersResponseBodyList self = new SupplyListDeptMembersResponseBodyList();
            return TeaModel.build(map, self);
        }

        public SupplyListDeptMembersResponseBodyList setDingMemberStatus(String dingMemberStatus) {
            this.dingMemberStatus = dingMemberStatus;
            return this;
        }
        public String getDingMemberStatus() {
            return this.dingMemberStatus;
        }

        public SupplyListDeptMembersResponseBodyList setIsActive(Boolean isActive) {
            this.isActive = isActive;
            return this;
        }
        public Boolean getIsActive() {
            return this.isActive;
        }

        public SupplyListDeptMembersResponseBodyList setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public SupplyListDeptMembersResponseBodyList setMemberWorkNumber(String memberWorkNumber) {
            this.memberWorkNumber = memberWorkNumber;
            return this;
        }
        public String getMemberWorkNumber() {
            return this.memberWorkNumber;
        }

        public SupplyListDeptMembersResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public SupplyListDeptMembersResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
