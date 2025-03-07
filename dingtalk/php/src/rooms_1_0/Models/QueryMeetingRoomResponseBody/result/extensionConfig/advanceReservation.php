<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\extensionConfig;

use AlibabaCloud\Tea\Model;

class advanceReservation extends Model
{
    /**
     * @example 09:00
     *
     * @var string
     */
    public $advanceBookTimeFormat;

    /**
     * @example 3
     *
     * @var int
     */
    public $advanceReservationTime;

    /**
     * @example days
     *
     * @var string
     */
    public $advanceReservationTimeUnit;
    protected $_name = [
        'advanceBookTimeFormat'      => 'advanceBookTimeFormat',
        'advanceReservationTime'     => 'advanceReservationTime',
        'advanceReservationTimeUnit' => 'advanceReservationTimeUnit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->advanceBookTimeFormat) {
            $res['advanceBookTimeFormat'] = $this->advanceBookTimeFormat;
        }
        if (null !== $this->advanceReservationTime) {
            $res['advanceReservationTime'] = $this->advanceReservationTime;
        }
        if (null !== $this->advanceReservationTimeUnit) {
            $res['advanceReservationTimeUnit'] = $this->advanceReservationTimeUnit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return advanceReservation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['advanceBookTimeFormat'])) {
            $model->advanceBookTimeFormat = $map['advanceBookTimeFormat'];
        }
        if (isset($map['advanceReservationTime'])) {
            $model->advanceReservationTime = $map['advanceReservationTime'];
        }
        if (isset($map['advanceReservationTimeUnit'])) {
            $model->advanceReservationTimeUnit = $map['advanceReservationTimeUnit'];
        }

        return $model;
    }
}
