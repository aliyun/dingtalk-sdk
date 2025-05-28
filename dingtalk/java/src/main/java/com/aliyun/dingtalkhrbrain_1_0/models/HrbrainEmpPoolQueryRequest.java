// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolQueryRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    @NameInMap("labels")
    public java.util.List<String> labels;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Integer nextToken;

    public static HrbrainEmpPoolQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolQueryRequest self = new HrbrainEmpPoolQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolQueryRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public HrbrainEmpPoolQueryRequest setLabels(java.util.List<String> labels) {
        this.labels = labels;
        return this;
    }
    public java.util.List<String> getLabels() {
        return this.labels;
    }

    public HrbrainEmpPoolQueryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public HrbrainEmpPoolQueryRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
