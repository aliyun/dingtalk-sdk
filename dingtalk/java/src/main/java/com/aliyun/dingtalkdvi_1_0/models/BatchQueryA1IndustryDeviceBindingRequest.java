// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryA1IndustryDeviceBindingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("snList")
    public java.util.List<String> snList;

    public static BatchQueryA1IndustryDeviceBindingRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryA1IndustryDeviceBindingRequest self = new BatchQueryA1IndustryDeviceBindingRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryA1IndustryDeviceBindingRequest setSnList(java.util.List<String> snList) {
        this.snList = snList;
        return this;
    }
    public java.util.List<String> getSnList() {
        return this.snList;
    }

}
