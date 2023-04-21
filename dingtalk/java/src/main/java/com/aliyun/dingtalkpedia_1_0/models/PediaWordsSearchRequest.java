// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsSearchRequest extends TeaModel {
    /**
     * <p>当前查询的页数，当超过总数后返回数据为空</p>
     * <br>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>当前每页需要展示的数量，最大20</p>
     * <br>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>当前搜索列表的状态0代表审核通过，1代表创建待审核，2代表更新待审核列表</p>
     * <p>默认是0，代表获取所有审核完成的词条</p>
     * <br>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>通过开放平台获取的员工编号userId</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>搜索关键词</p>
     * <br>
     */
    @NameInMap("wordName")
    public String wordName;

    public static PediaWordsSearchRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsSearchRequest self = new PediaWordsSearchRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsSearchRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PediaWordsSearchRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public PediaWordsSearchRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public PediaWordsSearchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsSearchRequest setWordName(String wordName) {
        this.wordName = wordName;
        return this;
    }
    public String getWordName() {
        return this.wordName;
    }

}
