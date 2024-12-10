// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMembersV3Request extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("projectRoleId")
    public String projectRoleId;

    @NameInMap("userIds")
    public String userIds;

    public static GetProjectMembersV3Request build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMembersV3Request self = new GetProjectMembersV3Request();
        return TeaModel.build(map, self);
    }

    public GetProjectMembersV3Request setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetProjectMembersV3Request setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetProjectMembersV3Request setProjectRoleId(String projectRoleId) {
        this.projectRoleId = projectRoleId;
        return this;
    }
    public String getProjectRoleId() {
        return this.projectRoleId;
    }

    public GetProjectMembersV3Request setUserIds(String userIds) {
        this.userIds = userIds;
        return this;
    }
    public String getUserIds() {
        return this.userIds;
    }

}
