<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelMetaUpdateRequest extends Model
{
    /**
     * @var string
     */
    public $categoryCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $dataType;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $importantLevel;

    /**
     * @var bool
     */
    public $isSensitive;

    /**
     * @var string
     */
    public $name;

    /**
     * @var mixed[][]
     */
    public $options;

    /**
     * @var mixed[]
     */
    public $permission;

    /**
     * @var bool
     */
    public $required;
    protected $_name = [
        'categoryCode' => 'categoryCode',
        'code' => 'code',
        'dataType' => 'dataType',
        'description' => 'description',
        'importantLevel' => 'importantLevel',
        'isSensitive' => 'isSensitive',
        'name' => 'name',
        'options' => 'options',
        'permission' => 'permission',
        'required' => 'required',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->importantLevel) {
            $res['importantLevel'] = $this->importantLevel;
        }
        if (null !== $this->isSensitive) {
            $res['isSensitive'] = $this->isSensitive;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->permission) {
            $res['permission'] = $this->permission;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelMetaUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['importantLevel'])) {
            $model->importantLevel = $map['importantLevel'];
        }
        if (isset($map['isSensitive'])) {
            $model->isSensitive = $map['isSensitive'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = $map['options'];
            }
        }
        if (isset($map['permission'])) {
            $model->permission = $map['permission'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }

        return $model;
    }
}
