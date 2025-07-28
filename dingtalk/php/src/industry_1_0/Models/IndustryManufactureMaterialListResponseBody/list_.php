<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $category;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $materialName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $materialNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $processCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $specification;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $stockMaxWarn;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $stockMinWarn;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'category' => 'category',
        'corpId' => 'corpId',
        'ext' => 'ext',
        'instanceId' => 'instanceId',
        'materialName' => 'materialName',
        'materialNo' => 'materialNo',
        'processCode' => 'processCode',
        'specification' => 'specification',
        'stockMaxWarn' => 'stockMaxWarn',
        'stockMinWarn' => 'stockMinWarn',
        'type' => 'type',
        'unit' => 'unit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
        }
        if (null !== $this->stockMaxWarn) {
            $res['stockMaxWarn'] = $this->stockMaxWarn;
        }
        if (null !== $this->stockMinWarn) {
            $res['stockMinWarn'] = $this->stockMinWarn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
        }
        if (isset($map['stockMaxWarn'])) {
            $model->stockMaxWarn = $map['stockMaxWarn'];
        }
        if (isset($map['stockMinWarn'])) {
            $model->stockMinWarn = $map['stockMinWarn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
