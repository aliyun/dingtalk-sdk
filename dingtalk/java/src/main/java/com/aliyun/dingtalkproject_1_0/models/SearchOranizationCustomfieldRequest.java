// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchOranizationCustomfieldRequest extends TeaModel {
    @NameInMap("customFieldIds")
    public String customFieldIds;

    @NameInMap("instanceIds")
    public String instanceIds;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("projectIds")
    public String projectIds;

    @NameInMap("query")
    public String query;

    public static SearchOranizationCustomfieldRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchOranizationCustomfieldRequest self = new SearchOranizationCustomfieldRequest();
        return TeaModel.build(map, self);
    }

    public SearchOranizationCustomfieldRequest setCustomFieldIds(String customFieldIds) {
        this.customFieldIds = customFieldIds;
        return this;
    }
    public String getCustomFieldIds() {
        return this.customFieldIds;
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

}
