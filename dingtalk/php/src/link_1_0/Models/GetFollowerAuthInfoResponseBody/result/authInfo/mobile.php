<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result\authInfo;

use AlibabaCloud\Tea\Model;

class mobile extends Model
{
    /**
     * @description 用户是否授权手机号码信息。
     * 当且仅当此值为true时返回手机号码信息。
     * @var bool
     */
    public $authorized;

    /**
     * @description 手机号码
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 地区码
     *
     * @var string
     */
    public $stateCode;
    protected $_name = [
        'authorized' => 'authorized',
        'mobile'     => 'mobile',
        'stateCode'  => 'stateCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorized) {
            $res['authorized'] = $this->authorized;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mobile
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorized'])) {
            $model->authorized = $map['authorized'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }

        return $model;
    }
}
