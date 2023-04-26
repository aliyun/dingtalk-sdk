<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterAccountsRequest extends Model
{
    /**
     * @example hexaaaa
     *
     * @var string
     */
    public $accessKey;

    /**
     * @example acc-1732245789
     *
     * @var string
     */
    public $activeCode;

    /**
     * @example ding123
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'accessKey'  => 'accessKey',
        'activeCode' => 'activeCode',
        'corpId'     => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->activeCode) {
            $res['activeCode'] = $this->activeCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
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
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['activeCode'])) {
            $model->activeCode = $map['activeCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
