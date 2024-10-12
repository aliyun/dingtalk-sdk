// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectsV3Request extends TeaModel {
    @NameInMap("includeTemplate")
    public Boolean includeTemplate;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("name")
    public String name;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("projectIds")
    public String projectIds;

    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0517xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SearchProjectsV3Request build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectsV3Request self = new SearchProjectsV3Request();
        return TeaModel.build(map, self);
    }

    public SearchProjectsV3Request setIncludeTemplate(Boolean includeTemplate) {
        this.includeTemplate = includeTemplate;
        return this;
    }
    public Boolean getIncludeTemplate() {
        return this.includeTemplate;
    }

    public SearchProjectsV3Request setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchProjectsV3Request setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SearchProjectsV3Request setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectsV3Request setProjectIds(String projectIds) {
        this.projectIds = projectIds;
        return this;
    }
    public String getProjectIds() {
        return this.projectIds;
    }

    public SearchProjectsV3Request setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public SearchProjectsV3Request setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
