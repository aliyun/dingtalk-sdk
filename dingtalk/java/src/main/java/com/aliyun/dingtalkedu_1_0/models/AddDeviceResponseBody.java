// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceResponseBody extends TeaModel {
    // 组织id
    @NameInMap("corpId")
    public String corpId;

    // 设备id
    @NameInMap("id")
    public Long id;

    // 商户id
    @NameInMap("merchantId")
    public String merchantId;

    // 设备sn码
    @NameInMap("sn")
    public String sn;

    // 状态
    @NameInMap("status")
    public Long status;

    public static AddDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddDeviceResponseBody self = new AddDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public AddDeviceResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddDeviceResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public AddDeviceResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public AddDeviceResponseBody setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public AddDeviceResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
