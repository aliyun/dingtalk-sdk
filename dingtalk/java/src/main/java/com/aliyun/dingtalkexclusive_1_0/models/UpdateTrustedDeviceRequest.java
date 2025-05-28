// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateTrustedDeviceRequest extends TeaModel {
    @NameInMap("status")
    public Integer status;

    @NameInMap("title")
    public String title;

    public static UpdateTrustedDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTrustedDeviceRequest self = new UpdateTrustedDeviceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTrustedDeviceRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateTrustedDeviceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
