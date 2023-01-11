// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ResultItemsDentryAppPropertiesValue extends TeaModel {
    /**
     * <p>属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>属性值</p>
     */
    @NameInMap("value")
    public String value;

    /**
     * <p>属性可见范围</p>
     * <p>枚举值:</p>
     * <p>	PUBLIC: 该属性所有App可见</p>
     * <p>	PRIVATE: 该属性仅其归属App可见</p>
     */
    @NameInMap("visibility")
    public String visibility;

    public static ResultItemsDentryAppPropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        ResultItemsDentryAppPropertiesValue self = new ResultItemsDentryAppPropertiesValue();
        return TeaModel.build(map, self);
    }

    public ResultItemsDentryAppPropertiesValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ResultItemsDentryAppPropertiesValue setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public ResultItemsDentryAppPropertiesValue setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
