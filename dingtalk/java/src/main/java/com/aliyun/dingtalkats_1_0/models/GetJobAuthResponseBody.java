// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetJobAuthResponseBody extends TeaModel {
    @NameInMap("jobId")
    public String jobId;

    @NameInMap("jobOwners")
    public java.util.List<GetJobAuthResponseBodyJobOwners> jobOwners;

    public static GetJobAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobAuthResponseBody self = new GetJobAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobAuthResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

    public GetJobAuthResponseBody setJobOwners(java.util.List<GetJobAuthResponseBodyJobOwners> jobOwners) {
        this.jobOwners = jobOwners;
        return this;
    }
    public java.util.List<GetJobAuthResponseBodyJobOwners> getJobOwners() {
        return this.jobOwners;
    }

    public static class GetJobAuthResponseBodyJobOwners extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetJobAuthResponseBodyJobOwners build(java.util.Map<String, ?> map) throws Exception {
            GetJobAuthResponseBodyJobOwners self = new GetJobAuthResponseBodyJobOwners();
            return TeaModel.build(map, self);
        }

        public GetJobAuthResponseBodyJobOwners setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetJobAuthResponseBodyJobOwners setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
