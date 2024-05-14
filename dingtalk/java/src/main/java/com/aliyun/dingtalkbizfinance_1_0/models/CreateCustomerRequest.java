// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creator")
    public String creator;

    @NameInMap("description")
    public String description;

    @NameInMap("drawerEmail")
    public String drawerEmail;

    @NameInMap("drawerTelephone")
    public String drawerTelephone;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("purchaserAccount")
    public String purchaserAccount;

    @NameInMap("purchaserAddress")
    public String purchaserAddress;

    @NameInMap("purchaserBankName")
    public String purchaserBankName;

    @NameInMap("purchaserName")
    public String purchaserName;

    @NameInMap("purchaserTaxNo")
    public String purchaserTaxNo;

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
