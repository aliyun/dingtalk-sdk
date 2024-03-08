// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PagesExportInstancesRequest extends TeaModel {
    @NameInMap("endTimeInMills")
    public Long endTimeInMills;

    @NameInMap("maxResult")
    public Integer maxResult;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("orderBy")
    public String orderBy;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("startTimeInMills")
    public Long startTimeInMills;

    @NameInMap("status")
    public String status;

    public static PagesExportInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        PagesExportInstancesRequest self = new PagesExportInstancesRequest();
        return TeaModel.build(map, self);
    }

    public PagesExportInstancesRequest setEndTimeInMills(Long endTimeInMills) {
        this.endTimeInMills = endTimeInMills;
        return this;
    }
    public Long getEndTimeInMills() {
        return this.endTimeInMills;
    }

    public PagesExportInstancesRequest setMaxResult(Integer maxResult) {
        this.maxResult = maxResult;
        return this;
    }
    public Integer getMaxResult() {
        return this.maxResult;
    }

    public PagesExportInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PagesExportInstancesRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public PagesExportInstancesRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PagesExportInstancesRequest setStartTimeInMills(Long startTimeInMills) {
        this.startTimeInMills = startTimeInMills;
        return this;
    }
    public Long getStartTimeInMills() {
        return this.startTimeInMills;
    }

    public PagesExportInstancesRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
