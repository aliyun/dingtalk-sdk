// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFilterResponseBody extends TeaModel {
    @NameInMap("criteria")
    public java.util.Map<String, CriteriaValue> criteria;

    @NameInMap("id")
    public String id;

    @NameInMap("range")
    public String range;

    public static GetFilterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFilterResponseBody self = new GetFilterResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFilterResponseBody setCriteria(java.util.Map<String, CriteriaValue> criteria) {
        this.criteria = criteria;
        return this;
    }
    public java.util.Map<String, CriteriaValue> getCriteria() {
        return this.criteria;
    }

    public GetFilterResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetFilterResponseBody setRange(String range) {
        this.range = range;
        return this;
    }
    public String getRange() {
        return this.range;
    }

}
