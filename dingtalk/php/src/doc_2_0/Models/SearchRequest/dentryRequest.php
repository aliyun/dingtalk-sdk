<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest\dentryRequest\visitTimeRange;
use AlibabaCloud\Tea\Model;

class dentryRequest extends Model
{
    /**
     * @description 每页最大条目数，最大值50。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 搜索的字段。支持的有：1-标题和内容；2-标题、内容和评论；3-标题和评论；4-标题；5-内容；6-评论。
     *
     * @var int
     */
    public $searchField;

    /**
     * @description 搜索指定的文件类型。支持的类型有：1-文档；2-表格；3-脑图；4-演示；5-白板。
     *
     * @var int
     */
    public $searchFileType;

    /**
     * @description 知识库id，在指定的知识库中搜索。
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 文档内容命中了搜索关键词的时候，需要返回的文档摘要长度。
     *
     * @var int
     */
    public $summaryLength;

    /**
     * @description 文档访问时间的范围。
     *
     * @var visitTimeRange
     */
    public $visitTimeRange;
    protected $_name = [
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'searchField'    => 'searchField',
        'searchFileType' => 'searchFileType',
        'spaceId'        => 'spaceId',
        'summaryLength'  => 'summaryLength',
        'visitTimeRange' => 'visitTimeRange',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->searchField) {
            $res['searchField'] = $this->searchField;
        }
        if (null !== $this->searchFileType) {
            $res['searchFileType'] = $this->searchFileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->summaryLength) {
            $res['summaryLength'] = $this->summaryLength;
        }
        if (null !== $this->visitTimeRange) {
            $res['visitTimeRange'] = null !== $this->visitTimeRange ? $this->visitTimeRange->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['searchField'])) {
            $model->searchField = $map['searchField'];
        }
        if (isset($map['searchFileType'])) {
            $model->searchFileType = $map['searchFileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['summaryLength'])) {
            $model->summaryLength = $map['summaryLength'];
        }
        if (isset($map['visitTimeRange'])) {
            $model->visitTimeRange = visitTimeRange::fromMap($map['visitTimeRange']);
        }

        return $model;
    }
}
