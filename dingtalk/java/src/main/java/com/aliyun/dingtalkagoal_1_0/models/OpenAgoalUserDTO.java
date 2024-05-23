// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalUserDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OpenAgoalUserDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalUserDTO self = new OpenAgoalUserDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalUserDTO setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public OpenAgoalUserDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenAgoalUserDTO setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
