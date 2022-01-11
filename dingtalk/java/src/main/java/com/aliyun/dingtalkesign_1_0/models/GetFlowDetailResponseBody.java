// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowDetailResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetFlowDetailResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetFlowDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDetailResponseBody self = new GetFlowDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowDetailResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetFlowDetailResponseBody setData(GetFlowDetailResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetFlowDetailResponseBodyData getData() {
        return this.data;
    }

    public GetFlowDetailResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetFlowDetailResponseBodyDataLogs extends TeaModel {
        @NameInMap("logType")
        public String logType;

        @NameInMap("operateDescription")
        public String operateDescription;

        @NameInMap("operateTime")
        public Long operateTime;

        @NameInMap("operatorAccountName")
        public String operatorAccountName;

        public static GetFlowDetailResponseBodyDataLogs build(java.util.Map<String, ?> map) throws Exception {
            GetFlowDetailResponseBodyDataLogs self = new GetFlowDetailResponseBodyDataLogs();
            return TeaModel.build(map, self);
        }

        public GetFlowDetailResponseBodyDataLogs setLogType(String logType) {
            this.logType = logType;
            return this;
        }
        public String getLogType() {
            return this.logType;
        }

        public GetFlowDetailResponseBodyDataLogs setOperateDescription(String operateDescription) {
            this.operateDescription = operateDescription;
            return this;
        }
        public String getOperateDescription() {
            return this.operateDescription;
        }

        public GetFlowDetailResponseBodyDataLogs setOperateTime(Long operateTime) {
            this.operateTime = operateTime;
            return this;
        }
        public Long getOperateTime() {
            return this.operateTime;
        }

        public GetFlowDetailResponseBodyDataLogs setOperatorAccountName(String operatorAccountName) {
            this.operatorAccountName = operatorAccountName;
            return this;
        }
        public String getOperatorAccountName() {
            return this.operatorAccountName;
        }

    }

    public static class GetFlowDetailResponseBodyData extends TeaModel {
        @NameInMap("businessSense")
        public String businessSense;

        @NameInMap("flowStatus")
        public Integer flowStatus;

        @NameInMap("initiatorAuthorizedName")
        public String initiatorAuthorizedName;

        @NameInMap("initiatorName")
        public String initiatorName;

        @NameInMap("logs")
        public java.util.List<GetFlowDetailResponseBodyDataLogs> logs;

        public static GetFlowDetailResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetFlowDetailResponseBodyData self = new GetFlowDetailResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetFlowDetailResponseBodyData setBusinessSense(String businessSense) {
            this.businessSense = businessSense;
            return this;
        }
        public String getBusinessSense() {
            return this.businessSense;
        }

        public GetFlowDetailResponseBodyData setFlowStatus(Integer flowStatus) {
            this.flowStatus = flowStatus;
            return this;
        }
        public Integer getFlowStatus() {
            return this.flowStatus;
        }

        public GetFlowDetailResponseBodyData setInitiatorAuthorizedName(String initiatorAuthorizedName) {
            this.initiatorAuthorizedName = initiatorAuthorizedName;
            return this;
        }
        public String getInitiatorAuthorizedName() {
            return this.initiatorAuthorizedName;
        }

        public GetFlowDetailResponseBodyData setInitiatorName(String initiatorName) {
            this.initiatorName = initiatorName;
            return this;
        }
        public String getInitiatorName() {
            return this.initiatorName;
        }

        public GetFlowDetailResponseBodyData setLogs(java.util.List<GetFlowDetailResponseBodyDataLogs> logs) {
            this.logs = logs;
            return this;
        }
        public java.util.List<GetFlowDetailResponseBodyDataLogs> getLogs() {
            return this.logs;
        }

    }

}
