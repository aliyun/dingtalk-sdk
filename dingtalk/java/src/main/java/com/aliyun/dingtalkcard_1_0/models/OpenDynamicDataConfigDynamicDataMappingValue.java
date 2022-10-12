// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class OpenDynamicDataConfigDynamicDataMappingValue extends TeaModel {
    // jsonPath
    @NameInMap("path")
    public String path;

    // 值的类型 (STRING: String, ARRAY: 数组, OBJECT: 对象, CHART: 图表, TABLE: 表格, INDICATOR: 指标卡)
    @NameInMap("dynamicDataValueType")
    public String dynamicDataValueType;

    public static OpenDynamicDataConfigDynamicDataMappingValue build(java.util.Map<String, ?> map) throws Exception {
        OpenDynamicDataConfigDynamicDataMappingValue self = new OpenDynamicDataConfigDynamicDataMappingValue();
        return TeaModel.build(map, self);
    }

    public OpenDynamicDataConfigDynamicDataMappingValue setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public OpenDynamicDataConfigDynamicDataMappingValue setDynamicDataValueType(String dynamicDataValueType) {
        this.dynamicDataValueType = dynamicDataValueType;
        return this;
    }
    public String getDynamicDataValueType() {
        return this.dynamicDataValueType;
    }

}
