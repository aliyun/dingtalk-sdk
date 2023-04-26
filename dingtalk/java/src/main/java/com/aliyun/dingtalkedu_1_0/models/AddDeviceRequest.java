// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceRequest extends TeaModel {
    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("model")
    public String model;

    @NameInMap("name")
    public String name;

    @NameInMap("scene")
    public Long scene;

    @NameInMap("sn")
    public String sn;

    @NameInMap("status")
    public Long status;

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
