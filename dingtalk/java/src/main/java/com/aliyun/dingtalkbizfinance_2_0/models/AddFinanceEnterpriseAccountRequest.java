// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddFinanceEnterpriseAccountRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>钉钉科技</p>
     */
    @NameInMap("accountName")
    public String accountName;

    /**
     * <strong>example:</strong>
     * <p>BANKCARD</p>
     */
    @NameInMap("accountType")
    public String accountType;

    @NameInMap("bankCardNo")
    public String bankCardNo;

    /**
     * <strong>example:</strong>
     * <p>ICBC</p>
     */
    @NameInMap("bankCode")
    public String bankCode;

    /**
     * <strong>example:</strong>
     * <p>中国工商银行</p>
     */
    @NameInMap("bankName")
    public String bankName;

    /**
     * <strong>example:</strong>
     * <p>杭州市</p>
     */
    @NameInMap("city")
    public String city;

    /**
     * <strong>example:</strong>
     * <p>账户描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>中国工商银行余杭分行</p>
     */
    @NameInMap("officialName")
    public String officialName;

    /**
     * <strong>example:</strong>
     * <p>1128878445</p>
     */
    @NameInMap("officialNumber")
    public String officialNumber;

    /**
     * <strong>example:</strong>
     * <p>浙江省</p>
     */
    @NameInMap("province")
    public String province;

    /**
     * <strong>example:</strong>
     * <p>smallScaleTaxpayer</p>
     */
    @NameInMap("taxNature")
    public String taxNature;

    /**
     * <strong>example:</strong>
     * <p>147581475814758</p>
     */
    @NameInMap("taxNo")
    public String taxNo;

    /**
     * <strong>example:</strong>
     * <p>5046195764756652</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddFinanceEnterpriseAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        AddFinanceEnterpriseAccountRequest self = new AddFinanceEnterpriseAccountRequest();
        return TeaModel.build(map, self);
    }

    public AddFinanceEnterpriseAccountRequest setAccountName(String accountName) {
        this.accountName = accountName;
        return this;
    }
    public String getAccountName() {
        return this.accountName;
    }

    public AddFinanceEnterpriseAccountRequest setAccountType(String accountType) {
        this.accountType = accountType;
        return this;
    }
    public String getAccountType() {
        return this.accountType;
    }

    public AddFinanceEnterpriseAccountRequest setBankCardNo(String bankCardNo) {
        this.bankCardNo = bankCardNo;
        return this;
    }
    public String getBankCardNo() {
        return this.bankCardNo;
    }

    public AddFinanceEnterpriseAccountRequest setBankCode(String bankCode) {
        this.bankCode = bankCode;
        return this;
    }
    public String getBankCode() {
        return this.bankCode;
    }

    public AddFinanceEnterpriseAccountRequest setBankName(String bankName) {
        this.bankName = bankName;
        return this;
    }
    public String getBankName() {
        return this.bankName;
    }

    public AddFinanceEnterpriseAccountRequest setCity(String city) {
        this.city = city;
        return this;
    }
    public String getCity() {
        return this.city;
    }

    public AddFinanceEnterpriseAccountRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddFinanceEnterpriseAccountRequest setOfficialName(String officialName) {
        this.officialName = officialName;
        return this;
    }
    public String getOfficialName() {
        return this.officialName;
    }

    public AddFinanceEnterpriseAccountRequest setOfficialNumber(String officialNumber) {
        this.officialNumber = officialNumber;
        return this;
    }
    public String getOfficialNumber() {
        return this.officialNumber;
    }

    public AddFinanceEnterpriseAccountRequest setProvince(String province) {
        this.province = province;
        return this;
    }
    public String getProvince() {
        return this.province;
    }

    public AddFinanceEnterpriseAccountRequest setTaxNature(String taxNature) {
        this.taxNature = taxNature;
        return this;
    }
    public String getTaxNature() {
        return this.taxNature;
    }

    public AddFinanceEnterpriseAccountRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public AddFinanceEnterpriseAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
