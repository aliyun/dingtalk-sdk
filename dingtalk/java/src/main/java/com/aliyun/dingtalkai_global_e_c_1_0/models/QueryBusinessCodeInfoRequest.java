// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryBusinessCodeInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessCode")
    public String businessCode;

    @NameInMap("eventType")
    public String eventType;

    @NameInMap("status")
    public String status;

    public static QueryBusinessCodeInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBusinessCodeInfoRequest self = new QueryBusinessCodeInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryBusinessCodeInfoRequest setBusinessCode(String businessCode) {
        this.businessCode = businessCode;
        return this;
    }
    public String getBusinessCode() {
        return this.businessCode;
    }

    public QueryBusinessCodeInfoRequest setEventType(String eventType) {
        this.eventType = eventType;
        return this;
    }
    public String getEventType() {
        return this.eventType;
    }

    public QueryBusinessCodeInfoRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
