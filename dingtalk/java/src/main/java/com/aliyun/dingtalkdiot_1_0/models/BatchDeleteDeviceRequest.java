// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchDeleteDeviceRequest extends TeaModel {
    // 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
    @NameInMap("corpId")
    public String corpId;

    // 设备ID列表，最多500条。
    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static BatchDeleteDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteDeviceRequest self = new BatchDeleteDeviceRequest();
        return TeaModel.build(map, self);
    }

    public BatchDeleteDeviceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchDeleteDeviceRequest setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
