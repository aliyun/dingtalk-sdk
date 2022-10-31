// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class CheckInCrowdsByMobileResponseBody extends TeaModel {
    @NameInMap("data")
    public Boolean data;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("total")
    public Integer total;

    public static CheckInCrowdsByMobileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckInCrowdsByMobileResponseBody self = new CheckInCrowdsByMobileResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckInCrowdsByMobileResponseBody setData(Boolean data) {
        this.data = data;
        return this;
    }
    public Boolean getData() {
        return this.data;
    }

    public CheckInCrowdsByMobileResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public CheckInCrowdsByMobileResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

}
