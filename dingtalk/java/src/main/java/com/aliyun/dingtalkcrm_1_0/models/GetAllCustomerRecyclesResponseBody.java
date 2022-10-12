// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetAllCustomerRecyclesResponseBody extends TeaModel {
    // 是否还有下一页。
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一页的游标。
    @NameInMap("nextToken")
    public String nextToken;

    // 数据列表。
    @NameInMap("resultList")
    public java.util.List<GetAllCustomerRecyclesResponseBodyResultList> resultList;

    public static GetAllCustomerRecyclesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllCustomerRecyclesResponseBody self = new GetAllCustomerRecyclesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllCustomerRecyclesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetAllCustomerRecyclesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetAllCustomerRecyclesResponseBody setResultList(java.util.List<GetAllCustomerRecyclesResponseBodyResultList> resultList) {
        this.resultList = resultList;
        return this;
    }
    public java.util.List<GetAllCustomerRecyclesResponseBodyResultList> getResultList() {
        return this.resultList;
    }

    public static class GetAllCustomerRecyclesResponseBodyResultList extends TeaModel {
        // 客户ID
        @NameInMap("customerId")
        public String customerId;

        // 上次跟进时间
        @NameInMap("followUpActionTime")
        public String followUpActionTime;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 掉保提醒时间
        @NameInMap("notifyTime")
        public String notifyTime;

        // 掉保规则ID
        @NameInMap("recycleRuleId")
        public Long recycleRuleId;

        // 掉保时间
        @NameInMap("recycleTime")
        public String recycleTime;

        public static GetAllCustomerRecyclesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            GetAllCustomerRecyclesResponseBodyResultList self = new GetAllCustomerRecyclesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public GetAllCustomerRecyclesResponseBodyResultList setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public GetAllCustomerRecyclesResponseBodyResultList setFollowUpActionTime(String followUpActionTime) {
            this.followUpActionTime = followUpActionTime;
            return this;
        }
        public String getFollowUpActionTime() {
            return this.followUpActionTime;
        }

        public GetAllCustomerRecyclesResponseBodyResultList setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetAllCustomerRecyclesResponseBodyResultList setNotifyTime(String notifyTime) {
            this.notifyTime = notifyTime;
            return this;
        }
        public String getNotifyTime() {
            return this.notifyTime;
        }

        public GetAllCustomerRecyclesResponseBodyResultList setRecycleRuleId(Long recycleRuleId) {
            this.recycleRuleId = recycleRuleId;
            return this;
        }
        public Long getRecycleRuleId() {
            return this.recycleRuleId;
        }

        public GetAllCustomerRecyclesResponseBodyResultList setRecycleTime(String recycleTime) {
            this.recycleTime = recycleTime;
            return this;
        }
        public String getRecycleTime() {
            return this.recycleTime;
        }

    }

}
