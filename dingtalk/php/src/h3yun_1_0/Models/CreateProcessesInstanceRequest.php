<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateProcessesInstanceRequest extends Model
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

    /**
     * @description 操作用户id。此为氚云的用户id，可从"获取用户数据API"获取
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'schemaCode'  => 'schemaCode',
        'bizObjectId' => 'bizObjectId',
        'opUserId'    => 'opUserId',
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
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateProcessesInstanceRequest
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
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
