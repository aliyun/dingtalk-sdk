// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskRequest extends TeaModel {
    /**
     * <p>每页返回最大数量。默认10，最大100。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页标，从上一次请求结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>用户的任务角色, creator,executor,involveMember 中的一个或多个,以 ','拼接。例如：creator,executor。</p>
     */
    @NameInMap("roleTypes")
    public String roleTypes;

    /**
     * <p>tql，参考项目内的tql使用说明。</p>
     */
    @NameInMap("tql")
    public String tql;

    public static SearchUserTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchUserTaskRequest self = new SearchUserTaskRequest();
        return TeaModel.build(map, self);
    }

    public SearchUserTaskRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchUserTaskRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchUserTaskRequest setRoleTypes(String roleTypes) {
        this.roleTypes = roleTypes;
        return this;
    }
    public String getRoleTypes() {
        return this.roleTypes;
    }

    public SearchUserTaskRequest setTql(String tql) {
        this.tql = tql;
        return this;
    }
    public String getTql() {
        return this.tql;
    }

}
