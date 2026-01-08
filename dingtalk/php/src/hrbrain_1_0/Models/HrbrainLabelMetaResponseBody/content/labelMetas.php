<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelMetaResponseBody\content;

use AlibabaCloud\Tea\Model;

class labelMetas extends Model
{
    /**
     * @var string
     */
    public $categoryCode;

    /**
     * @var string
     */
    public $categoryName;

    /**
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
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var int
     */
    public $gmtCreated;

    /**
     * @var int
     */
    public $gmtModified;

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
     * @var bool
     */
    public $required;

    /**
     * @var string
     */
    public $useStatus;
    protected $_name = [
        'categoryCode' => 'categoryCode',
        'categoryName' => 'categoryName',
        'code' => 'code',
        'dataType' => 'dataType',
        'description' => 'description',
        'extendInfo' => 'extendInfo',
        'gmtCreated' => 'gmtCreated',
        'gmtModified' => 'gmtModified',
        'importantLevel' => 'importantLevel',
        'isSensitive' => 'isSensitive',
        'name' => 'name',
        'options' => 'options',
        'required' => 'required',
        'useStatus' => 'useStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
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
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->gmtCreated) {
            $res['gmtCreated'] = $this->gmtCreated;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->useStatus) {
            $res['useStatus'] = $this->useStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labelMetas
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
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
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['gmtCreated'])) {
            $model->gmtCreated = $map['gmtCreated'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
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
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['useStatus'])) {
            $model->useStatus = $map['useStatus'];
        }

        return $model;
    }
}
