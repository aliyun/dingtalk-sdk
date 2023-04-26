// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMemebersRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("projectRoleId")
    public String projectRoleId;

    @NameInMap("skip")
    public Integer skip;

    @NameInMap("userIds")
    public String userIds;

    public static GetProjectMemebersRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMemebersRequest self = new GetProjectMemebersRequest();
        return TeaModel.build(map, self);
    }

    public GetProjectMemebersRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetProjectMemebersRequest setProjectRoleId(String projectRoleId) {
        this.projectRoleId = projectRoleId;
        return this;
    }
    public String getProjectRoleId() {
        return this.projectRoleId;
    }

    public GetProjectMemebersRequest setSkip(Integer skip) {
        this.skip = skip;
        return this;
    }
    public Integer getSkip() {
        return this.skip;
    }

    public GetProjectMemebersRequest setUserIds(String userIds) {
        this.userIds = userIds;
        return this;
    }
    public String getUserIds() {
        return this.userIds;
    }

}
