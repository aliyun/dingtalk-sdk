// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskInvolveMembersResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskInvolveMembersResponseBodyResult result;

    public static UpdateOrganizationTaskInvolveMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskInvolveMembersResponseBody self = new UpdateOrganizationTaskInvolveMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskInvolveMembersResponseBody setResult(UpdateOrganizationTaskInvolveMembersResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskInvolveMembersResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers self = new UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class UpdateOrganizationTaskInvolveMembersResponseBodyResult extends TeaModel {
        @NameInMap("involvers")
        public java.util.List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> involvers;

        @NameInMap("updated")
        public String updated;

        public static UpdateOrganizationTaskInvolveMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskInvolveMembersResponseBodyResult self = new UpdateOrganizationTaskInvolveMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskInvolveMembersResponseBodyResult setInvolvers(java.util.List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> involvers) {
            this.involvers = involvers;
            return this;
        }
        public java.util.List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> getInvolvers() {
            return this.involvers;
        }

        public UpdateOrganizationTaskInvolveMembersResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
