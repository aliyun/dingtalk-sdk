// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRecognizeRecordsResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetRecognizeRecordsResponseBodyData> data;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("total")
    public Integer total;

    public static GetRecognizeRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecognizeRecordsResponseBody self = new GetRecognizeRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecognizeRecordsResponseBody setData(java.util.List<GetRecognizeRecordsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetRecognizeRecordsResponseBodyData> getData() {
        return this.data;
    }

    public GetRecognizeRecordsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetRecognizeRecordsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public static class GetRecognizeRecordsResponseBodyData extends TeaModel {
        @NameInMap("agentId")
        public Long agentId;

        @NameInMap("faceCompareResult")
        public Integer faceCompareResult;

        @NameInMap("invokeTime")
        public Long invokeTime;

        @NameInMap("platform")
        public Integer platform;

        @NameInMap("userId")
        public String userId;

        public static GetRecognizeRecordsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetRecognizeRecordsResponseBodyData self = new GetRecognizeRecordsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetRecognizeRecordsResponseBodyData setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public GetRecognizeRecordsResponseBodyData setFaceCompareResult(Integer faceCompareResult) {
            this.faceCompareResult = faceCompareResult;
            return this;
        }
        public Integer getFaceCompareResult() {
            return this.faceCompareResult;
        }

        public GetRecognizeRecordsResponseBodyData setInvokeTime(Long invokeTime) {
            this.invokeTime = invokeTime;
            return this;
        }
        public Long getInvokeTime() {
            return this.invokeTime;
        }

        public GetRecognizeRecordsResponseBodyData setPlatform(Integer platform) {
            this.platform = platform;
            return this;
        }
        public Integer getPlatform() {
            return this.platform;
        }

        public GetRecognizeRecordsResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
