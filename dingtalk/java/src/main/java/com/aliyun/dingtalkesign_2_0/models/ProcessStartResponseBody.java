// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ProcessStartResponseBody extends TeaModel {
    @NameInMap("mobileUrl")
    public String mobileUrl;

    @NameInMap("pcUrl")
    public String pcUrl;

    @NameInMap("taskId")
    public String taskId;

    public static ProcessStartResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProcessStartResponseBody self = new ProcessStartResponseBody();
        return TeaModel.build(map, self);
    }

    public ProcessStartResponseBody setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public ProcessStartResponseBody setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public ProcessStartResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
