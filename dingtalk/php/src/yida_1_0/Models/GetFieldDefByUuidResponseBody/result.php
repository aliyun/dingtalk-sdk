<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFieldDefByUuidResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $behavior;

    /**
     * @var string
     */
    public $children;

    /**
     * @var string
     */
    public $componentName;

    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var mixed
     */
    public $label;

    /**
     * @var mixed
     */
    public $props;
    protected $_name = [
        'behavior'      => 'behavior',
        'children'      => 'children',
        'componentName' => 'componentName',
        'fieldId'       => 'fieldId',
        'label'         => 'label',
        'props'         => 'props',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->behavior) {
            $res['behavior'] = $this->behavior;
        }
        if (null !== $this->children) {
            $res['children'] = $this->children;
        }
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->props) {
            $res['props'] = $this->props;
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
        if (isset($map['behavior'])) {
            $model->behavior = $map['behavior'];
        }
        if (isset($map['children'])) {
            $model->children = $map['children'];
        }
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['props'])) {
            $model->props = $map['props'];
        }

        return $model;
    }
}
