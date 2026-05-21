<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCustomRobotOutgoingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $outgoingUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'outgoingUrl' => 'outgoingUrl',
        'token' => 'token',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->outgoingUrl) {
            $res['outgoingUrl'] = $this->outgoingUrl;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCustomRobotOutgoingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outgoingUrl'])) {
            $model->outgoingUrl = $map['outgoingUrl'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
