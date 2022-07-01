// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListRequest extends TeaModel {
    // 创建人类型。0-全部；1-我创建的；2-他人创建；不填也是查全部。
    @NameInMap("creatorType")
    public Integer creatorType;

    // 访问文档类型：0-文字；1-表格；2-PPT；3-白板；6-脑图；7-多维表；不填的话，则默认是所有。
    @NameInMap("fileType")
    public Integer fileType;

    // 每页最大条目数，最大值50。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，第一页可不传。
    @NameInMap("nextToken")
    public String nextToken;

    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 最近列表的类型：0-最近访问；1-最近编辑。
    @NameInMap("recentType")
    public Integer recentType;

    public static QueryRecentListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentListRequest self = new QueryRecentListRequest();
        return TeaModel.build(map, self);
    }

    public QueryRecentListRequest setCreatorType(Integer creatorType) {
        this.creatorType = creatorType;
        return this;
    }
    public Integer getCreatorType() {
        return this.creatorType;
    }

    public QueryRecentListRequest setFileType(Integer fileType) {
        this.fileType = fileType;
        return this;
    }
    public Integer getFileType() {
        return this.fileType;
    }

    public QueryRecentListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryRecentListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRecentListRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryRecentListRequest setRecentType(Integer recentType) {
        this.recentType = recentType;
        return this;
    }
    public Integer getRecentType() {
        return this.recentType;
    }

}
