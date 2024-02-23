// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetAutoFlowLogDetailResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetAutoFlowLogDetailResponseBodyData> data;

    @NameInMap("hasMoreData")
    public Boolean hasMoreData;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetAutoFlowLogDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAutoFlowLogDetailResponseBody self = new GetAutoFlowLogDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAutoFlowLogDetailResponseBody setData(java.util.List<GetAutoFlowLogDetailResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetAutoFlowLogDetailResponseBodyData> getData() {
        return this.data;
    }

    public GetAutoFlowLogDetailResponseBody setHasMoreData(Boolean hasMoreData) {
        this.hasMoreData = hasMoreData;
        return this;
    }
    public Boolean getHasMoreData() {
        return this.hasMoreData;
    }

    public GetAutoFlowLogDetailResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetAutoFlowLogDetailResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetAutoFlowLogDetailResponseBodyData extends TeaModel {
        @NameInMap("activityKey")
        public String activityKey;

        @NameInMap("elapsedTimeGMT")
        public Long elapsedTimeGMT;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("flag")
        public String flag;

        @NameInMap("inputParams")
        public java.util.Map<String, ?> inputParams;

        @NameInMap("name")
        public String name;

        @NameInMap("others")
        public String others;

        @NameInMap("outputParams")
        public java.util.Map<String, ?> outputParams;

        @NameInMap("status")
        public String status;

        @NameInMap("uuid")
        public String uuid;

        public static GetAutoFlowLogDetailResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAutoFlowLogDetailResponseBodyData self = new GetAutoFlowLogDetailResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAutoFlowLogDetailResponseBodyData setActivityKey(String activityKey) {
            this.activityKey = activityKey;
            return this;
        }
        public String getActivityKey() {
            return this.activityKey;
        }

        public GetAutoFlowLogDetailResponseBodyData setElapsedTimeGMT(Long elapsedTimeGMT) {
            this.elapsedTimeGMT = elapsedTimeGMT;
            return this;
        }
        public Long getElapsedTimeGMT() {
            return this.elapsedTimeGMT;
        }

        public GetAutoFlowLogDetailResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetAutoFlowLogDetailResponseBodyData setFlag(String flag) {
            this.flag = flag;
            return this;
        }
        public String getFlag() {
            return this.flag;
        }

        public GetAutoFlowLogDetailResponseBodyData setInputParams(java.util.Map<String, ?> inputParams) {
            this.inputParams = inputParams;
            return this;
        }
        public java.util.Map<String, ?> getInputParams() {
            return this.inputParams;
        }

        public GetAutoFlowLogDetailResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAutoFlowLogDetailResponseBodyData setOthers(String others) {
            this.others = others;
            return this;
        }
        public String getOthers() {
            return this.others;
        }

        public GetAutoFlowLogDetailResponseBodyData setOutputParams(java.util.Map<String, ?> outputParams) {
            this.outputParams = outputParams;
            return this;
        }
        public java.util.Map<String, ?> getOutputParams() {
            return this.outputParams;
        }

        public GetAutoFlowLogDetailResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetAutoFlowLogDetailResponseBodyData setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
