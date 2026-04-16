<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteCustomRobotRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $actionType;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $sendNotification;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'actionType' => 'actionType',
        'sendNotification' => 'sendNotification',
        'token' => 'token',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->sendNotification) {
            $res['sendNotification'] = $this->sendNotification;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteCustomRobotRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['sendNotification'])) {
            $model->sendNotification = $map['sendNotification'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
