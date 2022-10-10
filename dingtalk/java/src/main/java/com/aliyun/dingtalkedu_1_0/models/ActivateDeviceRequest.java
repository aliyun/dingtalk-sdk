// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ActivateDeviceRequest extends TeaModel {
    // 授权码
    @NameInMap("licenseKey")
    public String licenseKey;

    // 设备型号
    @NameInMap("model")
    public String model;

    // 设备名称
    @NameInMap("name")
    public String name;

    // 设备sn码
    @NameInMap("sn")
    public String sn;

    // 设备类型
    @NameInMap("type")
    public String type;

    public static ActivateDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        ActivateDeviceRequest self = new ActivateDeviceRequest();
        return TeaModel.build(map, self);
    }

    public ActivateDeviceRequest setLicenseKey(String licenseKey) {
        this.licenseKey = licenseKey;
        return this;
    }
    public String getLicenseKey() {
        return this.licenseKey;
    }

    public ActivateDeviceRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public ActivateDeviceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ActivateDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ActivateDeviceRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
