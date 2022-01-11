// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFlowDetailResponseBody extends TeaModel {
    @NameInMap("businessScene")
    public String businessScene;

    @NameInMap("flowStatus")
    public Float flowStatus;

    @NameInMap("initiatorAuthorizedName")
    public String initiatorAuthorizedName;

    @NameInMap("initiatorName")
    public String initiatorName;

    @NameInMap("logs")
    public java.util.List<GetFlowDetailResponseBodyLogs> logs;

    public static GetFlowDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDetailResponseBody self = new GetFlowDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowDetailResponseBody setBusinessScene(String businessScene) {
        this.businessScene = businessScene;
        return this;
    }
    public String getBusinessScene() {
        return this.businessScene;
    }

    public GetFlowDetailResponseBody setFlowStatus(Float flowStatus) {
        this.flowStatus = flowStatus;
        return this;
    }
    public Float getFlowStatus() {
        return this.flowStatus;
    }

    public GetFlowDetailResponseBody setInitiatorAuthorizedName(String initiatorAuthorizedName) {
        this.initiatorAuthorizedName = initiatorAuthorizedName;
        return this;
    }
    public String getInitiatorAuthorizedName() {
        return this.initiatorAuthorizedName;
    }

    public GetFlowDetailResponseBody setInitiatorName(String initiatorName) {
        this.initiatorName = initiatorName;
        return this;
    }
    public String getInitiatorName() {
        return this.initiatorName;
    }

    public GetFlowDetailResponseBody setLogs(java.util.List<GetFlowDetailResponseBodyLogs> logs) {
        this.logs = logs;
        return this;
    }
    public java.util.List<GetFlowDetailResponseBodyLogs> getLogs() {
        return this.logs;
    }

    public static class GetFlowDetailResponseBodyLogs extends TeaModel {
        @NameInMap("logType")
        public String logType;

        @NameInMap("operateDescription")
        public String operateDescription;

        @NameInMap("operateTime")
        public Float operateTime;

        @NameInMap("operatorAccountName")
        public String operatorAccountName;

        public static GetFlowDetailResponseBodyLogs build(java.util.Map<String, ?> map) throws Exception {
            GetFlowDetailResponseBodyLogs self = new GetFlowDetailResponseBodyLogs();
            return TeaModel.build(map, self);
        }

        public GetFlowDetailResponseBodyLogs setLogType(String logType) {
            this.logType = logType;
            return this;
        }
        public String getLogType() {
            return this.logType;
        }

        public GetFlowDetailResponseBodyLogs setOperateDescription(String operateDescription) {
            this.operateDescription = operateDescription;
            return this;
        }
        public String getOperateDescription() {
            return this.operateDescription;
        }

        public GetFlowDetailResponseBodyLogs setOperateTime(Float operateTime) {
            this.operateTime = operateTime;
            return this;
        }
        public Float getOperateTime() {
            return this.operateTime;
        }

        public GetFlowDetailResponseBodyLogs setOperatorAccountName(String operatorAccountName) {
            this.operatorAccountName = operatorAccountName;
            return this;
        }
        public String getOperatorAccountName() {
            return this.operatorAccountName;
        }

    }

}
