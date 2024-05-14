// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("candidateId")
    public String candidateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTimeBeginMillis")
    public Long startTimeBeginMillis;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTimeEndMillis")
    public Long startTimeEndMillis;

    @NameInMap("nextToken")
    public String nextToken;

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
