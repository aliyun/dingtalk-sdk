// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureLabourCostRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("appIds")
    public java.util.List<Long> appIds;

    @NameInMap("appName")
    public String appName;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("isvOrgId")
    public String isvOrgId;

    @NameInMap("materialNo")
    public String materialNo;

    @NameInMap("microappAgentId")
    public Long microappAgentId;

    @NameInMap("orgId")
    public Long orgId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("processNo")
    public String processNo;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("suiteKey")
    public String suiteKey;

    @NameInMap("tokenGrantType")
    public Integer tokenGrantType;

    public static IndustryManufactureLabourCostRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureLabourCostRequest self = new IndustryManufactureLabourCostRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureLabourCostRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public IndustryManufactureLabourCostRequest setAppIds(java.util.List<Long> appIds) {
        this.appIds = appIds;
        return this;
    }
    public java.util.List<Long> getAppIds() {
        return this.appIds;
    }

    public IndustryManufactureLabourCostRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public IndustryManufactureLabourCostRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public IndustryManufactureLabourCostRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public IndustryManufactureLabourCostRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public IndustryManufactureLabourCostRequest setIsvOrgId(String isvOrgId) {
        this.isvOrgId = isvOrgId;
        return this;
    }
    public String getIsvOrgId() {
        return this.isvOrgId;
    }

    public IndustryManufactureLabourCostRequest setMaterialNo(String materialNo) {
        this.materialNo = materialNo;
        return this;
    }
    public String getMaterialNo() {
        return this.materialNo;
    }

    public IndustryManufactureLabourCostRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
    }

    public IndustryManufactureLabourCostRequest setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public IndustryManufactureLabourCostRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public IndustryManufactureLabourCostRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public IndustryManufactureLabourCostRequest setProcessNo(String processNo) {
        this.processNo = processNo;
        return this;
    }
    public String getProcessNo() {
        return this.processNo;
    }

    public IndustryManufactureLabourCostRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public IndustryManufactureLabourCostRequest setSuiteKey(String suiteKey) {
        this.suiteKey = suiteKey;
        return this;
    }
    public String getSuiteKey() {
        return this.suiteKey;
    }

    public IndustryManufactureLabourCostRequest setTokenGrantType(Integer tokenGrantType) {
        this.tokenGrantType = tokenGrantType;
        return this;
    }
    public Integer getTokenGrantType() {
        return this.tokenGrantType;
    }

}
