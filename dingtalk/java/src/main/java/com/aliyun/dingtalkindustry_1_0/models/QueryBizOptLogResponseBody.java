// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogResponseBody extends TeaModel {
    /**
     * <p>content</p>
     */
    @NameInMap("content")
    public java.util.List<QueryBizOptLogResponseBodyContent> content;

    /**
     * <p>下次拉取数据的起始位置</p>
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
         * <p>业务类型</p>
         */
        @NameInMap("bizType")
        public Integer bizType;

        /**
         * <p>数据类型</p>
         */
        @NameInMap("dataType")
        public Integer dataType;

        /**
         * <p>日志ID</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>操作后对象数据快照，json格式</p>
         */
        @NameInMap("optAfterData")
        public String optAfterData;

        /**
         * <p>操作前对象数据快照，json格式</p>
         */
        @NameInMap("optBeforeData")
        public String optBeforeData;

        /**
         * <p>操作业务类型</p>
         */
        @NameInMap("optBizType")
        public Integer optBizType;

        /**
         * <p>扩展信息，map json格式</p>
         */
        @NameInMap("optExtend")
        public String optExtend;

        /**
         * <p>操作者工号</p>
         */
        @NameInMap("optJobNumber")
        public String optJobNumber;

        /**
         * <p>操作对象code，人员code，或者部门code</p>
         */
        @NameInMap("optObjectCode")
        public String optObjectCode;

        /**
         * <p>操作对象名称</p>
         */
        @NameInMap("optObjectName")
        public String optObjectName;

        /**
         * <p>操作对象人员工号</p>
         */
        @NameInMap("optObjectUserJobNo")
        public String optObjectUserJobNo;

        /**
         * <p>操作是否成功</p>
         */
        @NameInMap("optSuccess")
        public Integer optSuccess;

        /**
         * <p>操作时间 时间戳</p>
         */
        @NameInMap("optTime")
        public Long optTime;

        /**
         * <p>操作类型</p>
         */
        @NameInMap("optType")
        public Integer optType;

        /**
         * <p>操作用户code</p>
         */
        @NameInMap("optUserCode")
        public String optUserCode;

        /**
         * <p>操作用户名称</p>
         */
        @NameInMap("optUserName")
        public String optUserName;

        /**
         * <p>备注</p>
         */
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
