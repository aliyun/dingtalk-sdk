// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class AddCityCarApplyRequest extends TeaModel {
    // 出差事由
    @NameInMap("cause")
    public String cause;

    // 用车城市
    @NameInMap("city")
    public String city;

    // 第三方企业ID
    @NameInMap("corpId")
    public String corpId;

    // 用车时间，按天管控，比如传值2021-03-18 20:26:56表示2021-03-18当天可用车，跨天情况配合finishedDate参数使用
    @NameInMap("date")
    public String date;

    // 用车截止时间，按天管控，比如date传值2021-03-18 20:26:56、finished_date传值2021-03-30 20:26:56表示2021-03-18(含)到2021-03-30(含)之间可用车，该参数不传值情况使用date作为用车截止时间；
    @NameInMap("finishedDate")
    public String finishedDate;

    // 审批单关联的项目code
    @NameInMap("projectCode")
    public String projectCode;

    // 审批单关联的项目名
    @NameInMap("projectName")
    public String projectName;

    // 审批单状态：0-申请，1-同意，2-拒绝
    @NameInMap("status")
    public Long status;

    // 三方审批单ID
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    // 审批单关联的三方成本中心ID
    @NameInMap("thirdPartCostCenterId")
    public String thirdPartCostCenterId;

    // 审批单关联的三方发票抬头ID
    @NameInMap("thirdPartInvoiceId")
    public String thirdPartInvoiceId;

    // 审批单可用总次数
    @NameInMap("timesTotal")
    public Long timesTotal;

    // 审批单可用次数类型：1-次数不限制，2-用户可指定次数，3-管理员限制次数；如果企业没有限制审批单使用次数的需求，这个参数传1(次数不限制)，同时times_total和times_used都传0即可
    @NameInMap("timesType")
    public Long timesType;

    // 审批单已用次数
    @NameInMap("timesUsed")
    public Long timesUsed;

    // 审批单标题
    @NameInMap("title")
    public String title;

    // 发起审批的第三方员工ID
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
