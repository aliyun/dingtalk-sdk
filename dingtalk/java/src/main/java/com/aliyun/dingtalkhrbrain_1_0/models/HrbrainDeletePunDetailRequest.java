// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePunDetailRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeletePunDetailRequestParams> params;

    public static HrbrainDeletePunDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePunDetailRequest self = new HrbrainDeletePunDetailRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePunDetailRequest setParams(java.util.List<HrbrainDeletePunDetailRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeletePunDetailRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeletePunDetailRequestParams extends TeaModel {
        @NameInMap("effectiveDate")
        public String effectiveDate;

        @NameInMap("punName")
        public String punName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeletePunDetailRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeletePunDetailRequestParams self = new HrbrainDeletePunDetailRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeletePunDetailRequestParams setEffectiveDate(String effectiveDate) {
            this.effectiveDate = effectiveDate;
            return this;
        }
        public String getEffectiveDate() {
            return this.effectiveDate;
        }

        public HrbrainDeletePunDetailRequestParams setPunName(String punName) {
            this.punName = punName;
            return this;
        }
        public String getPunName() {
            return this.punName;
        }

        public HrbrainDeletePunDetailRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
