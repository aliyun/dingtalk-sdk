<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUserCodeInstanceResponseBody extends Model
{
    /**
     * @description 码ID
     *
     * @var string
     */
    public $codeId;
    protected $_name = [
        'codeId' => 'codeId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUserCodeInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }

        return $model;
    }
}
