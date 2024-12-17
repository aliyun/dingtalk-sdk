// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectRolesV3Request extends TeaModel {
    @NameInMap("includeHidden")
    public Boolean includeHidden;

    @NameInMap("level")
    public Long level;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetProjectRolesV3Request build(java.util.Map<String, ?> map) throws Exception {
        GetProjectRolesV3Request self = new GetProjectRolesV3Request();
        return TeaModel.build(map, self);
    }

    public GetProjectRolesV3Request setIncludeHidden(Boolean includeHidden) {
        this.includeHidden = includeHidden;
        return this;
    }
    public Boolean getIncludeHidden() {
        return this.includeHidden;
    }

    public GetProjectRolesV3Request setLevel(Long level) {
        this.level = level;
        return this;
    }
    public Long getLevel() {
        return this.level;
    }

    public GetProjectRolesV3Request setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetProjectRolesV3Request setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
