// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMemebersRequest extends TeaModel {
    /**
     * <p>每页返回最大数量。默认10，最大300。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>项目角色ID，仅查询拥有该角色的成员，并且仅支持单个角色查询。</p>
     */
    @NameInMap("projectRoleId")
    public String projectRoleId;

    /**
     * <p>跳过的数据数量。</p>
     */
    @NameInMap("skip")
    public Integer skip;

    /**
     * <p>如果传递，仅查询这些用户ID， 用逗号组合。</p>
     */
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
