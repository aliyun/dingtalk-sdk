// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectRolesV3ResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<GetProjectRolesV3ResponseBodyResult> result;

    public static GetProjectRolesV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectRolesV3ResponseBody self = new GetProjectRolesV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectRolesV3ResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetProjectRolesV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetProjectRolesV3ResponseBody setResult(java.util.List<GetProjectRolesV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectRolesV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectRolesV3ResponseBodyResult extends TeaModel {
        @NameInMap("display")
        public Boolean display;

        @NameInMap("id")
        public String id;

        @NameInMap("isDefaultRole")
        public Boolean isDefaultRole;

        @NameInMap("level")
        public Integer level;

        @NameInMap("name")
        public String name;

        @NameInMap("originalId")
        public String originalId;

        public static GetProjectRolesV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectRolesV3ResponseBodyResult self = new GetProjectRolesV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectRolesV3ResponseBodyResult setDisplay(Boolean display) {
            this.display = display;
            return this;
        }
        public Boolean getDisplay() {
            return this.display;
        }

        public GetProjectRolesV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetProjectRolesV3ResponseBodyResult setIsDefaultRole(Boolean isDefaultRole) {
            this.isDefaultRole = isDefaultRole;
            return this;
        }
        public Boolean getIsDefaultRole() {
            return this.isDefaultRole;
        }

        public GetProjectRolesV3ResponseBodyResult setLevel(Integer level) {
            this.level = level;
            return this;
        }
        public Integer getLevel() {
            return this.level;
        }

        public GetProjectRolesV3ResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProjectRolesV3ResponseBodyResult setOriginalId(String originalId) {
            this.originalId = originalId;
            return this;
        }
        public String getOriginalId() {
            return this.originalId;
        }

    }

}
