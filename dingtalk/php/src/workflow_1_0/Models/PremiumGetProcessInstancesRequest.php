<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumGetProcessInstancesRequest extends Model
{
    /**
     * @example SWAPP-4C2F4B-example
     *
     * @var string
     */
    public $appUuid;

    /**
     * @example 1633795200000
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 1
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example PROC-C53-example
     *
     * @var string
     */
    public $processCode;

    /**
     * @description This parameter is required.
     *
     * @example 1631289600000
     *
     * @var int
     */
    public $startTimeInMills;
    protected $_name = [
        'appUuid' => 'appUuid',
        'endTimeInMills' => 'endTimeInMills',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'processCode' => 'processCode',
        'startTimeInMills' => 'startTimeInMills',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->endTimeInMills) {
            $res['endTimeInMills'] = $this->endTimeInMills;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->startTimeInMills) {
            $res['startTimeInMills'] = $this->startTimeInMills;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumGetProcessInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['endTimeInMills'])) {
            $model->endTimeInMills = $map['endTimeInMills'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['startTimeInMills'])) {
            $model->startTimeInMills = $map['startTimeInMills'];
        }

        return $model;
    }
}
