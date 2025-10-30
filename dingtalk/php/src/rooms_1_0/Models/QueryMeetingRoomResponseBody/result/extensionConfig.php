<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\extensionConfig\advanceReservation;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\extensionConfig\reservationCloseDetail;
use AlibabaCloud\Tea\Model;

class extensionConfig extends Model
{
    /**
     * @var advanceReservation
     */
    public $advanceReservation;

    /**
     * @var bool
     */
    public $approvalSwitch;

    /**
     * @var int
     */
    public $approvalType;

    /**
     * @example 60
     *
     * @var int
     */
    public $maxReservationTimeInterval;

    /**
     * @example 15
     *
     * @var int
     */
    public $minReservationTimeInterval;

    /**
     * @var bool
     */
    public $openReservation;

    /**
     * @var reservationCloseDetail
     */
    public $reservationCloseDetail;
    protected $_name = [
        'advanceReservation' => 'advanceReservation',
        'approvalSwitch' => 'approvalSwitch',
        'approvalType' => 'approvalType',
        'maxReservationTimeInterval' => 'maxReservationTimeInterval',
        'minReservationTimeInterval' => 'minReservationTimeInterval',
        'openReservation' => 'openReservation',
        'reservationCloseDetail' => 'reservationCloseDetail',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->advanceReservation) {
            $res['advanceReservation'] = null !== $this->advanceReservation ? $this->advanceReservation->toMap() : null;
        }
        if (null !== $this->approvalSwitch) {
            $res['approvalSwitch'] = $this->approvalSwitch;
        }
        if (null !== $this->approvalType) {
            $res['approvalType'] = $this->approvalType;
        }
        if (null !== $this->maxReservationTimeInterval) {
            $res['maxReservationTimeInterval'] = $this->maxReservationTimeInterval;
        }
        if (null !== $this->minReservationTimeInterval) {
            $res['minReservationTimeInterval'] = $this->minReservationTimeInterval;
        }
        if (null !== $this->openReservation) {
            $res['openReservation'] = $this->openReservation;
        }
        if (null !== $this->reservationCloseDetail) {
            $res['reservationCloseDetail'] = null !== $this->reservationCloseDetail ? $this->reservationCloseDetail->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extensionConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['advanceReservation'])) {
            $model->advanceReservation = advanceReservation::fromMap($map['advanceReservation']);
        }
        if (isset($map['approvalSwitch'])) {
            $model->approvalSwitch = $map['approvalSwitch'];
        }
        if (isset($map['approvalType'])) {
            $model->approvalType = $map['approvalType'];
        }
        if (isset($map['maxReservationTimeInterval'])) {
            $model->maxReservationTimeInterval = $map['maxReservationTimeInterval'];
        }
        if (isset($map['minReservationTimeInterval'])) {
            $model->minReservationTimeInterval = $map['minReservationTimeInterval'];
        }
        if (isset($map['openReservation'])) {
            $model->openReservation = $map['openReservation'];
        }
        if (isset($map['reservationCloseDetail'])) {
            $model->reservationCloseDetail = reservationCloseDetail::fromMap($map['reservationCloseDetail']);
        }

        return $model;
    }
}
