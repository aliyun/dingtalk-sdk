<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateVideoConferenceResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @var string
     */
    public $conferencePassword;

    /**
     * @var string
     */
    public $externalLinkUrl;

    /**
     * @var string
     */
    public $hostPassword;

    /**
     * @var string[]
     */
    public $phoneNumbers;

    /**
     * @var string
     */
    public $roomCode;
    protected $_name = [
        'conferenceId' => 'conferenceId',
        'conferencePassword' => 'conferencePassword',
        'externalLinkUrl' => 'externalLinkUrl',
        'hostPassword' => 'hostPassword',
        'phoneNumbers' => 'phoneNumbers',
        'roomCode' => 'roomCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->conferencePassword) {
            $res['conferencePassword'] = $this->conferencePassword;
        }
        if (null !== $this->externalLinkUrl) {
            $res['externalLinkUrl'] = $this->externalLinkUrl;
        }
        if (null !== $this->hostPassword) {
            $res['hostPassword'] = $this->hostPassword;
        }
        if (null !== $this->phoneNumbers) {
            $res['phoneNumbers'] = $this->phoneNumbers;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateVideoConferenceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['conferencePassword'])) {
            $model->conferencePassword = $map['conferencePassword'];
        }
        if (isset($map['externalLinkUrl'])) {
            $model->externalLinkUrl = $map['externalLinkUrl'];
        }
        if (isset($map['hostPassword'])) {
            $model->hostPassword = $map['hostPassword'];
        }
        if (isset($map['phoneNumbers'])) {
            if (!empty($map['phoneNumbers'])) {
                $model->phoneNumbers = $map['phoneNumbers'];
            }
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }

        return $model;
    }
}
