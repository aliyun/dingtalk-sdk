<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryResponseBody\result;

use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @example 该字段为id主键
     *
     * @var string
     */
    public $description;

    /**
     * @example id
     *
     * @var string
     */
    public $fieldKey;

    /**
     * @example id主键
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example varchar
     *
     * @var string
     */
    public $fieldType;

    /**
     * @var bool
     */
    public $primaryKey;

    /**
     * @var bool
     */
    public $required;
    protected $_name = [
        'description' => 'description',
        'fieldKey'    => 'fieldKey',
        'fieldName'   => 'fieldName',
        'fieldType'   => 'fieldType',
        'primaryKey'  => 'primaryKey',
        'required'    => 'required',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->primaryKey) {
            $res['primaryKey'] = $this->primaryKey;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['primaryKey'])) {
            $model->primaryKey = $map['primaryKey'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }

        return $model;
    }
}
