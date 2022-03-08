<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckClosingAccountResponseBody extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $mesage;

    /**
     * @var bool
     */
    public $pass;
    protected $_name = [
        'code'   => 'code',
        'mesage' => 'mesage',
        'pass'   => 'pass',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->mesage) {
            $res['mesage'] = $this->mesage;
        }
        if (null !== $this->pass) {
            $res['pass'] = $this->pass;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckClosingAccountResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['mesage'])) {
            $model->mesage = $map['mesage'];
        }
        if (isset($map['pass'])) {
            $model->pass = $map['pass'];
        }

        return $model;
    }
}
