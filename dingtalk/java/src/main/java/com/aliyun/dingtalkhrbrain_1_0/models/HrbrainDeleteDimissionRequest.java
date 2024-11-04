// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteDimissionRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteDimissionRequestParams> params;

    public static HrbrainDeleteDimissionRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteDimissionRequest self = new HrbrainDeleteDimissionRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteDimissionRequest setParams(java.util.List<HrbrainDeleteDimissionRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteDimissionRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteDimissionRequestParams extends TeaModel {
        @NameInMap("dimissionDate")
        public String dimissionDate;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteDimissionRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteDimissionRequestParams self = new HrbrainDeleteDimissionRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteDimissionRequestParams setDimissionDate(String dimissionDate) {
            this.dimissionDate = dimissionDate;
            return this;
        }
        public String getDimissionDate() {
            return this.dimissionDate;
        }

        public HrbrainDeleteDimissionRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
