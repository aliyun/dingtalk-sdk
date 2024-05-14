// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListCategorysShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public String bodyShrink;

    public static ListCategorysShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ListCategorysShrinkRequest self = new ListCategorysShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ListCategorysShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
