// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListCampusGroupResponseBody extends TeaModel {
    /**
     * <p>返回项目组</p>
     */
    @NameInMap("result")
    public java.util.List<CampusListCampusGroupResponseBodyResult> result;

    public static CampusListCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusListCampusGroupResponseBody self = new CampusListCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusListCampusGroupResponseBody setResult(java.util.List<CampusListCampusGroupResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CampusListCampusGroupResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CampusListCampusGroupResponseBodyResult extends TeaModel {
        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extend")
        public String extend;

        /**
         * <p>项目组ID</p>
         */
        @NameInMap("groupDeptId")
        public Long groupDeptId;

        /**
         * <p>项目组名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        public static CampusListCampusGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CampusListCampusGroupResponseBodyResult self = new CampusListCampusGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CampusListCampusGroupResponseBodyResult setExtend(String extend) {
            this.extend = extend;
            return this;
        }
        public String getExtend() {
            return this.extend;
        }

        public CampusListCampusGroupResponseBodyResult setGroupDeptId(Long groupDeptId) {
            this.groupDeptId = groupDeptId;
            return this;
        }
        public Long getGroupDeptId() {
            return this.groupDeptId;
        }

        public CampusListCampusGroupResponseBodyResult setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
