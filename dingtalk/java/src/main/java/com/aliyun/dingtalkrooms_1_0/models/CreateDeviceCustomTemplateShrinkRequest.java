// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceCustomTemplateShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static CreateDeviceCustomTemplateShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceCustomTemplateShrinkRequest self = new CreateDeviceCustomTemplateShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeviceCustomTemplateShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
