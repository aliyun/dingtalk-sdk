<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFieldModifiedHistoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example TextField-abcd
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description This parameter is required.
     *
     * @example proc-FF6Y2xxxx
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'fieldId' => 'fieldId',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFieldModifiedHistoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
