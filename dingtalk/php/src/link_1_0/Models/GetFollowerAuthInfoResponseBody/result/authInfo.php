<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result\authInfo\mainCorp;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result\authInfo\mobile;
use AlibabaCloud\Tea\Model;

class authInfo extends Model
{
    /**
     * @description 用户主组织信息
     * 需要用户授权给应用后返回此信息。
     * @var mainCorp
     */
    public $mainCorp;

    /**
     * @description 手机号码授权详情。
     * 需要用户授权给应用后返回此信息。
     * @var mobile
     */
    public $mobile;
    protected $_name = [
        'mainCorp' => 'mainCorp',
        'mobile'   => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mainCorp) {
            $res['mainCorp'] = null !== $this->mainCorp ? $this->mainCorp->toMap() : null;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = null !== $this->mobile ? $this->mobile->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return authInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mainCorp'])) {
            $model->mainCorp = mainCorp::fromMap($map['mainCorp']);
        }
        if (isset($map['mobile'])) {
            $model->mobile = mobile::fromMap($map['mobile']);
        }

        return $model;
    }
}
