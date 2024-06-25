// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class AddCityCarApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>杭州出差</p>
     */
    @NameInMap("cause")
    public String cause;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>杭州</p>
     */
    @NameInMap("city")
    public String city;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-03-18 20:26:56</p>
     */
    @NameInMap("date")
    public String date;

    /**
     * <strong>example:</strong>
     * <p>2021-03-30 20:26:56</p>
     */
    @NameInMap("finishedDate")
    public String finishedDate;

    /**
     * <strong>example:</strong>
     * <p>projectx</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <strong>example:</strong>
     * <p>项目x</p>
     */
    @NameInMap("projectName")
    public String projectName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public Long status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>apply1</p>
     */
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>costcenter1</p>
     */
    @NameInMap("thirdPartCostCenterId")
    public String thirdPartCostCenterId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>invoice1</p>
     */
    @NameInMap("thirdPartInvoiceId")
    public String thirdPartInvoiceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("timesTotal")
    public Long timesTotal;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3</p>
     */
    @NameInMap("timesType")
    public Long timesType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("timesUsed")
    public Long timesUsed;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>杭州出差</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user1</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddCityCarApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCityCarApplyRequest self = new AddCityCarApplyRequest();
        return TeaModel.build(map, self);
    }

    public AddCityCarApplyRequest setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public AddCityCarApplyRequest setCity(String city) {
        this.city = city;
        return this;
    }
    public String getCity() {
        return this.city;
    }

    public AddCityCarApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddCityCarApplyRequest setDate(String date) {
        this.date = date;
        return this;
    }
    public String getDate() {
        return this.date;
    }

    public AddCityCarApplyRequest setFinishedDate(String finishedDate) {
        this.finishedDate = finishedDate;
        return this;
    }
    public String getFinishedDate() {
        return this.finishedDate;
    }

    public AddCityCarApplyRequest setProjectCode(String projectCode) {
        this.projectCode = projectCode;
        return this;
    }
    public String getProjectCode() {
        return this.projectCode;
    }

    public AddCityCarApplyRequest setProjectName(String projectName) {
        this.projectName = projectName;
        return this;
    }
    public String getProjectName() {
        return this.projectName;
    }

    public AddCityCarApplyRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public AddCityCarApplyRequest setThirdPartApplyId(String thirdPartApplyId) {
        this.thirdPartApplyId = thirdPartApplyId;
        return this;
    }
    public String getThirdPartApplyId() {
        return this.thirdPartApplyId;
    }

    public AddCityCarApplyRequest setThirdPartCostCenterId(String thirdPartCostCenterId) {
        this.thirdPartCostCenterId = thirdPartCostCenterId;
        return this;
    }
    public String getThirdPartCostCenterId() {
        return this.thirdPartCostCenterId;
    }

    public AddCityCarApplyRequest setThirdPartInvoiceId(String thirdPartInvoiceId) {
        this.thirdPartInvoiceId = thirdPartInvoiceId;
        return this;
    }
    public String getThirdPartInvoiceId() {
        return this.thirdPartInvoiceId;
    }

    public AddCityCarApplyRequest setTimesTotal(Long timesTotal) {
        this.timesTotal = timesTotal;
        return this;
    }
    public Long getTimesTotal() {
        return this.timesTotal;
    }

    public AddCityCarApplyRequest setTimesType(Long timesType) {
        this.timesType = timesType;
        return this;
    }
    public Long getTimesType() {
        return this.timesType;
    }

    public AddCityCarApplyRequest setTimesUsed(Long timesUsed) {
        this.timesUsed = timesUsed;
        return this;
    }
    public Long getTimesUsed() {
        return this.timesUsed;
    }

    public AddCityCarApplyRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddCityCarApplyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
