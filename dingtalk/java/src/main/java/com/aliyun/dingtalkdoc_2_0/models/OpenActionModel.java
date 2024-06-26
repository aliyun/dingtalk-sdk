// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class OpenActionModel extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sky</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>273829092</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    public static OpenActionModel build(java.util.Map<String, ?> map) throws Exception {
        OpenActionModel self = new OpenActionModel();
        return TeaModel.build(map, self);
    }

    public OpenActionModel setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenActionModel setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
