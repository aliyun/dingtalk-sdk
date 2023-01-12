// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesRequest extends TeaModel {
    /**
     * <p>注册/申请时间止</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>设备mac地址</p>
     */
    @NameInMap("macAddress")
    public String macAddress;

    /**
     * <p>页码</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>单页条目数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>系统</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <p>注册/申请时间起</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>设备标题</p>
     */
    @NameInMap("title")
    public String title;

    public static GetPublicDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesRequest self = new GetPublicDevicesRequest();
        return TeaModel.build(map, self);
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
