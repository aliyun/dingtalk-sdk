// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpUserStatisticRequest extends TeaModel {
    /**
     * <p>结束时间（yyyymmdd）</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>页大小</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>当前页</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>开始时间（yyyymmdd）</p>
     */
    @NameInMap("startTime")
    public String startTime;

    /**
     * <p>模版id列表</p>
     */
    @NameInMap("templateIds")
    public java.util.List<String> templateIds;

    /**
     * <p>操作者id</p>
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
