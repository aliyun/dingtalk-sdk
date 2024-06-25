// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class FinanceLoanNotifyRegisterRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2024-06-18 14:53:33</p>
     */
    @NameInMap("completeTime")
    public String completeTime;

    /**
     * <strong>example:</strong>
     * <p>{}</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <strong>example:</strong>
     * <p>330725189509101234</p>
     */
    @NameInMap("idCardNo")
    public String idCardNo;

    /**
     * <strong>example:</strong>
     * <p>中原消费金融</p>
     */
    @NameInMap("openChannelName")
    public String openChannelName;

    /**
     * <strong>example:</strong>
     * <p>XFD201909210001</p>
     */
    @NameInMap("openProductCode")
    public String openProductCode;

    /**
     * <strong>example:</strong>
     * <p>员工贷</p>
     */
    @NameInMap("openProductName")
    public String openProductName;

    /**
     * <strong>example:</strong>
     * <p>ZYXJ_XFD</p>
     */
    @NameInMap("openProductType")
    public String openProductType;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("processingStatus")
    public String processingStatus;

    /**
     * <strong>example:</strong>
     * <p>ZRSB2020</p>
     */
    @NameInMap("refuseCode")
    public String refuseCode;

    /**
     * <strong>example:</strong>
     * <p>进件准入失败</p>
     */
    @NameInMap("refuseReason")
    public String refuseReason;

    /**
     * <strong>example:</strong>
     * <p>2024061814654041710801</p>
     */
    @NameInMap("registerNo")
    public String registerNo;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>2024-06-18 14:53:33</p>
     */
    @NameInMap("submitTime")
    public String submitTime;

    /**
     * <strong>example:</strong>
     * <p>18092149430</p>
     */
    @NameInMap("userMobile")
    public String userMobile;

    public static FinanceLoanNotifyRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        FinanceLoanNotifyRegisterRequest self = new FinanceLoanNotifyRegisterRequest();
        return TeaModel.build(map, self);
    }

    public FinanceLoanNotifyRegisterRequest setCompleteTime(String completeTime) {
        this.completeTime = completeTime;
        return this;
    }
    public String getCompleteTime() {
        return this.completeTime;
    }

    public FinanceLoanNotifyRegisterRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public FinanceLoanNotifyRegisterRequest setIdCardNo(String idCardNo) {
        this.idCardNo = idCardNo;
        return this;
    }
    public String getIdCardNo() {
        return this.idCardNo;
    }

    public FinanceLoanNotifyRegisterRequest setOpenChannelName(String openChannelName) {
        this.openChannelName = openChannelName;
        return this;
    }
    public String getOpenChannelName() {
        return this.openChannelName;
    }

    public FinanceLoanNotifyRegisterRequest setOpenProductCode(String openProductCode) {
        this.openProductCode = openProductCode;
        return this;
    }
    public String getOpenProductCode() {
        return this.openProductCode;
    }

    public FinanceLoanNotifyRegisterRequest setOpenProductName(String openProductName) {
        this.openProductName = openProductName;
        return this;
    }
    public String getOpenProductName() {
        return this.openProductName;
    }

    public FinanceLoanNotifyRegisterRequest setOpenProductType(String openProductType) {
        this.openProductType = openProductType;
        return this;
    }
    public String getOpenProductType() {
        return this.openProductType;
    }

    public FinanceLoanNotifyRegisterRequest setProcessingStatus(String processingStatus) {
        this.processingStatus = processingStatus;
        return this;
    }
    public String getProcessingStatus() {
        return this.processingStatus;
    }

    public FinanceLoanNotifyRegisterRequest setRefuseCode(String refuseCode) {
        this.refuseCode = refuseCode;
        return this;
    }
    public String getRefuseCode() {
        return this.refuseCode;
    }

    public FinanceLoanNotifyRegisterRequest setRefuseReason(String refuseReason) {
        this.refuseReason = refuseReason;
        return this;
    }
    public String getRefuseReason() {
        return this.refuseReason;
    }

    public FinanceLoanNotifyRegisterRequest setRegisterNo(String registerNo) {
        this.registerNo = registerNo;
        return this;
    }
    public String getRegisterNo() {
        return this.registerNo;
    }

    public FinanceLoanNotifyRegisterRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public FinanceLoanNotifyRegisterRequest setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public FinanceLoanNotifyRegisterRequest setUserMobile(String userMobile) {
        this.userMobile = userMobile;
        return this;
    }
    public String getUserMobile() {
        return this.userMobile;
    }

}
