// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SelectOption extends TeaModel {
    // 每一个选项的唯一键
    @NameInMap("key")
    public String key;

    // 每一个选项的值
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
