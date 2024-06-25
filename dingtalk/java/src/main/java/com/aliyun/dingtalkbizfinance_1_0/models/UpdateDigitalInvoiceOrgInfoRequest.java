// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateDigitalInvoiceOrgInfoRequest extends TeaModel {
    @NameInMap("digitalInvoiceType")
    public java.util.List<String> digitalInvoiceType;

    @NameInMap("isDigitalOrg")
    public Boolean isDigitalOrg;

    /**
     * <strong>example:</strong>
     * <p>zhejiang</p>
     */
    @NameInMap("location")
    public String location;

    /**
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("operator")
    public String operator;

    public static UpdateDigitalInvoiceOrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDigitalInvoiceOrgInfoRequest self = new UpdateDigitalInvoiceOrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDigitalInvoiceOrgInfoRequest setDigitalInvoiceType(java.util.List<String> digitalInvoiceType) {
        this.digitalInvoiceType = digitalInvoiceType;
        return this;
    }
    public java.util.List<String> getDigitalInvoiceType() {
        return this.digitalInvoiceType;
    }

    public UpdateDigitalInvoiceOrgInfoRequest setIsDigitalOrg(Boolean isDigitalOrg) {
        this.isDigitalOrg = isDigitalOrg;
        return this;
    }
    public Boolean getIsDigitalOrg() {
        return this.isDigitalOrg;
    }

    public UpdateDigitalInvoiceOrgInfoRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public UpdateDigitalInvoiceOrgInfoRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
