// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetQuotaInfosRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("identifiers")
    public java.util.List<String> identifiers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetQuotaInfosRequest build(java.util.Map<String, ?> map) throws Exception {
        GetQuotaInfosRequest self = new GetQuotaInfosRequest();
        return TeaModel.build(map, self);
    }

    public GetQuotaInfosRequest setIdentifiers(java.util.List<String> identifiers) {
        this.identifiers = identifiers;
        return this;
    }
    public java.util.List<String> getIdentifiers() {
        return this.identifiers;
    }

    public GetQuotaInfosRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public GetQuotaInfosRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
