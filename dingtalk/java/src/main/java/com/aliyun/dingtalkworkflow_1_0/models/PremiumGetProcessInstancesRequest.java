// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetProcessInstancesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SWAPP-4C2F4B-example</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <strong>example:</strong>
     * <p>1633795200000</p>
     */
    @NameInMap("endTimeInMills")
    public Long endTimeInMills;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-C53-example</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1631289600000</p>
     */
    @NameInMap("startTimeInMills")
    public Long startTimeInMills;

    public static PremiumGetProcessInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetProcessInstancesRequest self = new PremiumGetProcessInstancesRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetProcessInstancesRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public PremiumGetProcessInstancesRequest setEndTimeInMills(Long endTimeInMills) {
        this.endTimeInMills = endTimeInMills;
        return this;
    }
    public Long getEndTimeInMills() {
        return this.endTimeInMills;
    }

    public PremiumGetProcessInstancesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PremiumGetProcessInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PremiumGetProcessInstancesRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumGetProcessInstancesRequest setStartTimeInMills(Long startTimeInMills) {
        this.startTimeInMills = startTimeInMills;
        return this;
    }
    public Long getStartTimeInMills() {
        return this.startTimeInMills;
    }

}
