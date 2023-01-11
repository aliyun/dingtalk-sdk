// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoRequest extends TeaModel {
    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>是否返回内网加签url</p>
     */
    @NameInMap("withInternalResourceUrl")
    public Boolean withInternalResourceUrl;

    /**
     * <p>是否返回区域信息</p>
     */
    @NameInMap("withRegion")
    public Boolean withRegion;

    public static GetDownloadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoRequest self = new GetDownloadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetDownloadInfoRequest setWithInternalResourceUrl(Boolean withInternalResourceUrl) {
        this.withInternalResourceUrl = withInternalResourceUrl;
        return this;
    }
    public Boolean getWithInternalResourceUrl() {
        return this.withInternalResourceUrl;
    }

    public GetDownloadInfoRequest setWithRegion(Boolean withRegion) {
        this.withRegion = withRegion;
        return this;
    }
    public Boolean getWithRegion() {
        return this.withRegion;
    }

}
