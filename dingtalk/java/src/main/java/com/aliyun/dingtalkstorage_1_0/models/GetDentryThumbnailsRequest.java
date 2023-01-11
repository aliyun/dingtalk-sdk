// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryThumbnailsRequest extends TeaModel {
    /**
     * <p>文件id列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    /**
     * <p>用户id</p>
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
