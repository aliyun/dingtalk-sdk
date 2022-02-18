// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceRequest extends TeaModel {
    // 商户id
    @NameInMap("merchantId")
    public String merchantId;

    // 设备型号
    @NameInMap("model")
    public String model;

    // 设备名称
    @NameInMap("name")
    public String name;

    // 消费场景
    @NameInMap("scene")
    public Long scene;

    // sn码
    @NameInMap("sn")
    public String sn;

    // 设备状态
    @NameInMap("status")
    public Long status;

    // 设备类型
    @NameInMap("type")
    public Long type;

    public static AddDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddDeviceRequest self = new AddDeviceRequest();
        return TeaModel.build(map, self);
    }

    public AddDeviceRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public AddDeviceRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public AddDeviceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddDeviceRequest setScene(Long scene) {
        this.scene = scene;
        return this;
    }
    public Long getScene() {
        return this.scene;
    }

    public AddDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public AddDeviceRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public AddDeviceRequest setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}