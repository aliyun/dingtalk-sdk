// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpUserStatisticRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20230101</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("startTime")
    public String startTime;

    @NameInMap("templateIds")
    public java.util.List<String> templateIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>RCsp7PJmmTUr7w0hbs9aKAiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryCorpUserStatisticRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpUserStatisticRequest self = new QueryCorpUserStatisticRequest();
        return TeaModel.build(map, self);
    }

    public QueryCorpUserStatisticRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public QueryCorpUserStatisticRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryCorpUserStatisticRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryCorpUserStatisticRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public QueryCorpUserStatisticRequest setTemplateIds(java.util.List<String> templateIds) {
        this.templateIds = templateIds;
        return this;
    }
    public java.util.List<String> getTemplateIds() {
        return this.templateIds;
    }

    public QueryCorpUserStatisticRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
