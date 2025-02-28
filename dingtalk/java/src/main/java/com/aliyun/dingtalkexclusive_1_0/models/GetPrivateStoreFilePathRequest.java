// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFilePathRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryId")
    public Long dentryId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public Long spaceId;

    public static GetPrivateStoreFilePathRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFilePathRequest self = new GetPrivateStoreFilePathRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFilePathRequest setDentryId(Long dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public Long getDentryId() {
        return this.dentryId;
    }

    public GetPrivateStoreFilePathRequest setSpaceId(Long spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public Long getSpaceId() {
        return this.spaceId;
    }

}
