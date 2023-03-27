// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldRequest extends TeaModel {
    /**
     * <p>自定义字段ID集合，逗号组合。</p>
     */
    @NameInMap("customfieldIds")
    public String customfieldIds;

    /**
     * <p>字段InstanceId集合，用逗号组合。</p>
     */
    @NameInMap("instanceIds")
    public String instanceIds;

    /**
     * <p>每页返回最大数量。默认10，最大300。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>过滤出在指定项目中使用的企业字段，当scope=usedInProjectIds有效。多个以逗号隔开。</p>
     */
    @NameInMap("projectIds")
    public String projectIds;

    /**
     * <p>过滤字段名字。</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <p>字段应用场景, 可以是 sfcAdd,usedInProjectIds,all 其中一个。</p>
     */
    @NameInMap("scope")
    public String scope;

    public static SearchOranizationCustomfieldRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchOranizationCustomfieldRequest self = new SearchOranizationCustomfieldRequest();
        return TeaModel.build(map, self);
    }

    public SearchOranizationCustomfieldRequest setCustomfieldIds(String customfieldIds) {
        this.customfieldIds = customfieldIds;
        return this;
    }
    public String getCustomfieldIds() {
        return this.customfieldIds;
    }

    public SearchOranizationCustomfieldRequest setInstanceIds(String instanceIds) {
        this.instanceIds = instanceIds;
        return this;
    }
    public String getInstanceIds() {
        return this.instanceIds;
    }

    public SearchOranizationCustomfieldRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchOranizationCustomfieldRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchOranizationCustomfieldRequest setProjectIds(String projectIds) {
        this.projectIds = projectIds;
        return this;
    }
    public String getProjectIds() {
        return this.projectIds;
    }

    public SearchOranizationCustomfieldRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SearchOranizationCustomfieldRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

}
