<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\childForms;

use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @description 显示名称
     *
     * @var string
     */
    public $label;

    /**
     * @description 字段名或组件名
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 字段数据类型
     *
     * @var string
     */
    public $bizDataType;
    protected $_name = [
        'label'       => 'label',
        'fieldName'   => 'fieldName',
        'bizDataType' => 'bizDataType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->bizDataType) {
            $res['bizDataType'] = $this->bizDataType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['bizDataType'])) {
            $model->bizDataType = $map['bizDataType'];
        }

        return $model;
    }
}
