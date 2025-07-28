<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSubmitStatisticsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1507564800000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example user123
     *
     * @var string
     */
    public $operationUserId;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $remindId;

    /**
     * @description This parameter is required.
     *
     * @example 1507564800000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 18xxxxx
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'endTime' => 'endTime',
        'operationUserId' => 'operationUserId',
        'remindId' => 'remindId',
        'startTime' => 'startTime',
        'templateId' => 'templateId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->operationUserId) {
            $res['operationUserId'] = $this->operationUserId;
        }
        if (null !== $this->remindId) {
            $res['remindId'] = $this->remindId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSubmitStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['operationUserId'])) {
            $model->operationUserId = $map['operationUserId'];
        }
        if (isset($map['remindId'])) {
            $model->remindId = $map['remindId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
