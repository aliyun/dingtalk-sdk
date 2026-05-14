<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordResponseBody\result\team;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordResponseBody\result\user;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $customerId;

    /**
     * @var string
     */
    public $deviceSn;

    /**
     * @var string
     */
    public $duration;

    /**
     * @var int
     */
    public $endTimestamp;

    /**
     * @var string
     */
    public $outBizData;

    /**
     * @var int
     */
    public $qualityInspectionScore;

    /**
     * @var string
     */
    public $recordId;

    /**
     * @var int
     */
    public $startTimestamp;

    /**
     * @var team
     */
    public $team;

    /**
     * @var user
     */
    public $user;

    /**
     * @var bool
     */
    public $valid;
    protected $_name = [
        'customerId' => 'customerId',
        'deviceSn' => 'deviceSn',
        'duration' => 'duration',
        'endTimestamp' => 'endTimestamp',
        'outBizData' => 'outBizData',
        'qualityInspectionScore' => 'qualityInspectionScore',
        'recordId' => 'recordId',
        'startTimestamp' => 'startTimestamp',
        'team' => 'team',
        'user' => 'user',
        'valid' => 'valid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTimestamp) {
            $res['endTimestamp'] = $this->endTimestamp;
        }
        if (null !== $this->outBizData) {
            $res['outBizData'] = $this->outBizData;
        }
        if (null !== $this->qualityInspectionScore) {
            $res['qualityInspectionScore'] = $this->qualityInspectionScore;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->startTimestamp) {
            $res['startTimestamp'] = $this->startTimestamp;
        }
        if (null !== $this->team) {
            $res['team'] = null !== $this->team ? $this->team->toMap() : null;
        }
        if (null !== $this->user) {
            $res['user'] = null !== $this->user ? $this->user->toMap() : null;
        }
        if (null !== $this->valid) {
            $res['valid'] = $this->valid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTimestamp'])) {
            $model->endTimestamp = $map['endTimestamp'];
        }
        if (isset($map['outBizData'])) {
            $model->outBizData = $map['outBizData'];
        }
        if (isset($map['qualityInspectionScore'])) {
            $model->qualityInspectionScore = $map['qualityInspectionScore'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['startTimestamp'])) {
            $model->startTimestamp = $map['startTimestamp'];
        }
        if (isset($map['team'])) {
            $model->team = team::fromMap($map['team']);
        }
        if (isset($map['user'])) {
            $model->user = user::fromMap($map['user']);
        }
        if (isset($map['valid'])) {
            $model->valid = $map['valid'];
        }

        return $model;
    }
}
