// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteAllRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("forceMute")
    public Boolean forceMute;

    public static MuteAllRequest build(java.util.Map<String, ?> map) throws Exception {
        MuteAllRequest self = new MuteAllRequest();
        return TeaModel.build(map, self);
    }

    public MuteAllRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public MuteAllRequest setForceMute(Boolean forceMute) {
        this.forceMute = forceMute;
        return this;
    }
    public Boolean getForceMute() {
        return this.forceMute;
    }

}
