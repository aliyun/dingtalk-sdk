// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class PushHistoricalReceiptsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("forcedIgnoreDup")
    public Boolean forcedIgnoreDup;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formCodeList")
    public java.util.List<String> formCodeList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static PushHistoricalReceiptsRequest build(java.util.Map<String, ?> map) throws Exception {
        PushHistoricalReceiptsRequest self = new PushHistoricalReceiptsRequest();
        return TeaModel.build(map, self);
    }

    public PushHistoricalReceiptsRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public PushHistoricalReceiptsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public PushHistoricalReceiptsRequest setForcedIgnoreDup(Boolean forcedIgnoreDup) {
        this.forcedIgnoreDup = forcedIgnoreDup;
        return this;
    }
    public Boolean getForcedIgnoreDup() {
        return this.forcedIgnoreDup;
    }

    public PushHistoricalReceiptsRequest setFormCodeList(java.util.List<String> formCodeList) {
        this.formCodeList = formCodeList;
        return this;
    }
    public java.util.List<String> getFormCodeList() {
        return this.formCodeList;
    }

    public PushHistoricalReceiptsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
