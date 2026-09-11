<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest;

use AlibabaCloud\Tea\Model;

class eventConfig extends Model
{
    /**
     * @var bool
     */
    public $allowAttendeeAddConference;

    /**
     * @var bool
     */
    public $allowAttendeeAddParticipants;

    /**
     * @var bool
     */
    public $allowAttendeeCreateComment;
    protected $_name = [
        'allowAttendeeAddConference' => 'allowAttendeeAddConference',
        'allowAttendeeAddParticipants' => 'allowAttendeeAddParticipants',
        'allowAttendeeCreateComment' => 'allowAttendeeCreateComment',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowAttendeeAddConference) {
            $res['allowAttendeeAddConference'] = $this->allowAttendeeAddConference;
        }
        if (null !== $this->allowAttendeeAddParticipants) {
            $res['allowAttendeeAddParticipants'] = $this->allowAttendeeAddParticipants;
        }
        if (null !== $this->allowAttendeeCreateComment) {
            $res['allowAttendeeCreateComment'] = $this->allowAttendeeCreateComment;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eventConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowAttendeeAddConference'])) {
            $model->allowAttendeeAddConference = $map['allowAttendeeAddConference'];
        }
        if (isset($map['allowAttendeeAddParticipants'])) {
            $model->allowAttendeeAddParticipants = $map['allowAttendeeAddParticipants'];
        }
        if (isset($map['allowAttendeeCreateComment'])) {
            $model->allowAttendeeCreateComment = $map['allowAttendeeCreateComment'];
        }

        return $model;
    }
}
