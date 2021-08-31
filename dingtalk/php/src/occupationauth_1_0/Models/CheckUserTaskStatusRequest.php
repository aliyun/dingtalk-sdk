<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckUserTaskStatusRequest extends Model
{
    /**
     * @var string
     */
    public $provinceCode;
    protected $_name = [
        'provinceCode' => 'provinceCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->provinceCode) {
            $res['provinceCode'] = $this->provinceCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckUserTaskStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['provinceCode'])) {
            $model->provinceCode = $map['provinceCode'];
        }

        return $model;
    }
}
