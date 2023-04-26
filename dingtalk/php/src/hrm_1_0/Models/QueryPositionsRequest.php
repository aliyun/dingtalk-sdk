<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPositionsRequest extends Model
{
    /**
     * @example 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @var string[]
     */
    public $inCategoryIds;

    /**
     * @var string[]
     */
    public $inPositionIds;

    /**
     * @example 职位名称
     *
     * @var string
     */
    public $positionName;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'deptId'        => 'deptId',
        'inCategoryIds' => 'inCategoryIds',
        'inPositionIds' => 'inPositionIds',
        'positionName'  => 'positionName',
        'maxResults'    => 'maxResults',
        'nextToken'     => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->inCategoryIds) {
            $res['inCategoryIds'] = $this->inCategoryIds;
        }
        if (null !== $this->inPositionIds) {
            $res['inPositionIds'] = $this->inPositionIds;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
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
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
