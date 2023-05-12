<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class AppLoginCodeGenResponseBody extends Model
{
    /**
     * @var string
     */
    public $loginCode;
    protected $_name = [
        'loginCode' => 'loginCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->loginCode) {
            $res['loginCode'] = $this->loginCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppLoginCodeGenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['loginCode'])) {
            $model->loginCode = $map['loginCode'];
        }

        return $model;
    }
}
