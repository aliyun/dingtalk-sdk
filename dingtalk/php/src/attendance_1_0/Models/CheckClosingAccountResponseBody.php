<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckClosingAccountResponseBody extends Model
{
    /**
     * @var string
     */
    public $mesage;

    /**
     * @var int
     */
    public $code;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'mesage'  => 'mesage',
        'code'    => 'code',
        'success' => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mesage) {
            $res['mesage'] = $this->mesage;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
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
        if (isset($map['mesage'])) {
            $model->mesage = $map['mesage'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
