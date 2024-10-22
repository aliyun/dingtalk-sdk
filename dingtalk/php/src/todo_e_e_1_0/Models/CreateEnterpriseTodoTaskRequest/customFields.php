<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskRequest;

use AlibabaCloud\Tea\Model;

class customFields extends Model
{
    /**
     * @var string
     */
    public $fieldKey;

    /**
     * @var string
     */
    public $fieldLink;

    /**
     * @var string
     */
    public $fieldType;

    /**
     * @var string
     */
    public $fieldValue;

    /**
     * @var string
     */
    public $icon;
    protected $_name = [
        'fieldKey'   => 'fieldKey',
        'fieldLink'  => 'fieldLink',
        'fieldType'  => 'fieldType',
        'fieldValue' => 'fieldValue',
        'icon'       => 'icon',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
        }
        if (null !== $this->fieldLink) {
            $res['fieldLink'] = $this->fieldLink;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['fieldLink'])) {
            $model->fieldLink = $map['fieldLink'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }

        return $model;
    }
}
