// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupInfoByCidResponseBody extends TeaModel {
    @NameInMap("groupInfo")
    public GetGroupInfoByCidResponseBodyGroupInfo groupInfo;

    public static GetGroupInfoByCidResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupInfoByCidResponseBody self = new GetGroupInfoByCidResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupInfoByCidResponseBody setGroupInfo(GetGroupInfoByCidResponseBodyGroupInfo groupInfo) {
        this.groupInfo = groupInfo;
        return this;
    }
    public GetGroupInfoByCidResponseBodyGroupInfo getGroupInfo() {
        return this.groupInfo;
    }

    public static class GetGroupInfoByCidResponseBodyGroupInfo extends TeaModel {
        @NameInMap("allOrgMember")
        public Boolean allOrgMember;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupNumber")
        public Long groupNumber;

        @NameInMap("groupOrganization")
        public String groupOrganization;

        @NameInMap("joinGroupUrl")
        public String joinGroupUrl;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static GetGroupInfoByCidResponseBodyGroupInfo build(java.util.Map<String, ?> map) throws Exception {
            GetGroupInfoByCidResponseBodyGroupInfo self = new GetGroupInfoByCidResponseBodyGroupInfo();
            return TeaModel.build(map, self);
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setAllOrgMember(Boolean allOrgMember) {
            this.allOrgMember = allOrgMember;
            return this;
        }
        public Boolean getAllOrgMember() {
            return this.allOrgMember;
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setGroupNumber(Long groupNumber) {
            this.groupNumber = groupNumber;
            return this;
        }
        public Long getGroupNumber() {
            return this.groupNumber;
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setGroupOrganization(String groupOrganization) {
            this.groupOrganization = groupOrganization;
            return this;
        }
        public String getGroupOrganization() {
            return this.groupOrganization;
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setJoinGroupUrl(String joinGroupUrl) {
            this.joinGroupUrl = joinGroupUrl;
            return this;
        }
        public String getJoinGroupUrl() {
            return this.joinGroupUrl;
        }

        public GetGroupInfoByCidResponseBodyGroupInfo setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
