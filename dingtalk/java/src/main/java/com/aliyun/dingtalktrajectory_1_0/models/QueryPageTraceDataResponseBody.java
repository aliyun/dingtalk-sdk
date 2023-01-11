// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryPageTraceDataResponseBody extends TeaModel {
    /**
     * <p>是否结束</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>轨迹点列表</p>
     */
    @NameInMap("list")
    public java.util.List<QueryPageTraceDataResponseBodyList> list;

    /**
     * <p>下一个开始位置</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryPageTraceDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPageTraceDataResponseBody self = new QueryPageTraceDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPageTraceDataResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryPageTraceDataResponseBody setList(java.util.List<QueryPageTraceDataResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryPageTraceDataResponseBodyList> getList() {
        return this.list;
    }

    public QueryPageTraceDataResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryPageTraceDataResponseBodyListCoordinates extends TeaModel {
        /**
         * <p>纬度</p>
         */
        @NameInMap("latitude")
        public Float latitude;

        /**
         * <p>经度</p>
         */
        @NameInMap("longitude")
        public Float longitude;

        public static QueryPageTraceDataResponseBodyListCoordinates build(java.util.Map<String, ?> map) throws Exception {
            QueryPageTraceDataResponseBodyListCoordinates self = new QueryPageTraceDataResponseBodyListCoordinates();
            return TeaModel.build(map, self);
        }

        public QueryPageTraceDataResponseBodyListCoordinates setLatitude(Float latitude) {
            this.latitude = latitude;
            return this;
        }
        public Float getLatitude() {
            return this.latitude;
        }

        public QueryPageTraceDataResponseBodyListCoordinates setLongitude(Float longitude) {
            this.longitude = longitude;
            return this;
        }
        public Float getLongitude() {
            return this.longitude;
        }

    }

    public static class QueryPageTraceDataResponseBodyList extends TeaModel {
        /**
         * <p>经纬度</p>
         */
        @NameInMap("coordinates")
        public QueryPageTraceDataResponseBodyListCoordinates coordinates;

        /**
         * <p>定位时间</p>
         */
        @NameInMap("gmtLocation")
        public Long gmtLocation;

        /**
         * <p>上报时间</p>
         */
        @NameInMap("gmtUpload")
        public Long gmtUpload;

        public static QueryPageTraceDataResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryPageTraceDataResponseBodyList self = new QueryPageTraceDataResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryPageTraceDataResponseBodyList setCoordinates(QueryPageTraceDataResponseBodyListCoordinates coordinates) {
            this.coordinates = coordinates;
            return this;
        }
        public QueryPageTraceDataResponseBodyListCoordinates getCoordinates() {
            return this.coordinates;
        }

        public QueryPageTraceDataResponseBodyList setGmtLocation(Long gmtLocation) {
            this.gmtLocation = gmtLocation;
            return this;
        }
        public Long getGmtLocation() {
            return this.gmtLocation;
        }

        public QueryPageTraceDataResponseBodyList setGmtUpload(Long gmtUpload) {
            this.gmtUpload = gmtUpload;
            return this;
        }
        public Long getGmtUpload() {
            return this.gmtUpload;
        }

    }

}
