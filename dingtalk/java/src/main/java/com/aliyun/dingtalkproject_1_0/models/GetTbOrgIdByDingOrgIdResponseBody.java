// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbOrgIdByDingOrgIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public GetTbOrgIdByDingOrgIdResponseBodyResult result;

    public static GetTbOrgIdByDingOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTbOrgIdByDingOrgIdResponseBody self = new GetTbOrgIdByDingOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTbOrgIdByDingOrgIdResponseBody setResult(GetTbOrgIdByDingOrgIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTbOrgIdByDingOrgIdResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetTbOrgIdByDingOrgIdResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>50c32afae8cf1439xxxx</p>
         */
        @NameInMap("tbOrganizationId")
        public String tbOrganizationId;

        public static GetTbOrgIdByDingOrgIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTbOrgIdByDingOrgIdResponseBodyResult self = new GetTbOrgIdByDingOrgIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTbOrgIdByDingOrgIdResponseBodyResult setTbOrganizationId(String tbOrganizationId) {
            this.tbOrganizationId = tbOrganizationId;
            return this;
        }
        public String getTbOrganizationId() {
            return this.tbOrganizationId;
        }

    }

}
