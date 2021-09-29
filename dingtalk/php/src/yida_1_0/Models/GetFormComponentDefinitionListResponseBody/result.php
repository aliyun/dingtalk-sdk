<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormComponentDefinitionListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description label
     *
     * @var string
     */
    public $label;

    /**
     * @description componentName
     *
     * @var string
     */
    public $componentName;

    /**
     * @description key
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description parentId
     *
     * @var string
     */
    public $parentId;
    protected $_name = [
        'label'         => 'label',
        'componentName' => 'componentName',
        'fieldId'       => 'fieldId',
        'parentId'      => 'parentId',
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
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
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
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }

        return $model;
    }
}
