<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\childForms;

use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @example ShortString
     *
     * @var string
     */
    public $bizDataType;

    /**
     * @example Phone
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example 电话
     *
     * @var string
     */
    public $label;
    protected $_name = [
        'bizDataType' => 'bizDataType',
        'fieldName'   => 'fieldName',
        'label'       => 'label',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizDataType) {
            $res['bizDataType'] = $this->bizDataType;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
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
        if (isset($map['bizDataType'])) {
            $model->bizDataType = $map['bizDataType'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }

        return $model;
    }
}
