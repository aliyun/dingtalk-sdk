// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoriesTemplatesResponseBody extends TeaModel {
    @NameInMap("map")
    public java.util.Map<String, java.util.List<MapValue>> map;

    public static CategoriesTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CategoriesTemplatesResponseBody self = new CategoriesTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public CategoriesTemplatesResponseBody setMap(java.util.Map<String, java.util.List<MapValue>> map) {
        this.map = map;
        return this;
    }
    public java.util.Map<String, java.util.List<MapValue>> getMap() {
        return this.map;
    }

}
