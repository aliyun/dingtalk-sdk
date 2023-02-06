<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaAvailableFieldListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 字段标识
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description 字段名称
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 字段类型
     *
     * @var string
     */
    public $fieldType;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }

        return $model;
    }
}
