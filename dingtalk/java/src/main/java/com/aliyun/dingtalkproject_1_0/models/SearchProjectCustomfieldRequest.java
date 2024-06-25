// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("customFieldIds")
    public String customFieldIds;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("instanceIds")
    public String instanceIds;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>f279e812xxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>自定义字段名1</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx</p>
     */
    @NameInMap("scenarioFieldConfigId")
    public String scenarioFieldConfigId;

    public static SearchProjectCustomfieldRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomfieldRequest self = new SearchProjectCustomfieldRequest();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomfieldRequest setCustomFieldIds(String customFieldIds) {
        this.customFieldIds = customFieldIds;
        return this;
    }
    public String getCustomFieldIds() {
        return this.customFieldIds;
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

    public SearchProjectCustomfieldRequest setScenarioFieldConfigId(String scenarioFieldConfigId) {
        this.scenarioFieldConfigId = scenarioFieldConfigId;
        return this;
    }
    public String getScenarioFieldConfigId() {
        return this.scenarioFieldConfigId;
    }

}
