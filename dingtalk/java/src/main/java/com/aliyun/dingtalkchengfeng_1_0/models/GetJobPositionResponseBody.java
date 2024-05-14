// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPositionResponseBody extends TeaModel {
    @NameInMap("content")
    public GetJobPositionResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    public static GetJobPositionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobPositionResponseBody self = new GetJobPositionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobPositionResponseBody setContent(GetJobPositionResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetJobPositionResponseBodyContent getContent() {
        return this.content;
    }

    public GetJobPositionResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetJobPositionResponseBodyContent extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("establishDate")
        public String establishDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobCode")
        public String jobCode;

        @NameInMap("jobRequirements")
        public String jobRequirements;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("stopDate")
        public String stopDate;

        public static GetJobPositionResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetJobPositionResponseBodyContent self = new GetJobPositionResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetJobPositionResponseBodyContent setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetJobPositionResponseBodyContent setEstablishDate(String establishDate) {
            this.establishDate = establishDate;
            return this;
        }
        public String getEstablishDate() {
            return this.establishDate;
        }

        public GetJobPositionResponseBodyContent setJobCode(String jobCode) {
            this.jobCode = jobCode;
            return this;
        }
        public String getJobCode() {
            return this.jobCode;
        }

        public GetJobPositionResponseBodyContent setJobRequirements(String jobRequirements) {
            this.jobRequirements = jobRequirements;
            return this;
        }
        public String getJobRequirements() {
            return this.jobRequirements;
        }

        public GetJobPositionResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetJobPositionResponseBodyContent setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetJobPositionResponseBodyContent setStopDate(String stopDate) {
            this.stopDate = stopDate;
            return this;
        }
        public String getStopDate() {
            return this.stopDate;
        }

    }

}
