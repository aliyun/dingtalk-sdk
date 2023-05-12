// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldRequest extends TeaModel {
    @NameInMap("customFieldIds")
    public String customFieldIds;

    @NameInMap("instanceIds")
    public String instanceIds;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("query")
    public String query;

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
