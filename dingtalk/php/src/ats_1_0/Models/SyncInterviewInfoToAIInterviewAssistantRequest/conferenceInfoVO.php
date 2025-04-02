<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\conferenceInfoVO\conferenceBookerInfoVO;
use AlibabaCloud\Tea\Model;

class conferenceInfoVO extends Model
{
    /**
     * @var conferenceBookerInfoVO
     */
    public $conferenceBookerInfoVO;

    /**
     * @var string
     */
    public $roomCode;

    /**
     * @var string
     */
    public $scheduleConferenceId;

    /**
     * @var string
     */
    public $scheduleConferenceUrl;
    protected $_name = [
        'conferenceBookerInfoVO' => 'conferenceBookerInfoVO',
        'roomCode' => 'roomCode',
        'scheduleConferenceId' => 'scheduleConferenceId',
        'scheduleConferenceUrl' => 'scheduleConferenceUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceBookerInfoVO) {
            $res['conferenceBookerInfoVO'] = null !== $this->conferenceBookerInfoVO ? $this->conferenceBookerInfoVO->toMap() : null;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }
        if (null !== $this->scheduleConferenceUrl) {
            $res['scheduleConferenceUrl'] = $this->scheduleConferenceUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conferenceInfoVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceBookerInfoVO'])) {
            $model->conferenceBookerInfoVO = conferenceBookerInfoVO::fromMap($map['conferenceBookerInfoVO']);
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }
        if (isset($map['scheduleConferenceUrl'])) {
            $model->scheduleConferenceUrl = $map['scheduleConferenceUrl'];
        }

        return $model;
    }
}
