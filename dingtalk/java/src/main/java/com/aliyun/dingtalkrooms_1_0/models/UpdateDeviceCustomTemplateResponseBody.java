// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceCustomTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateDeviceCustomTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceCustomTemplateResponseBody self = new UpdateDeviceCustomTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceCustomTemplateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
