// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListHotDocsResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<DentryModel> items;

    public static ListHotDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListHotDocsResponseBody self = new ListHotDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListHotDocsResponseBody setItems(java.util.List<DentryModel> items) {
        this.items = items;
        return this;
    }
    public java.util.List<DentryModel> getItems() {
        return this.items;
    }

}
