// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryOpportunityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchQueryOpportunityTagResponseBodyResult result;

    public static BatchQueryOpportunityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOpportunityTagResponseBody self = new BatchQueryOpportunityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryOpportunityTagResponseBody setResult(BatchQueryOpportunityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchQueryOpportunityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchQueryOpportunityTagResponseBodyResultOpportunityList extends TeaModel {
        @NameInMap("activeUserCnt7d")
        public Long activeUserCnt7d;

        @NameInMap("appActiveState")
        public String appActiveState;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("fstFunnelsourceNameLv1")
        public String fstFunnelsourceNameLv1;

        @NameInMap("funnelsourceNameLv1")
        public String funnelsourceNameLv1;

        public static BatchQueryOpportunityTagResponseBodyResultOpportunityList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryOpportunityTagResponseBodyResultOpportunityList self = new BatchQueryOpportunityTagResponseBodyResultOpportunityList();
            return TeaModel.build(map, self);
        }

        public BatchQueryOpportunityTagResponseBodyResultOpportunityList setActiveUserCnt7d(Long activeUserCnt7d) {
            this.activeUserCnt7d = activeUserCnt7d;
            return this;
        }
        public Long getActiveUserCnt7d() {
            return this.activeUserCnt7d;
        }

        public BatchQueryOpportunityTagResponseBodyResultOpportunityList setAppActiveState(String appActiveState) {
            this.appActiveState = appActiveState;
            return this;
        }
        public String getAppActiveState() {
            return this.appActiveState;
        }

        public BatchQueryOpportunityTagResponseBodyResultOpportunityList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BatchQueryOpportunityTagResponseBodyResultOpportunityList setFstFunnelsourceNameLv1(String fstFunnelsourceNameLv1) {
            this.fstFunnelsourceNameLv1 = fstFunnelsourceNameLv1;
            return this;
        }
        public String getFstFunnelsourceNameLv1() {
            return this.fstFunnelsourceNameLv1;
        }

        public BatchQueryOpportunityTagResponseBodyResultOpportunityList setFunnelsourceNameLv1(String funnelsourceNameLv1) {
            this.funnelsourceNameLv1 = funnelsourceNameLv1;
            return this;
        }
        public String getFunnelsourceNameLv1() {
            return this.funnelsourceNameLv1;
        }

    }

    public static class BatchQueryOpportunityTagResponseBodyResult extends TeaModel {
        @NameInMap("opportunityList")
        public java.util.List<BatchQueryOpportunityTagResponseBodyResultOpportunityList> opportunityList;

        public static BatchQueryOpportunityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryOpportunityTagResponseBodyResult self = new BatchQueryOpportunityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchQueryOpportunityTagResponseBodyResult setOpportunityList(java.util.List<BatchQueryOpportunityTagResponseBodyResultOpportunityList> opportunityList) {
            this.opportunityList = opportunityList;
            return this;
        }
        public java.util.List<BatchQueryOpportunityTagResponseBodyResultOpportunityList> getOpportunityList() {
            return this.opportunityList;
        }

    }

}
