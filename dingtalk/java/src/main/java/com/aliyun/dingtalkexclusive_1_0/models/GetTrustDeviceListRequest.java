// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetTrustDeviceListRequest extends TeaModel {
    @NameInMap("deviceUuid")
    public String deviceUuid;

    /**
     * <strong>example:</strong>
     * <p>1721718854814</p>
     */
    @NameInMap("gmtCreateEnd")
    public Long gmtCreateEnd;

    /**
     * <strong>example:</strong>
     * <p>1721718854814</p>
     */
    @NameInMap("gmtCreateStart")
    public Long gmtCreateStart;

    /**
     * <strong>example:</strong>
     * <p>1721718854814</p>
     */
    @NameInMap("gmtModifiedEnd")
    public Long gmtModifiedEnd;

    /**
     * <strong>example:</strong>
     * <p>1721718854814</p>
     */
    @NameInMap("gmtModifiedStart")
    public Long gmtModifiedStart;

    /**
     * <strong>example:</strong>
     * <p>xx:xx:xx:xx:xx:xx</p>
     */
    @NameInMap("macAddress")
    public String macAddress;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>Android</p>
     */
    @NameInMap("platform")
    public String platform;

    @NameInMap("serialNumber")
    public String serialNumber;

    @NameInMap("status")
    public Integer status;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetTrustDeviceListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTrustDeviceListRequest self = new GetTrustDeviceListRequest();
        return TeaModel.build(map, self);
    }

    public GetTrustDeviceListRequest setDeviceUuid(String deviceUuid) {
        this.deviceUuid = deviceUuid;
        return this;
    }
    public String getDeviceUuid() {
        return this.deviceUuid;
    }

    public GetTrustDeviceListRequest setGmtCreateEnd(Long gmtCreateEnd) {
        this.gmtCreateEnd = gmtCreateEnd;
        return this;
    }
    public Long getGmtCreateEnd() {
        return this.gmtCreateEnd;
    }

    public GetTrustDeviceListRequest setGmtCreateStart(Long gmtCreateStart) {
        this.gmtCreateStart = gmtCreateStart;
        return this;
    }
    public Long getGmtCreateStart() {
        return this.gmtCreateStart;
    }

    public GetTrustDeviceListRequest setGmtModifiedEnd(Long gmtModifiedEnd) {
        this.gmtModifiedEnd = gmtModifiedEnd;
        return this;
    }
    public Long getGmtModifiedEnd() {
        return this.gmtModifiedEnd;
    }

    public GetTrustDeviceListRequest setGmtModifiedStart(Long gmtModifiedStart) {
        this.gmtModifiedStart = gmtModifiedStart;
        return this;
    }
    public Long getGmtModifiedStart() {
        return this.gmtModifiedStart;
    }

    public GetTrustDeviceListRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public GetTrustDeviceListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetTrustDeviceListRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetTrustDeviceListRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public GetTrustDeviceListRequest setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
        return this;
    }
    public String getSerialNumber() {
        return this.serialNumber;
    }

    public GetTrustDeviceListRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetTrustDeviceListRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
