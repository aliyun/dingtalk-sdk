<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class LoginForVisitorRequest extends Model
{
    /**
     * @example uuid_a123
     *
     * @var string
     */
    public $appUserId;

    /**
     * @example your_channel_code
     *
     * @var string
     */
    public $channelCode;

    /**
     * @example abc123xyz
     *
     * @var string
     */
    public $customAccessToken;
    protected $_name = [
        'appUserId' => 'appUserId',
        'channelCode' => 'channelCode',
        'customAccessToken' => 'customAccessToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->customAccessToken) {
            $res['customAccessToken'] = $this->customAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoginForVisitorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['customAccessToken'])) {
            $model->customAccessToken = $map['customAccessToken'];
        }

        return $model;
    }
}
