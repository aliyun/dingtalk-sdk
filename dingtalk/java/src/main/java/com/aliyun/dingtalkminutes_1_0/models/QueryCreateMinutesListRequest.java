// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateMinutesListRequest extends TeaModel {
    @NameInMap("gmtCreateEnd")
    public Long gmtCreateEnd;

    @NameInMap("gmtCreateStart")
    public Long gmtCreateStart;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryCreateMinutesListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateMinutesListRequest self = new QueryCreateMinutesListRequest();
        return TeaModel.build(map, self);
    }

    public QueryCreateMinutesListRequest setGmtCreateEnd(Long gmtCreateEnd) {
        this.gmtCreateEnd = gmtCreateEnd;
        return this;
    }
    public Long getGmtCreateEnd() {
        return this.gmtCreateEnd;
    }

    public QueryCreateMinutesListRequest setGmtCreateStart(Long gmtCreateStart) {
        this.gmtCreateStart = gmtCreateStart;
        return this;
    }
    public Long getGmtCreateStart() {
        return this.gmtCreateStart;
    }

    public QueryCreateMinutesListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCreateMinutesListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCreateMinutesListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
