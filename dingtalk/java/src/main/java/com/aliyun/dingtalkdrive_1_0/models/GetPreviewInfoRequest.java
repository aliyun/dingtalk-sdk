// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetPreviewInfoRequest extends TeaModel {
    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("version")
    public Long version;

    @NameInMap("watermark")
    public Boolean watermark;

    public static GetPreviewInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPreviewInfoRequest self = new GetPreviewInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPreviewInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetPreviewInfoRequest setVersion(Long version) {
        this.version = version;
        return this;
    }
    public Long getVersion() {
        return this.version;
    }

    public GetPreviewInfoRequest setWatermark(Boolean watermark) {
        this.watermark = watermark;
        return this;
    }
    public Boolean getWatermark() {
        return this.watermark;
    }

}
