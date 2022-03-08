<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class AskRobotRequest extends Model
{
    /**
     * @var string
     */
    public $dingUserId;

    /**
     * @description 问题
     *
     * @var string
     */
    public $question;

    /**
     * @description 机器人id
     *
     * @var string
     */
    public $robotAppKey;

    /**
     * @description sessionId(非必传)
     *
     * @var string
     */
    public $sessionUuid;
    protected $_name = [
        'dingUserId'  => 'dingUserId',
        'question'    => 'question',
        'robotAppKey' => 'robotAppKey',
        'sessionUuid' => 'sessionUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->robotAppKey) {
            $res['robotAppKey'] = $this->robotAppKey;
        }
        if (null !== $this->sessionUuid) {
            $res['sessionUuid'] = $this->sessionUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AskRobotRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['robotAppKey'])) {
            $model->robotAppKey = $map['robotAppKey'];
        }
        if (isset($map['sessionUuid'])) {
            $model->sessionUuid = $map['sessionUuid'];
        }

        return $model;
    }
}
