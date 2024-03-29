// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoPlayInfoRequest extends TeaModel {
    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("regionId")
    public String regionId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryCloudRecordVideoPlayInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoPlayInfoRequest self = new QueryCloudRecordVideoPlayInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoPlayInfoRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public QueryCloudRecordVideoPlayInfoRequest setRegionId(String regionId) {
        this.regionId = regionId;
        return this;
    }
    public String getRegionId() {
        return this.regionId;
    }

    public QueryCloudRecordVideoPlayInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
