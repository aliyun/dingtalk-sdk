// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopMinutesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static StopMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        StopMinutesRequest self = new StopMinutesRequest();
        return TeaModel.build(map, self);
    }

    public StopMinutesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
