<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCoolAppAccessStatusRequest extends Model
{
    /**
     * @description 免登授权码
     *
     * @var string
     */
    public $authCode;

    /**
     * @description 酷应用的code
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 加密的场域业务code
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
