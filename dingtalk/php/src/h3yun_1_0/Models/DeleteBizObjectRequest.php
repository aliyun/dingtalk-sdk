<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteBizObjectRequest extends Model
{
    /**
     * @description 表单编码
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @description 业务数据id
     *
     * @var string
     */
    public $bizObjectId;
    protected $_name = [
        'schemaCode'  => 'schemaCode',
        'bizObjectId' => 'bizObjectId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }

        return $model;
    }
}
