// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerRequest extends TeaModel {
    /**
     * <p>创建人userId</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>客户描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>开票人邮箱</p>
     */
    @NameInMap("drawerEmail")
    public String drawerEmail;

    /**
     * <p>开票人手机号</p>
     */
    @NameInMap("drawerTelephone")
    public String drawerTelephone;

    /**
     * <p>客户名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>购方账户</p>
     */
    @NameInMap("purchaserAccount")
    public String purchaserAccount;

    /**
     * <p>购房地址</p>
     */
    @NameInMap("purchaserAddress")
    public String purchaserAddress;

    /**
     * <p>购方银行</p>
     */
    @NameInMap("purchaserBankName")
    public String purchaserBankName;

    /**
     * <p>购方名字</p>
     */
    @NameInMap("purchaserName")
    public String purchaserName;

    /**
     * <p>购方税号</p>
     */
    @NameInMap("purchaserTaxNo")
    public String purchaserTaxNo;

    /**
     * <p>购方电话</p>
     */
    @NameInMap("purchaserTel")
    public String purchaserTel;

    public static CreateCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomerRequest self = new CreateCustomerRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomerRequest setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public CreateCustomerRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateCustomerRequest setDrawerEmail(String drawerEmail) {
        this.drawerEmail = drawerEmail;
        return this;
    }
    public String getDrawerEmail() {
        return this.drawerEmail;
    }

    public CreateCustomerRequest setDrawerTelephone(String drawerTelephone) {
        this.drawerTelephone = drawerTelephone;
        return this;
    }
    public String getDrawerTelephone() {
        return this.drawerTelephone;
    }

    public CreateCustomerRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateCustomerRequest setPurchaserAccount(String purchaserAccount) {
        this.purchaserAccount = purchaserAccount;
        return this;
    }
    public String getPurchaserAccount() {
        return this.purchaserAccount;
    }

    public CreateCustomerRequest setPurchaserAddress(String purchaserAddress) {
        this.purchaserAddress = purchaserAddress;
        return this;
    }
    public String getPurchaserAddress() {
        return this.purchaserAddress;
    }

    public CreateCustomerRequest setPurchaserBankName(String purchaserBankName) {
        this.purchaserBankName = purchaserBankName;
        return this;
    }
    public String getPurchaserBankName() {
        return this.purchaserBankName;
    }

    public CreateCustomerRequest setPurchaserName(String purchaserName) {
        this.purchaserName = purchaserName;
        return this;
    }
    public String getPurchaserName() {
        return this.purchaserName;
    }

    public CreateCustomerRequest setPurchaserTaxNo(String purchaserTaxNo) {
        this.purchaserTaxNo = purchaserTaxNo;
        return this;
    }
    public String getPurchaserTaxNo() {
        return this.purchaserTaxNo;
    }

    public CreateCustomerRequest setPurchaserTel(String purchaserTel) {
        this.purchaserTel = purchaserTel;
        return this;
    }
    public String getPurchaserTel() {
        return this.purchaserTel;
    }

}
