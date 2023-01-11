// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPackageListGetRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>分页设置</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>每页内容数量</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static HPackageListGetRequest build(java.util.Map<String, ?> map) throws Exception {
        HPackageListGetRequest self = new HPackageListGetRequest();
        return TeaModel.build(map, self);
    }

    public HPackageListGetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public HPackageListGetRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public HPackageListGetRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
