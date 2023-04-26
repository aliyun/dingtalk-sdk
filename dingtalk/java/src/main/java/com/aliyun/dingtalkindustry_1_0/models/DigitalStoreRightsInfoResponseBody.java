// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRightsInfoResponseBody extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("quantity")
    public Long quantity;

    @NameInMap("rightsCode")
    public String rightsCode;

    @NameInMap("rightsName")
    public String rightsName;

    @NameInMap("startTime")
    public Long startTime;

    public static DigitalStoreRightsInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreRightsInfoResponseBody self = new DigitalStoreRightsInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreRightsInfoResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public DigitalStoreRightsInfoResponseBody setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public DigitalStoreRightsInfoResponseBody setRightsCode(String rightsCode) {
        this.rightsCode = rightsCode;
        return this;
    }
    public String getRightsCode() {
        return this.rightsCode;
    }

    public DigitalStoreRightsInfoResponseBody setRightsName(String rightsName) {
        this.rightsName = rightsName;
        return this;
    }
    public String getRightsName() {
        return this.rightsName;
    }

    public DigitalStoreRightsInfoResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
