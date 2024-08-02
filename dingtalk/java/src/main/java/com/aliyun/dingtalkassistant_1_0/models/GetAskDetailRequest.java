// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAskDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("offset")
    public Long offset;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("startTime")
    public Long startTime;

    public static GetAskDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAskDetailRequest self = new GetAskDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetAskDetailRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public GetAskDetailRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetAskDetailRequest setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public GetAskDetailRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetAskDetailRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
