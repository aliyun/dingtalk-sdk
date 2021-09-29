<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterAccountsRequest extends Model
{
    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 访问秘钥
     *
     * @var string
     */
    public $accessKey;

    /**
     * @description 激活码
     *
     * @var string
     */
    public $activeCode;
    protected $_name = [
        'corpId'     => 'corpId',
        'accessKey'  => 'accessKey',
        'activeCode' => 'activeCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->activeCode) {
            $res['activeCode'] = $this->activeCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterAccountsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['activeCode'])) {
            $model->activeCode = $map['activeCode'];
        }

        return $model;
    }
}
