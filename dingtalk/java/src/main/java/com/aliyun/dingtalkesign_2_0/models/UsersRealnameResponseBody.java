// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class UsersRealnameResponseBody extends TeaModel {
    @NameInMap("mobileUrl")
    public String mobileUrl;

    @NameInMap("pcUrl")
    public String pcUrl;

    @NameInMap("taskId")
    public String taskId;

    public static UsersRealnameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UsersRealnameResponseBody self = new UsersRealnameResponseBody();
        return TeaModel.build(map, self);
    }

    public UsersRealnameResponseBody setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public UsersRealnameResponseBody setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public UsersRealnameResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
