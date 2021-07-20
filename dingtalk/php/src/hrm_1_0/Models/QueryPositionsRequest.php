<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPositionsRequest extends Model
{
    /**
     * @description 职位名称
     *
     * @var string
     */
    public $positionName;

    /**
     * @description 职位类别列表
     *
     * @var string[]
     */
    public $inCategoryIds;

    /**
     * @description 职位id列表
     *
     * @var string[]
     */
    public $inPositionIds;

    /**
     * @description 偏移量
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 一次查询获取记录数
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'positionName'  => 'positionName',
        'inCategoryIds' => 'inCategoryIds',
        'inPositionIds' => 'inPositionIds',
        'nextToken'     => 'nextToken',
        'maxResults'    => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->inCategoryIds) {
            $res['inCategoryIds'] = $this->inCategoryIds;
        }
        if (null !== $this->inPositionIds) {
            $res['inPositionIds'] = $this->inPositionIds;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPositionsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['inCategoryIds'])) {
            if (!empty($map['inCategoryIds'])) {
                $model->inCategoryIds = $map['inCategoryIds'];
            }
        }
        if (isset($map['inPositionIds'])) {
            if (!empty($map['inPositionIds'])) {
                $model->inPositionIds = $map['inPositionIds'];
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }

        return $model;
    }
}
