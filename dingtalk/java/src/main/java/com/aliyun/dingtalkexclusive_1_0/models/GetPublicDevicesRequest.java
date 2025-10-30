// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesRequest extends TeaModel {
    @NameInMap("deviceUuid")
    public String deviceUuid;

    /**
     * <strong>example:</strong>
     * <p>1671767361000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>88:66:5a:07:2b:04</p>
     */
    @NameInMap("macAddress")
    public String macAddress;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>Mac</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <strong>example:</strong>
     * <p>11-22-33-44</p>
     */
    @NameInMap("serialNumber")
    public String serialNumber;

    /**
     * <strong>example:</strong>
     * <p>1671767361000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>这是标题</p>
     */
    @NameInMap("title")
    public String title;

    public static GetPublicDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesRequest self = new GetPublicDevicesRequest();
        return TeaModel.build(map, self);
    }

    public GetPublicDevicesRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public GetPublicDevicesRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetPublicDevicesRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public GetPublicDevicesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetPublicDevicesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetPublicDevicesRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public GetPublicDevicesRequest setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
        return this;
    }
    public String getSerialNumber() {
        return this.serialNumber;
    }

    public GetPublicDevicesRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetPublicDevicesRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
