<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListStarsRequest extends Model
{
    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $orderBy;

    /**
     * @var string
     */
    public $sortType;

    /**
     * @var string[]
     */
    public $supportResourceTypes;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'operatorId' => 'operatorId',
        'orderBy' => 'orderBy',
        'sortType' => 'sortType',
        'supportResourceTypes' => 'supportResourceTypes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->sortType) {
            $res['sortType'] = $this->sortType;
        }
        if (null !== $this->supportResourceTypes) {
            $res['supportResourceTypes'] = $this->supportResourceTypes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListStarsRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['sortType'])) {
            $model->sortType = $map['sortType'];
        }
        if (isset($map['supportResourceTypes'])) {
            if (!empty($map['supportResourceTypes'])) {
                $model->supportResourceTypes = $map['supportResourceTypes'];
            }
        }

        return $model;
    }
}
