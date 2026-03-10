// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesShrinkRequest extends TeaModel {
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

    @NameInMap("serialNumberList")
    public String serialNumberListShrink;

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

    public static GetPublicDevicesShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesShrinkRequest self = new GetPublicDevicesShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetPublicDevicesShrinkRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public GetPublicDevicesShrinkRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetPublicDevicesShrinkRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public GetPublicDevicesShrinkRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetPublicDevicesShrinkRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetPublicDevicesShrinkRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public GetPublicDevicesShrinkRequest setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
        return this;
    }
    public String getSerialNumber() {
        return this.serialNumber;
    }

    public GetPublicDevicesShrinkRequest setSerialNumberListShrink(String serialNumberListShrink) {
        this.serialNumberListShrink = serialNumberListShrink;
        return this;
    }
    public String getSerialNumberListShrink() {
        return this.serialNumberListShrink;
    }

    public GetPublicDevicesShrinkRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetPublicDevicesShrinkRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
