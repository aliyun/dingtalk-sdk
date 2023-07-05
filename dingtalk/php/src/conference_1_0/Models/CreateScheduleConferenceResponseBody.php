<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateScheduleConferenceResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $phones;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @example 838 722 xxxxx
     *
     * @var string
     */
    public $roomCode;

    /**
     * @example 2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx
     *
     * @var string
     */
    public $scheduleConferenceId;

    /**
     * @example https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'phones'               => 'phones',
        'requestId'            => 'requestId',
        'roomCode'             => 'roomCode',
        'scheduleConferenceId' => 'scheduleConferenceId',
        'url'                  => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->phones) {
            $res['phones'] = $this->phones;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateScheduleConferenceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['phones'])) {
            if (!empty($map['phones'])) {
                $model->phones = $map['phones'];
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
