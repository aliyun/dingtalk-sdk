// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRightsInfoResponseBody extends TeaModel {
    /**
     * <p>权益过期时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>门店通通讯录根节点Id</p>
     */
    @NameInMap("quantity")
    public Long quantity;

    /**
     * <p>门店通通讯录名称</p>
     */
    @NameInMap("rightsCode")
    public String rightsCode;

    /**
     * <p>门店通通讯录Code</p>
     */
    @NameInMap("rightsName")
    public String rightsName;

    /**
     * <p>权益开始时间</p>
     */
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
