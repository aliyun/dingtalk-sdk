// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateDigitalInvoiceOrgInfoRequest extends TeaModel {
    /**
     * <p>支持的全电票种</p>
     */
    @NameInMap("digitalInvoiceType")
    public java.util.List<String> digitalInvoiceType;

    /**
     * <p>是否为全电企业</p>
     */
    @NameInMap("isDigitalOrg")
    public Boolean isDigitalOrg;

    /**
     * <p>报税地点</p>
     */
    @NameInMap("location")
    public String location;

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

}
