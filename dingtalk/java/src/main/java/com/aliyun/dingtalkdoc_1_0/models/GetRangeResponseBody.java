// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeResponseBody extends TeaModel {
    @NameInMap("displayValues")
    public java.util.List<String> displayValues;

    @NameInMap("formulas")
    public java.util.List<String> formulas;

    // 值
    @NameInMap("values")
    public java.util.List<String> values;

    public static GetRangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRangeResponseBody self = new GetRangeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRangeResponseBody setDisplayValues(java.util.List<String> displayValues) {
        this.displayValues = displayValues;
        return this;
    }
    public java.util.List<String> getDisplayValues() {
        return this.displayValues;
    }

    public GetRangeResponseBody setFormulas(java.util.List<String> formulas) {
        this.formulas = formulas;
        return this;
    }
    public java.util.List<String> getFormulas() {
        return this.formulas;
    }

    public GetRangeResponseBody setValues(java.util.List<String> values) {
        this.values = values;
        return this;
    }
    public java.util.List<String> getValues() {
        return this.values;
    }

}
