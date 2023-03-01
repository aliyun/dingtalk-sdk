<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UnbindCoolAppToSheetRequest extends Model
{
    /**
     * @description 酷应用编码
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'coolAppCode' => 'coolAppCode',
        'operatorId'  => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UnbindCoolAppToSheetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
