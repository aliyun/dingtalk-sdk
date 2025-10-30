// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskQueueRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    public static GetTaskQueueRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskQueueRequest self = new GetTaskQueueRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskQueueRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

}
