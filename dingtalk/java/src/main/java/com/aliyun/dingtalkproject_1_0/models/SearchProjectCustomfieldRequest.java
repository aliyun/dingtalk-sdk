// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldRequest extends TeaModel {
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
     * <p>每页返回最大数量。默认10，最大500。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>过滤字段名字。</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <p>任务类型ID。</p>
     */
    @NameInMap("scenariofieldconfigId")
    public String scenariofieldconfigId;

    /**
     * <p>字段应用场景, 可以是 taskTableHeader,searcherAdd,taskExportHeader,sfcAdd,kanbanCardAdd,all 其中一个。</p>
     */
    @NameInMap("scope")
    public String scope;

    public static SearchProjectCustomfieldRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomfieldRequest self = new SearchProjectCustomfieldRequest();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomfieldRequest setCustomfieldIds(String customfieldIds) {
        this.customfieldIds = customfieldIds;
        return this;
    }
    public String getCustomfieldIds() {
        return this.customfieldIds;
    }

    public SearchProjectCustomfieldRequest setInstanceIds(String instanceIds) {
        this.instanceIds = instanceIds;
        return this;
    }
    public String getInstanceIds() {
        return this.instanceIds;
    }

    public SearchProjectCustomfieldRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchProjectCustomfieldRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectCustomfieldRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SearchProjectCustomfieldRequest setScenariofieldconfigId(String scenariofieldconfigId) {
        this.scenariofieldconfigId = scenariofieldconfigId;
        return this;
    }
    public String getScenariofieldconfigId() {
        return this.scenariofieldconfigId;
    }

    public SearchProjectCustomfieldRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

}
