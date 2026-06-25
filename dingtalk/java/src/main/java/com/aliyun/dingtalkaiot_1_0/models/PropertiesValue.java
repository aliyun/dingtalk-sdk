// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class PropertiesValue extends TeaModel {
    @NameInMap("value")
    public Object value;

    @NameInMap("timestamp")
    public String timestamp;

    public static PropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        PropertiesValue self = new PropertiesValue();
        return TeaModel.build(map, self);
    }

    public PropertiesValue setValue(Object value) {
        this.value = value;
        return this;
    }
    public Object getValue() {
        return this.value;
    }

    public PropertiesValue setTimestamp(String timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public String getTimestamp() {
        return this.timestamp;
    }

}
