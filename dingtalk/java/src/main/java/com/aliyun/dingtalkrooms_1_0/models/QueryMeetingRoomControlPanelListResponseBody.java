// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomControlPanelListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("result")
    public java.util.List<QueryMeetingRoomControlPanelListResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryMeetingRoomControlPanelListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomControlPanelListResponseBody self = new QueryMeetingRoomControlPanelListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomControlPanelListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryMeetingRoomControlPanelListResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryMeetingRoomControlPanelListResponseBody setResult(java.util.List<QueryMeetingRoomControlPanelListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryMeetingRoomControlPanelListResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryMeetingRoomControlPanelListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("enName")
        public String enName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.taoxxxxx.com">https://www.taoxxxxx.com</a></p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>栗子xx</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("showTime")
        public Integer showTime;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("sort")
        public Integer sort;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.taoxxxxx.com">https://www.taoxxxxx.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig self = new QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setEnName(String enName) {
            this.enName = enName;
            return this;
        }
        public String getEnName() {
            return this.enName;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setShowTime(Integer showTime) {
            this.showTime = showTime;
            return this;
        }
        public Integer getShowTime() {
            return this.showTime;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setSort(Integer sort) {
            this.sort = sort;
            return this;
        }
        public Integer getSort() {
            return this.sort;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class QueryMeetingRoomControlPanelListResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1WADFxxxxxx</p>
         */
        @NameInMap("roomId")
        public String roomId;

        @NameInMap("roomIotConfig")
        public java.util.List<QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig> roomIotConfig;

        public static QueryMeetingRoomControlPanelListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomControlPanelListResponseBodyResult self = new QueryMeetingRoomControlPanelListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomControlPanelListResponseBodyResult setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

        public QueryMeetingRoomControlPanelListResponseBodyResult setRoomIotConfig(java.util.List<QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig> roomIotConfig) {
            this.roomIotConfig = roomIotConfig;
            return this;
        }
        public java.util.List<QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig> getRoomIotConfig() {
            return this.roomIotConfig;
        }

    }

}
