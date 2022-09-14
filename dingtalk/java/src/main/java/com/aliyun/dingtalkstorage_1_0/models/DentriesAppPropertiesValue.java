// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DentriesAppPropertiesValue extends TeaModel {
    // 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
    @NameInMap("name")
    public String name;

    // 属性值
    @NameInMap("value")
    public String value;

    // 属性可见范围
    // 枚举值:
    // 	PUBLIC: 该属性所有App可见
    // 	PRIVATE: 该属性仅其归属App可见
    @NameInMap("visibility")
    public String visibility;

    public static DentriesAppPropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        DentriesAppPropertiesValue self = new DentriesAppPropertiesValue();
        return TeaModel.build(map, self);
    }

    public DentriesAppPropertiesValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentriesAppPropertiesValue setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public DentriesAppPropertiesValue setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
