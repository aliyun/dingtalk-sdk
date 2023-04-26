<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCoolAppAccessStatusRequest extends Model
{
    /**
     * @example b195bb70dde337aabf3bcc020bf6250c
     *
     * @var string
     */
    public $authCode;

    /**
     * @example COOLAPP-1-1019F4BBC7D6212C5861000T
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @example cid5uZRmigtVWpjcKPLrp5Pag==
     *
     * @var string
     */
    public $encFieldBizCode;
    protected $_name = [
        'authCode'        => 'authCode',
        'coolAppCode'     => 'coolAppCode',
        'encFieldBizCode' => 'encFieldBizCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->encFieldBizCode) {
            $res['encFieldBizCode'] = $this->encFieldBizCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCoolAppAccessStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['encFieldBizCode'])) {
            $model->encFieldBizCode = $map['encFieldBizCode'];
        }

        return $model;
    }
}
