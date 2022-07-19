<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo;

use AlibabaCloud\Tea\Model;

class inputMappingConfig extends Model
{
    /**
     * @var string
     */
    public $customSchemaMapping;

    /**
     * @var string
     */
    public $rules;
    protected $_name = [
        'customSchemaMapping' => 'customSchemaMapping',
        'rules'               => 'rules',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customSchemaMapping) {
            $res['customSchemaMapping'] = $this->customSchemaMapping;
        }
        if (null !== $this->rules) {
            $res['rules'] = $this->rules;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return inputMappingConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customSchemaMapping'])) {
            $model->customSchemaMapping = $map['customSchemaMapping'];
        }
        if (isset($map['rules'])) {
            $model->rules = $map['rules'];
        }

        return $model;
    }
}
