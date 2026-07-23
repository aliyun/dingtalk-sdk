// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgCorrectTaskWithWrongQuestionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNo")
    public Long pageNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding26d260744657eb6378f</p>
     */
    @NameInMap("queryCorpId")
    public String queryCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static QueryOrgCorrectTaskWithWrongQuestionRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgCorrectTaskWithWrongQuestionRequest self = new QueryOrgCorrectTaskWithWrongQuestionRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgCorrectTaskWithWrongQuestionRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryOrgCorrectTaskWithWrongQuestionRequest setPageNo(Long pageNo) {
        this.pageNo = pageNo;
        return this;
    }
    public Long getPageNo() {
        return this.pageNo;
    }

    public QueryOrgCorrectTaskWithWrongQuestionRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryOrgCorrectTaskWithWrongQuestionRequest setQueryCorpId(String queryCorpId) {
        this.queryCorpId = queryCorpId;
        return this;
    }
    public String getQueryCorpId() {
        return this.queryCorpId;
    }

    public QueryOrgCorrectTaskWithWrongQuestionRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
