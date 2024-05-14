<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListRecycleFilesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
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
    public $orderType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $recycleType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'orderType'   => 'orderType',
        'recycleType' => 'recycleType',
        'unionId'     => 'unionId',
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
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->recycleType) {
            $res['recycleType'] = $this->recycleType;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecycleFilesRequest
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
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['recycleType'])) {
            $model->recycleType = $map['recycleType'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
