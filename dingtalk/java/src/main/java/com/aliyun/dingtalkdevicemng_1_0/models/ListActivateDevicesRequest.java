// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListActivateDevicesRequest extends TeaModel {
    // 设备分类（0：设备，1 : 助手）
    @NameInMap("deviceCategory")
    public Integer deviceCategory;

    // deviceCode
    @NameInMap("deviceCode")
    public String deviceCode;

    // deviceTypeId
    @NameInMap("deviceTypeId")
    public String deviceTypeId;

    // groupId
    @NameInMap("groupId")
    public String groupId;

    // pageNo
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // pageSize
    @NameInMap("pageSize")
    public Integer pageSize;

    public static ListActivateDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListActivateDevicesRequest self = new ListActivateDevicesRequest();
        return TeaModel.build(map, self);
    }

    public ListActivateDevicesRequest setDeviceCategory(Integer deviceCategory) {
        this.deviceCategory = deviceCategory;
        return this;
    }
    public Integer getDeviceCategory() {
        return this.deviceCategory;
    }

    public ListActivateDevicesRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public ListActivateDevicesRequest setDeviceTypeId(String deviceTypeId) {
        this.deviceTypeId = deviceTypeId;
        return this;
    }
    public String getDeviceTypeId() {
        return this.deviceTypeId;
    }

    public ListActivateDevicesRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public ListActivateDevicesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListActivateDevicesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
