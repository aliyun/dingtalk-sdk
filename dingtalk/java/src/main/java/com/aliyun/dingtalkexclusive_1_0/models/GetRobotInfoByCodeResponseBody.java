// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRobotInfoByCodeResponseBody extends TeaModel {
    @NameInMap("robotInfoVO")
    public GetRobotInfoByCodeResponseBodyRobotInfoVO robotInfoVO;

    public static GetRobotInfoByCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRobotInfoByCodeResponseBody self = new GetRobotInfoByCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRobotInfoByCodeResponseBody setRobotInfoVO(GetRobotInfoByCodeResponseBodyRobotInfoVO robotInfoVO) {
        this.robotInfoVO = robotInfoVO;
        return this;
    }
    public GetRobotInfoByCodeResponseBodyRobotInfoVO getRobotInfoVO() {
        return this.robotInfoVO;
    }

    public static class GetRobotInfoByCodeResponseBodyRobotInfoVO extends TeaModel {
        @NameInMap("agentId")
        public Long agentId;

        @NameInMap("brief")
        public String brief;

        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public String name;

        @NameInMap("robotOrganization")
        public Long robotOrganization;

        public static GetRobotInfoByCodeResponseBodyRobotInfoVO build(java.util.Map<String, ?> map) throws Exception {
            GetRobotInfoByCodeResponseBodyRobotInfoVO self = new GetRobotInfoByCodeResponseBodyRobotInfoVO();
            return TeaModel.build(map, self);
        }

        public GetRobotInfoByCodeResponseBodyRobotInfoVO setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public GetRobotInfoByCodeResponseBodyRobotInfoVO setBrief(String brief) {
            this.brief = brief;
            return this;
        }
        public String getBrief() {
            return this.brief;
        }

        public GetRobotInfoByCodeResponseBodyRobotInfoVO setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetRobotInfoByCodeResponseBodyRobotInfoVO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRobotInfoByCodeResponseBodyRobotInfoVO setRobotOrganization(Long robotOrganization) {
            this.robotOrganization = robotOrganization;
            return this;
        }
        public Long getRobotOrganization() {
            return this.robotOrganization;
        }

    }

}
