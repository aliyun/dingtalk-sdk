// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListInspectInfoRequest extends TeaModel {
    @NameInMap("deviceUuid")
    public java.util.List<String> deviceUuid;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("type")
    public String type;

    public static ListInspectInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        ListInspectInfoRequest self = new ListInspectInfoRequest();
        return TeaModel.build(map, self);
    }

    public ListInspectInfoRequest setDeviceUuid(java.util.List<String> deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public java.util.List<String> getDeviceUuid() {
        return this.deviceUuid;
    }

    public ListInspectInfoRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListInspectInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListInspectInfoRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
