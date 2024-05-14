<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest;

use AlibabaCloud\Tea\Model;

class operator extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example biz222ddd
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example hrm
     *
     * @var string
     */
    public $mailAccountType;

    /**
     * @description This parameter is required.
     *
     * @example tokenabcd
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'bizId'           => 'bizId',
        'mailAccountType' => 'mailAccountType',
        'token'           => 'token',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->mailAccountType) {
            $res['mailAccountType'] = $this->mailAccountType;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return operator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['mailAccountType'])) {
            $model->mailAccountType = $map['mailAccountType'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
