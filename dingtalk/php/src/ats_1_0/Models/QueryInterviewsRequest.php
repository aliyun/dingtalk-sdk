<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryInterviewsRequest extends Model
{
    /**
     * @description 业务标识
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 候选人标识
     *
     * @var string
     */
    public $candidateId;

    /**
     * @description 面试开始时间的查询起始时间（单位：毫秒）
     *
     * @var int
     */
    public $startTimeBeginMillis;

    /**
     * @description 面试开始时间的查询结束时间（单位：毫秒）
     *
     * @var int
     */
    public $startTimeEndMillis;

    /**
     * @description 分页游标，首次调用传空
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页大小
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
