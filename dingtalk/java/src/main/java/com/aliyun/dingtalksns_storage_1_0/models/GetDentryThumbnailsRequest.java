// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryThumbnailsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetDentryThumbnailsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryThumbnailsRequest self = new GetDentryThumbnailsRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryThumbnailsRequest setDentryIds(java.util.List<String> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<String> getDentryIds() {
        return this.dentryIds;
    }

    public GetDentryThumbnailsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
