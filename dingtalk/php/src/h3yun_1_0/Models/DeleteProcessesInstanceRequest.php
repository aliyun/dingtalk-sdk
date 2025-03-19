<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteProcessesInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $isAutoUpdateBizObject;

    /**
     * @description This parameter is required.
     *
     * @example 3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'isAutoUpdateBizObject' => 'isAutoUpdateBizObject',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isAutoUpdateBizObject) {
            $res['isAutoUpdateBizObject'] = $this->isAutoUpdateBizObject;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteProcessesInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isAutoUpdateBizObject'])) {
            $model->isAutoUpdateBizObject = $map['isAutoUpdateBizObject'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
