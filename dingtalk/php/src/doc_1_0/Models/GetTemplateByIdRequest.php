<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTemplateByIdRequest extends Model
{
    /**
     * @description 模版归属
     * user_template //个人模板
     * @var string
     */
    public $belong;

    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'belong'     => 'belong',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->belong) {
            $res['belong'] = $this->belong;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTemplateByIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['belong'])) {
            $model->belong = $map['belong'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
