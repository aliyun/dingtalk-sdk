// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListBasicRoleInPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<ListBasicRoleInPageResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListBasicRoleInPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListBasicRoleInPageResponseBody self = new ListBasicRoleInPageResponseBody();
        return TeaModel.build(map, self);
    }

    public ListBasicRoleInPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListBasicRoleInPageResponseBody setList(java.util.List<ListBasicRoleInPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListBasicRoleInPageResponseBodyList> getList() {
        return this.list;
    }

    public ListBasicRoleInPageResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope extends TeaModel {
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("includeMemberDepts")
        public Boolean includeMemberDepts;

        @NameInMap("includeSelfManageDepts")
        public Boolean includeSelfManageDepts;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope build(java.util.Map<String, ?> map) throws Exception {
            ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope self = new ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope();
            return TeaModel.build(map, self);
        }

        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope setIncludeMemberDepts(Boolean includeMemberDepts) {
            this.includeMemberDepts = includeMemberDepts;
            return this;
        }
        public Boolean getIncludeMemberDepts() {
            return this.includeMemberDepts;
        }

        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope setIncludeSelfManageDepts(Boolean includeSelfManageDepts) {
            this.includeSelfManageDepts = includeSelfManageDepts;
            return this;
        }
        public Boolean getIncludeSelfManageDepts() {
            return this.includeSelfManageDepts;
        }

        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

    public static class ListBasicRoleInPageResponseBodyListOpenActionOpenCondition extends TeaModel {
        @NameInMap("openContactScope")
        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope openContactScope;

        public static ListBasicRoleInPageResponseBodyListOpenActionOpenCondition build(java.util.Map<String, ?> map) throws Exception {
            ListBasicRoleInPageResponseBodyListOpenActionOpenCondition self = new ListBasicRoleInPageResponseBodyListOpenActionOpenCondition();
            return TeaModel.build(map, self);
        }

        public ListBasicRoleInPageResponseBodyListOpenActionOpenCondition setOpenContactScope(ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope openContactScope) {
            this.openContactScope = openContactScope;
            return this;
        }
        public ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope getOpenContactScope() {
            return this.openContactScope;
        }

    }

    public static class ListBasicRoleInPageResponseBodyListOpenAction extends TeaModel {
        @NameInMap("actionIds")
        public java.util.List<String> actionIds;

        @NameInMap("openCondition")
        public ListBasicRoleInPageResponseBodyListOpenActionOpenCondition openCondition;

        public static ListBasicRoleInPageResponseBodyListOpenAction build(java.util.Map<String, ?> map) throws Exception {
            ListBasicRoleInPageResponseBodyListOpenAction self = new ListBasicRoleInPageResponseBodyListOpenAction();
            return TeaModel.build(map, self);
        }

        public ListBasicRoleInPageResponseBodyListOpenAction setActionIds(java.util.List<String> actionIds) {
            this.actionIds = actionIds;
            return this;
        }
        public java.util.List<String> getActionIds() {
            return this.actionIds;
        }

        public ListBasicRoleInPageResponseBodyListOpenAction setOpenCondition(ListBasicRoleInPageResponseBodyListOpenActionOpenCondition openCondition) {
            this.openCondition = openCondition;
            return this;
        }
        public ListBasicRoleInPageResponseBodyListOpenActionOpenCondition getOpenCondition() {
            return this.openCondition;
        }

    }

    public static class ListBasicRoleInPageResponseBodyListOpenMembers extends TeaModel {
        @NameInMap("belongCorpId")
        public String belongCorpId;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public String memberType;

        @NameInMap("operateUserId")
        public String operateUserId;

        public static ListBasicRoleInPageResponseBodyListOpenMembers build(java.util.Map<String, ?> map) throws Exception {
            ListBasicRoleInPageResponseBodyListOpenMembers self = new ListBasicRoleInPageResponseBodyListOpenMembers();
            return TeaModel.build(map, self);
        }

        public ListBasicRoleInPageResponseBodyListOpenMembers setBelongCorpId(String belongCorpId) {
            this.belongCorpId = belongCorpId;
            return this;
        }
        public String getBelongCorpId() {
            return this.belongCorpId;
        }

        public ListBasicRoleInPageResponseBodyListOpenMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListBasicRoleInPageResponseBodyListOpenMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public ListBasicRoleInPageResponseBodyListOpenMembers setOperateUserId(String operateUserId) {
            this.operateUserId = operateUserId;
            return this;
        }
        public String getOperateUserId() {
            return this.operateUserId;
        }

    }

    public static class ListBasicRoleInPageResponseBodyList extends TeaModel {
        @NameInMap("openAction")
        public ListBasicRoleInPageResponseBodyListOpenAction openAction;

        @NameInMap("openMembers")
        public java.util.List<ListBasicRoleInPageResponseBodyListOpenMembers> openMembers;

        @NameInMap("openResources")
        public java.util.List<String> openResources;

        @NameInMap("openRoleId")
        public String openRoleId;

        @NameInMap("openRoleName")
        public String openRoleName;

        public static ListBasicRoleInPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListBasicRoleInPageResponseBodyList self = new ListBasicRoleInPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListBasicRoleInPageResponseBodyList setOpenAction(ListBasicRoleInPageResponseBodyListOpenAction openAction) {
            this.openAction = openAction;
            return this;
        }
        public ListBasicRoleInPageResponseBodyListOpenAction getOpenAction() {
            return this.openAction;
        }

        public ListBasicRoleInPageResponseBodyList setOpenMembers(java.util.List<ListBasicRoleInPageResponseBodyListOpenMembers> openMembers) {
            this.openMembers = openMembers;
            return this;
        }
        public java.util.List<ListBasicRoleInPageResponseBodyListOpenMembers> getOpenMembers() {
            return this.openMembers;
        }

        public ListBasicRoleInPageResponseBodyList setOpenResources(java.util.List<String> openResources) {
            this.openResources = openResources;
            return this;
        }
        public java.util.List<String> getOpenResources() {
            return this.openResources;
        }

        public ListBasicRoleInPageResponseBodyList setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public ListBasicRoleInPageResponseBodyList setOpenRoleName(String openRoleName) {
            this.openRoleName = openRoleName;
            return this;
        }
        public String getOpenRoleName() {
            return this.openRoleName;
        }

    }

}
