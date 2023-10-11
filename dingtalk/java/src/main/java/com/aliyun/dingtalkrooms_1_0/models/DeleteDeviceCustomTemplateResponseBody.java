// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceCustomTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteDeviceCustomTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceCustomTemplateResponseBody self = new DeleteDeviceCustomTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceCustomTemplateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
