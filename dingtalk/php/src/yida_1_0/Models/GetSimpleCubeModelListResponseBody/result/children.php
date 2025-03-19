<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListResponseBody\result;

use AlibabaCloud\Tea\Model;

class children extends Model
{
    /**
     * @var string
     */
    public $classifiedCode;

    /**
     * @var string
     */
    public $cubeCode;

    /**
     * @var string
     */
    public $dataType;

    /**
     * @var string
     */
    public $dimensionType;

    /**
     * @var string
     */
    public $fieldCode;

    /**
     * @example 12345
     *
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $isDimension;

    /**
     * @var string
     */
    public $isVisible;

    /**
     * @var string
     */
    public $measureType;

    /**
     * @var string
     */
    public $text;

    /**
     * @var string
     */
    public $timeFormat;

    /**
     * @var string
     */
    public $timeGranularityType;
    protected $_name = [
        'classifiedCode' => 'classifiedCode',
        'cubeCode' => 'cubeCode',
        'dataType' => 'dataType',
        'dimensionType' => 'dimensionType',
        'fieldCode' => 'fieldCode',
        'id' => 'id',
        'isDimension' => 'isDimension',
        'isVisible' => 'isVisible',
        'measureType' => 'measureType',
        'text' => 'text',
        'timeFormat' => 'timeFormat',
        'timeGranularityType' => 'timeGranularityType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classifiedCode) {
            $res['classifiedCode'] = $this->classifiedCode;
        }
        if (null !== $this->cubeCode) {
            $res['cubeCode'] = $this->cubeCode;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->dimensionType) {
            $res['dimensionType'] = $this->dimensionType;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDimension) {
            $res['isDimension'] = $this->isDimension;
        }
        if (null !== $this->isVisible) {
            $res['isVisible'] = $this->isVisible;
        }
        if (null !== $this->measureType) {
            $res['measureType'] = $this->measureType;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->timeFormat) {
            $res['timeFormat'] = $this->timeFormat;
        }
        if (null !== $this->timeGranularityType) {
            $res['timeGranularityType'] = $this->timeGranularityType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return children
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classifiedCode'])) {
            $model->classifiedCode = $map['classifiedCode'];
        }
        if (isset($map['cubeCode'])) {
            $model->cubeCode = $map['cubeCode'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['dimensionType'])) {
            $model->dimensionType = $map['dimensionType'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDimension'])) {
            $model->isDimension = $map['isDimension'];
        }
        if (isset($map['isVisible'])) {
            $model->isVisible = $map['isVisible'];
        }
        if (isset($map['measureType'])) {
            $model->measureType = $map['measureType'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['timeFormat'])) {
            $model->timeFormat = $map['timeFormat'];
        }
        if (isset($map['timeGranularityType'])) {
            $model->timeGranularityType = $map['timeGranularityType'];
        }

        return $model;
    }
}
