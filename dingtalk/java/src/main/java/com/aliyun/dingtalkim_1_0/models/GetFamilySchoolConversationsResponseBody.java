// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationsResponseBody extends TeaModel {
    @NameInMap("groupInfoList")
    public java.util.List<GetFamilySchoolConversationsResponseBodyGroupInfoList> groupInfoList;

    // 是否还有数据
    @NameInMap("hasMore")
    public String hasMore;

    // 返回下一页游标
    @NameInMap("nextToken")
    public String nextToken;

    public static GetFamilySchoolConversationsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFamilySchoolConversationsResponseBody self = new GetFamilySchoolConversationsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFamilySchoolConversationsResponseBody setGroupInfoList(java.util.List<GetFamilySchoolConversationsResponseBodyGroupInfoList> groupInfoList) {
        this.groupInfoList = groupInfoList;
        return this;
    }
    public java.util.List<GetFamilySchoolConversationsResponseBodyGroupInfoList> getGroupInfoList() {
        return this.groupInfoList;
    }

    public GetFamilySchoolConversationsResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public GetFamilySchoolConversationsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class GetFamilySchoolConversationsResponseBodyGroupInfoList extends TeaModel {
        // 企业名称
        @NameInMap("corpId")
        public String corpId;

        // 部门名称链
        @NameInMap("deptNameChain")
        public java.util.List<String> deptNameChain;

        // 群名称
        @NameInMap("groupName")
        public String groupName;

        // 群类型
        @NameInMap("groupType")
        public String groupType;

        // 进群时间
        @NameInMap("joinGroupTime")
        public Long joinGroupTime;

        // 群开放ID
        @NameInMap("openConversationId")
        public String openConversationId;

        public static GetFamilySchoolConversationsResponseBodyGroupInfoList build(java.util.Map<String, ?> map) throws Exception {
            GetFamilySchoolConversationsResponseBodyGroupInfoList self = new GetFamilySchoolConversationsResponseBodyGroupInfoList();
            return TeaModel.build(map, self);
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setDeptNameChain(java.util.List<String> deptNameChain) {
            this.deptNameChain = deptNameChain;
            return this;
        }
        public java.util.List<String> getDeptNameChain() {
            return this.deptNameChain;
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setJoinGroupTime(Long joinGroupTime) {
            this.joinGroupTime = joinGroupTime;
            return this;
        }
        public Long getJoinGroupTime() {
            return this.joinGroupTime;
        }

        public GetFamilySchoolConversationsResponseBodyGroupInfoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
