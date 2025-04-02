// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class BatchGetAICreditsRecordRequest extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("endTime")
    public String endTime;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("startTime")
    public String startTime;

    @NameInMap("unionId")
    public String unionId;

    public static BatchGetAICreditsRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetAICreditsRecordRequest self = new BatchGetAICreditsRecordRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetAICreditsRecordRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public BatchGetAICreditsRecordRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public BatchGetAICreditsRecordRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public BatchGetAICreditsRecordRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public BatchGetAICreditsRecordRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public BatchGetAICreditsRecordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
