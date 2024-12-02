// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectsV3Request extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("projectIds")
    public String projectIds;

    @NameInMap("projectRoleLevels")
    public String projectRoleLevels;

    @NameInMap("sortBy")
    public String sortBy;

    public static GetUserJoinedProjectsV3Request build(java.util.Map<String, ?> map) throws Exception {
        GetUserJoinedProjectsV3Request self = new GetUserJoinedProjectsV3Request();
        return TeaModel.build(map, self);
    }

    public GetUserJoinedProjectsV3Request setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetUserJoinedProjectsV3Request setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserJoinedProjectsV3Request setProjectIds(String projectIds) {
        this.projectIds = projectIds;
        return this;
    }
    public String getProjectIds() {
        return this.projectIds;
    }

    public GetUserJoinedProjectsV3Request setProjectRoleLevels(String projectRoleLevels) {
        this.projectRoleLevels = projectRoleLevels;
        return this;
    }
    public String getProjectRoleLevels() {
        return this.projectRoleLevels;
    }

    public GetUserJoinedProjectsV3Request setSortBy(String sortBy) {
        this.sortBy = sortBy;
        return this;
    }
    public String getSortBy() {
        return this.sortBy;
    }

}
