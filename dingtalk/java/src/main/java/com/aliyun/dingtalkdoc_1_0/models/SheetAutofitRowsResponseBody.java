// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetAutofitRowsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    public static SheetAutofitRowsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SheetAutofitRowsResponseBody self = new SheetAutofitRowsResponseBody();
        return TeaModel.build(map, self);
    }

    public SheetAutofitRowsResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
