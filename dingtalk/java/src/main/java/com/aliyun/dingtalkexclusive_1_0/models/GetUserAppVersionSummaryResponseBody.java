// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAppVersionSummaryResponseBody extends TeaModel {
    /**
     * <p>用户版本分布情况列表</p>
     */
    @NameInMap("data")
    public java.util.List<GetUserAppVersionSummaryResponseBodyData> data;

    /**
     * <p>是否有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一次请求的分页游标</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetUserAppVersionSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserAppVersionSummaryResponseBody self = new GetUserAppVersionSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserAppVersionSummaryResponseBody setData(java.util.List<GetUserAppVersionSummaryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetUserAppVersionSummaryResponseBodyData> getData() {
        return this.data;
    }

    public GetUserAppVersionSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetUserAppVersionSummaryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetUserAppVersionSummaryResponseBodyData extends TeaModel {
        /**
         * <p>版本信息</p>
         */
        @NameInMap("appVersion")
        public String appVersion;

        /**
         * <p>端信息</p>
         */
        @NameInMap("client")
        public String client;

        /**
         * <p>组织名称</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>统计日期</p>
         */
        @NameInMap("statDate")
        public String statDate;

        /**
         * <p>用户数</p>
         */
        @NameInMap("userCnt")
        public Float userCnt;

        public static GetUserAppVersionSummaryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserAppVersionSummaryResponseBodyData self = new GetUserAppVersionSummaryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserAppVersionSummaryResponseBodyData setAppVersion(String appVersion) {
            this.appVersion = appVersion;
            return this;
        }
        public String getAppVersion() {
            return this.appVersion;
        }

        public GetUserAppVersionSummaryResponseBodyData setClient(String client) {
            this.client = client;
            return this;
        }
        public String getClient() {
            return this.client;
        }

        public GetUserAppVersionSummaryResponseBodyData setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public GetUserAppVersionSummaryResponseBodyData setStatDate(String statDate) {
            this.statDate = statDate;
            return this;
        }
        public String getStatDate() {
            return this.statDate;
        }

        public GetUserAppVersionSummaryResponseBodyData setUserCnt(Float userCnt) {
            this.userCnt = userCnt;
            return this;
        }
        public Float getUserCnt() {
            return this.userCnt;
        }

    }

}
