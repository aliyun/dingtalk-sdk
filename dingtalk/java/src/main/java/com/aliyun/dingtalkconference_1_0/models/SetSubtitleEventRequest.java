// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class SetSubtitleEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("enable")
    public Boolean enable;

    public static SetSubtitleEventRequest build(java.util.Map<String, ?> map) throws Exception {
        SetSubtitleEventRequest self = new SetSubtitleEventRequest();
        return TeaModel.build(map, self);
    }

    public SetSubtitleEventRequest setEnable(Boolean enable) {
        this.enable = enable;
        return this;
    }
    public Boolean getEnable() {
        return this.enable;
    }

}
