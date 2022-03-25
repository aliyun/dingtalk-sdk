<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCustomerTracksByRelationIdRequest extends Model
{
    /**
     * @description 每页返回的结果集个数，默认10。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 第一页不传，下一页传入上一页返回的nextToken
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 关系id。
     *
     * @var string
     */
    public $relationId;

    /**
     * @description 动态类型分组。
     *
     * @var int
     */
    public $typeGroup;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'relationId' => 'relationId',
        'typeGroup'  => 'typeGroup',
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
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }
        if (null !== $this->typeGroup) {
            $res['typeGroup'] = $this->typeGroup;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCustomerTracksByRelationIdRequest
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
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }
        if (isset($map['typeGroup'])) {
            $model->typeGroup = $map['typeGroup'];
        }

        return $model;
    }
}
