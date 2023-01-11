// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>候选人标识</p>
     */
    @NameInMap("candidateId")
    public String candidateId;

    /**
     * <p>面试开始时间的查询起始时间（单位：毫秒）</p>
     */
    @NameInMap("startTimeBeginMillis")
    public Long startTimeBeginMillis;

    /**
     * <p>面试开始时间的查询结束时间（单位：毫秒）</p>
     */
    @NameInMap("startTimeEndMillis")
    public Long startTimeEndMillis;

    /**
     * <p>分页游标，首次调用传空</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("size")
    public Long size;

    public static QueryInterviewsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInterviewsRequest self = new QueryInterviewsRequest();
        return TeaModel.build(map, self);
    }

    public QueryInterviewsRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public QueryInterviewsRequest setCandidateId(String candidateId) {
        this.candidateId = candidateId;
        return this;
    }
    public String getCandidateId() {
        return this.candidateId;
    }

    public QueryInterviewsRequest setStartTimeBeginMillis(Long startTimeBeginMillis) {
        this.startTimeBeginMillis = startTimeBeginMillis;
        return this;
    }
    public Long getStartTimeBeginMillis() {
        return this.startTimeBeginMillis;
    }

    public QueryInterviewsRequest setStartTimeEndMillis(Long startTimeEndMillis) {
        this.startTimeEndMillis = startTimeEndMillis;
        return this;
    }
    public Long getStartTimeEndMillis() {
        return this.startTimeEndMillis;
    }

    public QueryInterviewsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryInterviewsRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

}
