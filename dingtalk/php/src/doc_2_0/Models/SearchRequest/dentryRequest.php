<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest;

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
    protected $_name = [
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'searchFileType' => 'searchFileType',
        'spaceId'        => 'spaceId',
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
        if (null !== $this->searchFileType) {
            $res['searchFileType'] = $this->searchFileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
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
        if (isset($map['searchFileType'])) {
            $model->searchFileType = $map['searchFileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
