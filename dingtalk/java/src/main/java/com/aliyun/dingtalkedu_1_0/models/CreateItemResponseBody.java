// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateItemResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("id")
    public Long id;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("status")
    public Long status;

    public static CreateItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateItemResponseBody self = new CreateItemResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateItemResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateItemResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public CreateItemResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateItemResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
