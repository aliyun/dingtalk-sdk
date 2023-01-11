// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusRequest extends TeaModel {
    /**
     * <p>查验流水号</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>查验结果</p>
     */
    @NameInMap("checkingResult")
    public Integer checkingResult;

    /**
     * <p>查验状态</p>
     */
    @NameInMap("checkingStatus")
    public Integer checkingStatus;

    /**
     * <p>业务响应码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>企业Id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>发票代码</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <p>发票号码</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

    /**
     * <p>发票状态</p>
     */
    @NameInMap("invoiceStatus")
    public Integer invoiceStatus;

    /**
     * <p>发票验真编号</p>
     */
    @NameInMap("invoiceVerifyId")
    public String invoiceVerifyId;

    /**
     * <p>响应信息</p>
     */
    @NameInMap("msg")
    public String msg;

    /**
     * <p>用户Id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateInvoiceVerifyStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusRequest self = new UpdateInvoiceVerifyStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public UpdateInvoiceVerifyStatusRequest setCheckingResult(Integer checkingResult) {
        this.checkingResult = checkingResult;
        return this;
    }
    public Integer getCheckingResult() {
        return this.checkingResult;
    }

    public UpdateInvoiceVerifyStatusRequest setCheckingStatus(Integer checkingStatus) {
        this.checkingStatus = checkingStatus;
        return this;
    }
    public Integer getCheckingStatus() {
        return this.checkingStatus;
    }

    public UpdateInvoiceVerifyStatusRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public UpdateInvoiceVerifyStatusRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceStatus(Integer invoiceStatus) {
        this.invoiceStatus = invoiceStatus;
        return this;
    }
    public Integer getInvoiceStatus() {
        return this.invoiceStatus;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceVerifyId(String invoiceVerifyId) {
        this.invoiceVerifyId = invoiceVerifyId;
        return this;
    }
    public String getInvoiceVerifyId() {
        return this.invoiceVerifyId;
    }

    public UpdateInvoiceVerifyStatusRequest setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

    public UpdateInvoiceVerifyStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
