// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetThingOrgIdByDingOrgIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public GetThingOrgIdByDingOrgIdResponseBodyResult result;

    public static GetThingOrgIdByDingOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetThingOrgIdByDingOrgIdResponseBody self = new GetThingOrgIdByDingOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetThingOrgIdByDingOrgIdResponseBody setResult(GetThingOrgIdByDingOrgIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetThingOrgIdByDingOrgIdResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetThingOrgIdByDingOrgIdResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>50c32afae8cf1439xxxx</p>
         */
        @NameInMap("tbOrganizationId")
        public String tbOrganizationId;

        public static GetThingOrgIdByDingOrgIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetThingOrgIdByDingOrgIdResponseBodyResult self = new GetThingOrgIdByDingOrgIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetThingOrgIdByDingOrgIdResponseBodyResult setTbOrganizationId(String tbOrganizationId) {
            this.tbOrganizationId = tbOrganizationId;
            return this;
        }
        public String getTbOrganizationId() {
            return this.tbOrganizationId;
        }

    }

}
