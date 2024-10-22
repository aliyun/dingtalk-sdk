<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBookingBlacklistRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $blacklistUnionId;

    /**
     * @example 1728539655110
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 备注
     *
     * @var string
     */
    public $memo;

    /**
     * @description This parameter is required.
     *
     * @example 1728539655017
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'blacklistUnionId' => 'blacklistUnionId',
        'endTime'          => 'endTime',
        'memo'             => 'memo',
        'startTime'        => 'startTime',
        'unionId'          => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blacklistUnionId) {
            $res['blacklistUnionId'] = $this->blacklistUnionId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBookingBlacklistRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blacklistUnionId'])) {
            $model->blacklistUnionId = $map['blacklistUnionId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
