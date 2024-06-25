// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryBizOptLogResponseBodyContent> content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryBizOptLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBizOptLogResponseBody self = new QueryBizOptLogResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBizOptLogResponseBody setContent(java.util.List<QueryBizOptLogResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryBizOptLogResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryBizOptLogResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryBizOptLogResponseBodyContent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>固定值 1-医疗组</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        /**
         * <strong>example:</strong>
         * <p>1-钉钉数据，2-自建数据</p>
         */
        @NameInMap("dataType")
        public Integer dataType;

        /**
         * <strong>example:</strong>
         * <p>23821</p>
         */
        @NameInMap("id")
        public Long id;

        @NameInMap("optAfterData")
        public String optAfterData;

        @NameInMap("optBeforeData")
        public String optBeforeData;

        /**
         * <strong>example:</strong>
         * <p>1-人员，2-部门</p>
         */
        @NameInMap("optBizType")
        public Integer optBizType;

        @NameInMap("optExtend")
        public String optExtend;

        @NameInMap("optJobNumber")
        public String optJobNumber;

        @NameInMap("optObjectCode")
        public String optObjectCode;

        @NameInMap("optObjectName")
        public String optObjectName;

        @NameInMap("optObjectUserJobNo")
        public String optObjectUserJobNo;

        /**
         * <strong>example:</strong>
         * <p>1-成功，2-失败</p>
         */
        @NameInMap("optSuccess")
        public Integer optSuccess;

        /**
         * <strong>example:</strong>
         * <p>1622191102012</p>
         */
        @NameInMap("optTime")
        public Long optTime;

        /**
         * <strong>example:</strong>
         * <p>0-删除，1-添加，2-修改，3-作废</p>
         */
        @NameInMap("optType")
        public Integer optType;

        @NameInMap("optUserCode")
        public String optUserCode;

        @NameInMap("optUserName")
        public String optUserName;

        @NameInMap("remark")
        public String remark;

        public static QueryBizOptLogResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryBizOptLogResponseBodyContent self = new QueryBizOptLogResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryBizOptLogResponseBodyContent setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryBizOptLogResponseBodyContent setDataType(Integer dataType) {
            this.dataType = dataType;
            return this;
        }
        public Integer getDataType() {
            return this.dataType;
        }

        public QueryBizOptLogResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryBizOptLogResponseBodyContent setOptAfterData(String optAfterData) {
            this.optAfterData = optAfterData;
            return this;
        }
        public String getOptAfterData() {
            return this.optAfterData;
        }

        public QueryBizOptLogResponseBodyContent setOptBeforeData(String optBeforeData) {
            this.optBeforeData = optBeforeData;
            return this;
        }
        public String getOptBeforeData() {
            return this.optBeforeData;
        }

        public QueryBizOptLogResponseBodyContent setOptBizType(Integer optBizType) {
            this.optBizType = optBizType;
            return this;
        }
        public Integer getOptBizType() {
            return this.optBizType;
        }

        public QueryBizOptLogResponseBodyContent setOptExtend(String optExtend) {
            this.optExtend = optExtend;
            return this;
        }
        public String getOptExtend() {
            return this.optExtend;
        }

        public QueryBizOptLogResponseBodyContent setOptJobNumber(String optJobNumber) {
            this.optJobNumber = optJobNumber;
            return this;
        }
        public String getOptJobNumber() {
            return this.optJobNumber;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectCode(String optObjectCode) {
            this.optObjectCode = optObjectCode;
            return this;
        }
        public String getOptObjectCode() {
            return this.optObjectCode;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectName(String optObjectName) {
            this.optObjectName = optObjectName;
            return this;
        }
        public String getOptObjectName() {
            return this.optObjectName;
        }

        public QueryBizOptLogResponseBodyContent setOptObjectUserJobNo(String optObjectUserJobNo) {
            this.optObjectUserJobNo = optObjectUserJobNo;
            return this;
        }
        public String getOptObjectUserJobNo() {
            return this.optObjectUserJobNo;
        }

        public QueryBizOptLogResponseBodyContent setOptSuccess(Integer optSuccess) {
            this.optSuccess = optSuccess;
            return this;
        }
        public Integer getOptSuccess() {
            return this.optSuccess;
        }

        public QueryBizOptLogResponseBodyContent setOptTime(Long optTime) {
            this.optTime = optTime;
            return this;
        }
        public Long getOptTime() {
            return this.optTime;
        }

        public QueryBizOptLogResponseBodyContent setOptType(Integer optType) {
            this.optType = optType;
            return this;
        }
        public Integer getOptType() {
            return this.optType;
        }

        public QueryBizOptLogResponseBodyContent setOptUserCode(String optUserCode) {
            this.optUserCode = optUserCode;
            return this;
        }
        public String getOptUserCode() {
            return this.optUserCode;
        }

        public QueryBizOptLogResponseBodyContent setOptUserName(String optUserName) {
            this.optUserName = optUserName;
            return this;
        }
        public String getOptUserName() {
            return this.optUserName;
        }

        public QueryBizOptLogResponseBodyContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

    }

}
