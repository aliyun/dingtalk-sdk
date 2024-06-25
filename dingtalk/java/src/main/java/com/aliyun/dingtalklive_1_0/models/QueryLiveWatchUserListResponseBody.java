// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchUserListResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryLiveWatchUserListResponseBodyResult result;

    public static QueryLiveWatchUserListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchUserListResponseBody self = new QueryLiveWatchUserListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchUserListResponseBody setResult(QueryLiveWatchUserListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryLiveWatchUserListResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryLiveWatchUserListResponseBodyResultOrgUsesList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxx.设计部</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>DC7wZGOSueEEIGOf3WKwWgiEiE</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>214675</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>189930</p>
         */
        @NameInMap("watchLiveTime")
        public Long watchLiveTime;

        /**
         * <strong>example:</strong>
         * <p>23667</p>
         */
        @NameInMap("watchPlaybackTime")
        public Long watchPlaybackTime;

        /**
         * <strong>example:</strong>
         * <p>2330</p>
         */
        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static QueryLiveWatchUserListResponseBodyResultOrgUsesList build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveWatchUserListResponseBodyResultOrgUsesList self = new QueryLiveWatchUserListResponseBodyResultOrgUsesList();
            return TeaModel.build(map, self);
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setWatchLiveTime(Long watchLiveTime) {
            this.watchLiveTime = watchLiveTime;
            return this;
        }
        public Long getWatchLiveTime() {
            return this.watchLiveTime;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setWatchPlaybackTime(Long watchPlaybackTime) {
            this.watchPlaybackTime = watchPlaybackTime;
            return this;
        }
        public Long getWatchPlaybackTime() {
            return this.watchPlaybackTime;
        }

        public QueryLiveWatchUserListResponseBodyResultOrgUsesList setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class QueryLiveWatchUserListResponseBodyResultOutOrgUserList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>23440</p>
         */
        @NameInMap("watchLiveTime")
        public Long watchLiveTime;

        /**
         * <strong>example:</strong>
         * <p>2330</p>
         */
        @NameInMap("watchPlaybackTime")
        public Long watchPlaybackTime;

        /**
         * <strong>example:</strong>
         * <p>150</p>
         */
        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static QueryLiveWatchUserListResponseBodyResultOutOrgUserList build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveWatchUserListResponseBodyResultOutOrgUserList self = new QueryLiveWatchUserListResponseBodyResultOutOrgUserList();
            return TeaModel.build(map, self);
        }

        public QueryLiveWatchUserListResponseBodyResultOutOrgUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryLiveWatchUserListResponseBodyResultOutOrgUserList setWatchLiveTime(Long watchLiveTime) {
            this.watchLiveTime = watchLiveTime;
            return this;
        }
        public Long getWatchLiveTime() {
            return this.watchLiveTime;
        }

        public QueryLiveWatchUserListResponseBodyResultOutOrgUserList setWatchPlaybackTime(Long watchPlaybackTime) {
            this.watchPlaybackTime = watchPlaybackTime;
            return this;
        }
        public Long getWatchPlaybackTime() {
            return this.watchPlaybackTime;
        }

        public QueryLiveWatchUserListResponseBodyResultOutOrgUserList setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class QueryLiveWatchUserListResponseBodyResult extends TeaModel {
        @NameInMap("orgUsesList")
        public java.util.List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> orgUsesList;

        @NameInMap("outOrgUserList")
        public java.util.List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> outOrgUserList;

        public static QueryLiveWatchUserListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveWatchUserListResponseBodyResult self = new QueryLiveWatchUserListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryLiveWatchUserListResponseBodyResult setOrgUsesList(java.util.List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> orgUsesList) {
            this.orgUsesList = orgUsesList;
            return this;
        }
        public java.util.List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> getOrgUsesList() {
            return this.orgUsesList;
        }

        public QueryLiveWatchUserListResponseBodyResult setOutOrgUserList(java.util.List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> outOrgUserList) {
            this.outOrgUserList = outOrgUserList;
            return this;
        }
        public java.util.List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> getOutOrgUserList() {
            return this.outOrgUserList;
        }

    }

}
