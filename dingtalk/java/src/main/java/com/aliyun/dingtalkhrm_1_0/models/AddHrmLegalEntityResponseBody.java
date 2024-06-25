// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmLegalEntityResponseBody extends TeaModel {
    @NameInMap("result")
    public AddHrmLegalEntityResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddHrmLegalEntityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddHrmLegalEntityResponseBody self = new AddHrmLegalEntityResponseBody();
        return TeaModel.build(map, self);
    }

    public AddHrmLegalEntityResponseBody setResult(AddHrmLegalEntityResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddHrmLegalEntityResponseBodyResult getResult() {
        return this.result;
    }

    public AddHrmLegalEntityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddHrmLegalEntityResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding123</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2023-01-01</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2023-01-01</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("legalEntityId")
        public String legalEntityId;

        /**
         * <strong>example:</strong>
         * <p>公司1</p>
         */
        @NameInMap("legalEntityName")
        public String legalEntityName;

        /**
         * <strong>example:</strong>
         * <p>公1</p>
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
         * <p>法人</p>
         */
        @NameInMap("legalPersonName")
        public String legalPersonName;

        public static AddHrmLegalEntityResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddHrmLegalEntityResponseBodyResult self = new AddHrmLegalEntityResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddHrmLegalEntityResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddHrmLegalEntityResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public AddHrmLegalEntityResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public AddHrmLegalEntityResponseBodyResult setLegalEntityId(String legalEntityId) {
            this.legalEntityId = legalEntityId;
            return this;
        }
        public String getLegalEntityId() {
            return this.legalEntityId;
        }

        public AddHrmLegalEntityResponseBodyResult setLegalEntityName(String legalEntityName) {
            this.legalEntityName = legalEntityName;
            return this;
        }
        public String getLegalEntityName() {
            return this.legalEntityName;
        }

        public AddHrmLegalEntityResponseBodyResult setLegalEntityShortName(String legalEntityShortName) {
            this.legalEntityShortName = legalEntityShortName;
            return this;
        }
        public String getLegalEntityShortName() {
            return this.legalEntityShortName;
        }

        public AddHrmLegalEntityResponseBodyResult setLegalEntityStatus(Integer legalEntityStatus) {
            this.legalEntityStatus = legalEntityStatus;
            return this;
        }
        public Integer getLegalEntityStatus() {
            return this.legalEntityStatus;
        }

        public AddHrmLegalEntityResponseBodyResult setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

    }

}
