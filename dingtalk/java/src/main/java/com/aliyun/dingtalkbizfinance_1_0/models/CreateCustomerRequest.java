// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerRequest extends TeaModel {
    // 创建人userId
    @NameInMap("creator")
    public String creator;

    // 客户描述
    @NameInMap("description")
    public String description;

    // 客户名字
    @NameInMap("name")
    public String name;

    // 购方账户
    @NameInMap("purchaserAccount")
    public String purchaserAccount;

    // 购房地址
    @NameInMap("purchaserAddress")
    public String purchaserAddress;

    // 购方银行
    @NameInMap("purchaserBankName")
    public String purchaserBankName;

    // 购方名字
    @NameInMap("purchaserName")
    public String purchaserName;

    // 购方税号
    @NameInMap("purchaserTaxNo")
    public String purchaserTaxNo;

    // 购方电话
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
