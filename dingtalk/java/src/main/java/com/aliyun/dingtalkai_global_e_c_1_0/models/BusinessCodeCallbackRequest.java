// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class BusinessCodeCallbackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessCode")
    public String businessCode;

    @NameInMap("eventType")
    public String eventType;

    @NameInMap("status")
    public String status;

    public static BusinessCodeCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        BusinessCodeCallbackRequest self = new BusinessCodeCallbackRequest();
        return TeaModel.build(map, self);
    }

    public BusinessCodeCallbackRequest setBusinessCode(String businessCode) {
        this.businessCode = businessCode;
        return this;
    }
    public String getBusinessCode() {
        return this.businessCode;
    }

    public BusinessCodeCallbackRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

    public BusinessCodeCallbackRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
