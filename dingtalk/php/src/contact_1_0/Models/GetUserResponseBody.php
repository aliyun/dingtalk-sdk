<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserResponseBody extends Model
{
    /**
     * @var string
     */
    public $avatarUrl;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $openId;

    /**
     * @var string
     */
    public $stateCode;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'email'     => 'email',
        'mobile'    => 'mobile',
        'nick'      => 'nick',
        'openId'    => 'openId',
        'stateCode' => 'stateCode',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->openId) {
            $res['openId'] = $this->openId;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['openId'])) {
            $model->openId = $map['openId'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
