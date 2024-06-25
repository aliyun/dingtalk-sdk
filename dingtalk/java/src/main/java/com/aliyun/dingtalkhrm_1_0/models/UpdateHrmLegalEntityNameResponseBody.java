// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityNameResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateHrmLegalEntityNameResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateHrmLegalEntityNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityNameResponseBody self = new UpdateHrmLegalEntityNameResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityNameResponseBody setResult(UpdateHrmLegalEntityNameResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateHrmLegalEntityNameResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateHrmLegalEntityNameResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateHrmLegalEntityNameResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding123</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2023-08-08</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2023-08-08</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <strong>example:</strong>
         * <p>111233</p>
         */
        @NameInMap("legalEntityId")
        public String legalEntityId;

        /**
         * <strong>example:</strong>
         * <p>公司2</p>
         */
        @NameInMap("legalEntityName")
        public String legalEntityName;

        /**
         * <strong>example:</strong>
         * <p>公2</p>
         */
        @NameInMap("legalEntityShortName")
        public String legalEntityShortName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("legalEntityStatus")
        public Integer legalEntityStatus;

        /**
         * <strong>example:</strong>
         * <p>法人1</p>
         */
        @NameInMap("legalPersonName")
        public String legalPersonName;

        public static UpdateHrmLegalEntityNameResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityNameResponseBodyResult self = new UpdateHrmLegalEntityNameResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityId(String legalEntityId) {
            this.legalEntityId = legalEntityId;
            return this;
        }
        public String getLegalEntityId() {
            return this.legalEntityId;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityName(String legalEntityName) {
            this.legalEntityName = legalEntityName;
            return this;
        }
        public String getLegalEntityName() {
            return this.legalEntityName;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityShortName(String legalEntityShortName) {
            this.legalEntityShortName = legalEntityShortName;
            return this;
        }
        public String getLegalEntityShortName() {
            return this.legalEntityShortName;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityStatus(Integer legalEntityStatus) {
            this.legalEntityStatus = legalEntityStatus;
            return this;
        }
        public Integer getLegalEntityStatus() {
            return this.legalEntityStatus;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

    }

}
