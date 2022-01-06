// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListActivateDevicesRequest extends TeaModel {
    // deviceTypeId
    @NameInMap("deviceTypeId")
    public String deviceTypeId;

    // pageNo
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // groupId
    @NameInMap("groupId")
    public String groupId;

    // pageSize
    @NameInMap("pageSize")
    public Integer pageSize;

    // deviceCode
    @NameInMap("deviceCode")
    public String deviceCode;

    public static ListActivateDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListActivateDevicesRequest self = new ListActivateDevicesRequest();
        return TeaModel.build(map, self);
    }

    public ListActivateDevicesRequest setDeviceTypeId(String deviceTypeId) {
        this.deviceTypeId = deviceTypeId;
        return this;
    }
    public String getDeviceTypeId() {
        return this.deviceTypeId;
    }

    public ListActivateDevicesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListActivateDevicesRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public ListActivateDevicesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListActivateDevicesRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

}