<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryInterviewsRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example xxx
     *
     * @var string
     */
    public $candidateId;

    /**
     * @example 1626796800000
     *
     * @var int
     */
    public $startTimeBeginMillis;

    /**
     * @example 1626883199000
     *
     * @var int
     */
    public $startTimeEndMillis;

    /**
     * @example xxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 10
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'bizCode'              => 'bizCode',
        'candidateId'          => 'candidateId',
        'startTimeBeginMillis' => 'startTimeBeginMillis',
        'startTimeEndMillis'   => 'startTimeEndMillis',
        'nextToken'            => 'nextToken',
        'size'                 => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->candidateId) {
            $res['candidateId'] = $this->candidateId;
        }
        if (null !== $this->startTimeBeginMillis) {
            $res['startTimeBeginMillis'] = $this->startTimeBeginMillis;
        }
        if (null !== $this->startTimeEndMillis) {
            $res['startTimeEndMillis'] = $this->startTimeEndMillis;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInterviewsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['candidateId'])) {
            $model->candidateId = $map['candidateId'];
        }
        if (isset($map['startTimeBeginMillis'])) {
            $model->startTimeBeginMillis = $map['startTimeBeginMillis'];
        }
        if (isset($map['startTimeEndMillis'])) {
            $model->startTimeEndMillis = $map['startTimeEndMillis'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
