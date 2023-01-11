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
         * <p>部门名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户id</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>员工id</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>观看直播时长</p>
         */
        @NameInMap("watchLiveTime")
        public Long watchLiveTime;

        /**
         * <p>观看回放时长</p>
         */
        @NameInMap("watchPlaybackTime")
        public Long watchPlaybackTime;

        /**
         * <p>回放观看进度</p>
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
         * <p>姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>观看直播时长</p>
         */
        @NameInMap("watchLiveTime")
        public Long watchLiveTime;

        /**
         * <p>观看回放时长</p>
         */
        @NameInMap("watchPlaybackTime")
        public Long watchPlaybackTime;

        /**
         * <p>回放观看进度</p>
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
        /**
         * <p>组织内的观看用户列表</p>
         */
        @NameInMap("orgUsesList")
        public java.util.List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> orgUsesList;

        /**
         * <p>组织外的观看用户列表</p>
         */
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
