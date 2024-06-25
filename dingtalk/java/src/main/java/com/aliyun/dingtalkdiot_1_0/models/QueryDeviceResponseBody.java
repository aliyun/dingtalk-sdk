// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<QueryDeviceResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>40</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceResponseBody self = new QueryDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceResponseBody setData(java.util.List<QueryDeviceResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryDeviceResponseBodyData> getData() {
        return this.data;
    }

    public QueryDeviceResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryDeviceResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryDeviceResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryDeviceResponseBodyDataLiveUrls extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://abc.stream.flv">https://abc.stream.flv</a></p>
         */
        @NameInMap("flv")
        public String flv;

        /**
         * <strong>example:</strong>
         * <p><a href="https://abc.stream.m3u8">https://abc.stream.m3u8</a></p>
         */
        @NameInMap("hls")
        public String hls;

        /**
         * <strong>example:</strong>
         * <p>rtmp://abc.stream</p>
         */
        @NameInMap("rtmp")
        public String rtmp;

        public static QueryDeviceResponseBodyDataLiveUrls build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceResponseBodyDataLiveUrls self = new QueryDeviceResponseBodyDataLiveUrls();
            return TeaModel.build(map, self);
        }

        public QueryDeviceResponseBodyDataLiveUrls setFlv(String flv) {
            this.flv = flv;
            return this;
        }
        public String getFlv() {
            return this.flv;
        }

        public QueryDeviceResponseBodyDataLiveUrls setHls(String hls) {
            this.hls = hls;
            return this;
        }
        public String getHls() {
            return this.hls;
        }

        public QueryDeviceResponseBodyDataLiveUrls setRtmp(String rtmp) {
            this.rtmp = rtmp;
            return this;
        }
        public String getRtmp() {
            return this.rtmp;
        }

    }

    public static class QueryDeviceResponseBodyData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <strong>example:</strong>
         * <p>XX摄像头</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("deviceStatus")
        public Long deviceStatus;

        /**
         * <strong>example:</strong>
         * <p>CAMERA</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <strong>example:</strong>
         * <p>摄像头</p>
         */
        @NameInMap("deviceTypeName")
        public String deviceTypeName;

        @NameInMap("liveUrls")
        public QueryDeviceResponseBodyDataLiveUrls liveUrls;

        /**
         * <strong>example:</strong>
         * <p>XX地址</p>
         */
        @NameInMap("location")
        public String location;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <strong>example:</strong>
         * <p>CAMERA</p>
         */
        @NameInMap("productType")
        public String productType;

        public static QueryDeviceResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceResponseBodyData self = new QueryDeviceResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryDeviceResponseBodyData setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public QueryDeviceResponseBodyData setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryDeviceResponseBodyData setDeviceStatus(Long deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public Long getDeviceStatus() {
            return this.deviceStatus;
        }

        public QueryDeviceResponseBodyData setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public QueryDeviceResponseBodyData setDeviceTypeName(String deviceTypeName) {
            this.deviceTypeName = deviceTypeName;
            return this;
        }
        public String getDeviceTypeName() {
            return this.deviceTypeName;
        }

        public QueryDeviceResponseBodyData setLiveUrls(QueryDeviceResponseBodyDataLiveUrls liveUrls) {
            this.liveUrls = liveUrls;
            return this;
        }
        public QueryDeviceResponseBodyDataLiveUrls getLiveUrls() {
            return this.liveUrls;
        }

        public QueryDeviceResponseBodyData setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public QueryDeviceResponseBodyData setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public QueryDeviceResponseBodyData setProductType(String productType) {
            this.productType = productType;
            return this;
        }
        public String getProductType() {
            return this.productType;
        }

    }

}
