// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetJobInfoByJobIdResponseBody extends TeaModel {
    @NameInMap("createTime")
    public Long createTime;

    @NameInMap("headCount")
    public Long headCount;

    @NameInMap("jobId")
    public String jobId;

    @NameInMap("jobOwners")
    public java.util.List<GetJobInfoByJobIdResponseBodyJobOwners> jobOwners;

    @NameInMap("mainDeptId")
    public Long mainDeptId;

    @NameInMap("mainDeptName")
    public String mainDeptName;

    @NameInMap("name")
    public String name;

    public static GetJobInfoByJobIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobInfoByJobIdResponseBody self = new GetJobInfoByJobIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobInfoByJobIdResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetJobInfoByJobIdResponseBody setHeadCount(Long headCount) {
        this.headCount = headCount;
        return this;
    }
    public Long getHeadCount() {
        return this.headCount;
    }

    public GetJobInfoByJobIdResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

    public GetJobInfoByJobIdResponseBody setJobOwners(java.util.List<GetJobInfoByJobIdResponseBodyJobOwners> jobOwners) {
        this.jobOwners = jobOwners;
        return this;
    }
    public java.util.List<GetJobInfoByJobIdResponseBodyJobOwners> getJobOwners() {
        return this.jobOwners;
    }

    public GetJobInfoByJobIdResponseBody setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public GetJobInfoByJobIdResponseBody setMainDeptName(String mainDeptName) {
        this.mainDeptName = mainDeptName;
        return this;
    }
    public String getMainDeptName() {
        return this.mainDeptName;
    }

    public GetJobInfoByJobIdResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public static class GetJobInfoByJobIdResponseBodyJobOwners extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetJobInfoByJobIdResponseBodyJobOwners build(java.util.Map<String, ?> map) throws Exception {
            GetJobInfoByJobIdResponseBodyJobOwners self = new GetJobInfoByJobIdResponseBodyJobOwners();
            return TeaModel.build(map, self);
        }

        public GetJobInfoByJobIdResponseBodyJobOwners setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetJobInfoByJobIdResponseBodyJobOwners setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
