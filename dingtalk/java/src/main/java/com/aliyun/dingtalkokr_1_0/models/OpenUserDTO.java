// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenUserDTO extends TeaModel {
    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("name")
    public String name;

    @NameInMap("userUid")
    public String userUid;

    public static OpenUserDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenUserDTO self = new OpenUserDTO();
        return TeaModel.build(map, self);
    }

    public OpenUserDTO setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public OpenUserDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenUserDTO setUserUid(String userUid) {
        this.userUid = userUid;
        return this;
    }
    public String getUserUid() {
        return this.userUid;
    }

}
