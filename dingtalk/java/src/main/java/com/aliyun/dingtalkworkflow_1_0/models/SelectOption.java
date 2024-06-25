// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SelectOption extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>finance</p>
     */
    @NameInMap("key")
    public String key;

    /**
     * <strong>example:</strong>
     * <p>财务</p>
     */
    @NameInMap("value")
    public String value;

    public static SelectOption build(java.util.Map<String, ?> map) throws Exception {
        SelectOption self = new SelectOption();
        return TeaModel.build(map, self);
    }

    public SelectOption setKey(String key) {
        this.key = key;
        return this;
    }
    public String getKey() {
        return this.key;
    }

    public SelectOption setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

}
