// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomFiledsV3Request extends TeaModel {
    @NameInMap("cfIds")
    public String cfIds;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("sfcId")
    public String sfcId;

    public static SearchProjectCustomFiledsV3Request build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomFiledsV3Request self = new SearchProjectCustomFiledsV3Request();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomFiledsV3Request setCfIds(String cfIds) {
        this.cfIds = cfIds;
        return this;
    }
    public String getCfIds() {
        return this.cfIds;
    }

    public SearchProjectCustomFiledsV3Request setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchProjectCustomFiledsV3Request setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectCustomFiledsV3Request setSfcId(String sfcId) {
        this.sfcId = sfcId;
        return this;
    }
    public String getSfcId() {
        return this.sfcId;
    }

}
