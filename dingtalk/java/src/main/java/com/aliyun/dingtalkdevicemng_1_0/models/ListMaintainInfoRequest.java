// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListMaintainInfoRequest extends TeaModel {
    @NameInMap("deviceUuid")
    public java.util.List<String> deviceUuid;

    /**
     * <p>页码</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>页面大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static ListMaintainInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMaintainInfoRequest self = new ListMaintainInfoRequest();
        return TeaModel.build(map, self);
    }

    public ListMaintainInfoRequest setDeviceUuid(java.util.List<String> deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public java.util.List<String> getDeviceUuid() {
        return this.deviceUuid;
    }

    public ListMaintainInfoRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListMaintainInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
