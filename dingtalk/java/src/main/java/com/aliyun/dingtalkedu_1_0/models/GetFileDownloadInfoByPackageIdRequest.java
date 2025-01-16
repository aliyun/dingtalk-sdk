// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoByPackageIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("packageId")
    public String packageId;

    public static GetFileDownloadInfoByPackageIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoByPackageIdRequest self = new GetFileDownloadInfoByPackageIdRequest();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoByPackageIdRequest setPackageId(String packageId) {
        this.packageId = packageId;
        return this;
    }
    public String getPackageId() {
        return this.packageId;
    }

}
