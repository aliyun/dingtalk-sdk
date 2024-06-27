// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryChannelStaffInfoByMobileResponseBody extends TeaModel {
    @NameInMap("empInfo")
    public QueryChannelStaffInfoByMobileResponseBodyEmpInfo empInfo;

    @NameInMap("exclusiveAccountEmpInfoList")
    public java.util.List<QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList> exclusiveAccountEmpInfoList;

    public static QueryChannelStaffInfoByMobileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryChannelStaffInfoByMobileResponseBody self = new QueryChannelStaffInfoByMobileResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryChannelStaffInfoByMobileResponseBody setEmpInfo(QueryChannelStaffInfoByMobileResponseBodyEmpInfo empInfo) {
        this.empInfo = empInfo;
        return this;
    }
    public QueryChannelStaffInfoByMobileResponseBodyEmpInfo getEmpInfo() {
        return this.empInfo;
    }

    public QueryChannelStaffInfoByMobileResponseBody setExclusiveAccountEmpInfoList(java.util.List<QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList> exclusiveAccountEmpInfoList) {
        this.exclusiveAccountEmpInfoList = exclusiveAccountEmpInfoList;
        return this;
    }
    public java.util.List<QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList> getExclusiveAccountEmpInfoList() {
        return this.exclusiveAccountEmpInfoList;
    }

    public static class QueryChannelStaffInfoByMobileResponseBodyEmpInfo extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryChannelStaffInfoByMobileResponseBodyEmpInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryChannelStaffInfoByMobileResponseBodyEmpInfo self = new QueryChannelStaffInfoByMobileResponseBodyEmpInfo();
            return TeaModel.build(map, self);
        }

        public QueryChannelStaffInfoByMobileResponseBodyEmpInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryChannelStaffInfoByMobileResponseBodyEmpInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList self = new QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList();
            return TeaModel.build(map, self);
        }

        public QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
