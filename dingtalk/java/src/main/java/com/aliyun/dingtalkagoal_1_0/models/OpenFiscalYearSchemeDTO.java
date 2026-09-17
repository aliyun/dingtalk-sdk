// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenFiscalYearSchemeDTO extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enabled")
    public Boolean enabled;

    /**
     * <strong>example:</strong>
     * <p>12起财年方案</p>
     */
    @NameInMap("schemeName")
    public String schemeName;

    /**
     * <strong>example:</strong>
     * <p>xxxxxxx</p>
     */
    @NameInMap("schemeUid")
    public String schemeUid;

    /**
     * <strong>example:</strong>
     * <p>12</p>
     */
    @NameInMap("startMonth")
    public Long startMonth;

    @NameInMap("subPeriodConfigs")
    public java.util.List<OpenFiscalYearSchemeDTOSubPeriodConfigs> subPeriodConfigs;

    public static OpenFiscalYearSchemeDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenFiscalYearSchemeDTO self = new OpenFiscalYearSchemeDTO();
        return TeaModel.build(map, self);
    }

    public OpenFiscalYearSchemeDTO setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

    public OpenFiscalYearSchemeDTO setSchemeName(String schemeName) {
        this.schemeName = schemeName;
        return this;
    }
    public String getSchemeName() {
        return this.schemeName;
    }

    public OpenFiscalYearSchemeDTO setSchemeUid(String schemeUid) {
        this.schemeUid = schemeUid;
        return this;
    }
    public String getSchemeUid() {
        return this.schemeUid;
    }

    public OpenFiscalYearSchemeDTO setStartMonth(Long startMonth) {
        this.startMonth = startMonth;
        return this;
    }
    public Long getStartMonth() {
        return this.startMonth;
    }

    public OpenFiscalYearSchemeDTO setSubPeriodConfigs(java.util.List<OpenFiscalYearSchemeDTOSubPeriodConfigs> subPeriodConfigs) {
        this.subPeriodConfigs = subPeriodConfigs;
        return this;
    }
    public java.util.List<OpenFiscalYearSchemeDTOSubPeriodConfigs> getSubPeriodConfigs() {
        return this.subPeriodConfigs;
    }

    public static class OpenFiscalYearSchemeDTOSubPeriodConfigs extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("enabled")
        public Boolean enabled;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("intervalMonth")
        public Long intervalMonth;

        /**
         * <strong>example:</strong>
         * <p>FY_HALF_YEAR</p>
         */
        @NameInMap("subPeriodType")
        public String subPeriodType;

        public static OpenFiscalYearSchemeDTOSubPeriodConfigs build(java.util.Map<String, ?> map) throws Exception {
            OpenFiscalYearSchemeDTOSubPeriodConfigs self = new OpenFiscalYearSchemeDTOSubPeriodConfigs();
            return TeaModel.build(map, self);
        }

        public OpenFiscalYearSchemeDTOSubPeriodConfigs setEnabled(Boolean enabled) {
            this.enabled = enabled;
            return this;
        }
        public Boolean getEnabled() {
            return this.enabled;
        }

        public OpenFiscalYearSchemeDTOSubPeriodConfigs setIntervalMonth(Long intervalMonth) {
            this.intervalMonth = intervalMonth;
            return this;
        }
        public Long getIntervalMonth() {
            return this.intervalMonth;
        }

        public OpenFiscalYearSchemeDTOSubPeriodConfigs setSubPeriodType(String subPeriodType) {
            this.subPeriodType = subPeriodType;
            return this;
        }
        public String getSubPeriodType() {
            return this.subPeriodType;
        }

    }

}
