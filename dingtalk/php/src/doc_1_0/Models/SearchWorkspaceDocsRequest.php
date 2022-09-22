<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchWorkspaceDocsRequest extends Model
{
    /**
     * @description 搜索关键字
     *
     * @var string
     */
    public $keyword;

    /**
     * @description 搜索数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 翻页Id
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 发起操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'keyword'     => 'keyword',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'operatorId'  => 'operatorId',
        'workspaceId' => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchWorkspaceDocsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }

        return $model;
    }
}
