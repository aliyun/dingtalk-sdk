// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageAutoFlowLogResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<PageAutoFlowLogResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMoreData")
    public Boolean hasMoreData;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static PageAutoFlowLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageAutoFlowLogResponseBody self = new PageAutoFlowLogResponseBody();
        return TeaModel.build(map, self);
    }

    public PageAutoFlowLogResponseBody setData(java.util.List<PageAutoFlowLogResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<PageAutoFlowLogResponseBodyData> getData() {
        return this.data;
    }

    public PageAutoFlowLogResponseBody setHasMoreData(Boolean hasMoreData) {
        this.hasMoreData = hasMoreData;
        return this;
    }
    public Boolean getHasMoreData() {
        return this.hasMoreData;
    }

    public PageAutoFlowLogResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public PageAutoFlowLogResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PageAutoFlowLogResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
         */
        @NameInMap("appType")
        public String appType;

        @NameInMap("elapsedTimeGMT")
        public Long elapsedTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>2021-01-01</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("flag")
        public String flag;

        @NameInMap("procInstanceId")
        public String procInstanceId;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("srcProcInstanceFinishTimeGMT")
        public String srcProcInstanceFinishTimeGMT;

        @NameInMap("srcProcInstanceId")
        public String srcProcInstanceId;

        /**
         * <strong>example:</strong>
         * <p>running</p>
         */
        @NameInMap("status")
        public Integer status;

        public static PageAutoFlowLogResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            PageAutoFlowLogResponseBodyData self = new PageAutoFlowLogResponseBodyData();
            return TeaModel.build(map, self);
        }

        public PageAutoFlowLogResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public PageAutoFlowLogResponseBodyData setElapsedTimeGMT(Long elapsedTimeGMT) {
            this.elapsedTimeGMT = elapsedTimeGMT;
            return this;
        }
        public Long getElapsedTimeGMT() {
            return this.elapsedTimeGMT;
        }

        public PageAutoFlowLogResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public PageAutoFlowLogResponseBodyData setFlag(String flag) {
            this.flag = flag;
            return this;
        }
        public String getFlag() {
            return this.flag;
        }

        public PageAutoFlowLogResponseBodyData setProcInstanceId(String procInstanceId) {
            this.procInstanceId = procInstanceId;
            return this;
        }
        public String getProcInstanceId() {
            return this.procInstanceId;
        }

        public PageAutoFlowLogResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public PageAutoFlowLogResponseBodyData setSrcProcInstanceFinishTimeGMT(String srcProcInstanceFinishTimeGMT) {
            this.srcProcInstanceFinishTimeGMT = srcProcInstanceFinishTimeGMT;
            return this;
        }
        public String getSrcProcInstanceFinishTimeGMT() {
            return this.srcProcInstanceFinishTimeGMT;
        }

        public PageAutoFlowLogResponseBodyData setSrcProcInstanceId(String srcProcInstanceId) {
            this.srcProcInstanceId = srcProcInstanceId;
            return this;
        }
        public String getSrcProcInstanceId() {
            return this.srcProcInstanceId;
        }

        public PageAutoFlowLogResponseBodyData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
