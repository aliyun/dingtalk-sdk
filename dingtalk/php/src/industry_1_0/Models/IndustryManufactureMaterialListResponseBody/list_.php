<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var string
     */
    public $materialName;

    /**
     * @var string
     */
    public $specification;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $category;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var string
     */
    public $ext;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var float
     */
    public $stockMaxWarn;

    /**
     * @var float
     */
    public $stockMinWarn;
    protected $_name = [
        'corpId'        => 'corpId',
        'instanceId'    => 'instanceId',
        'materialNo'    => 'materialNo',
        'materialName'  => 'materialName',
        'specification' => 'specification',
        'type'          => 'type',
        'category'      => 'category',
        'unit'          => 'unit',
        'ext'           => 'ext',
        'processCode'   => 'processCode',
        'stockMaxWarn'  => 'stockMaxWarn',
        'stockMinWarn'  => 'stockMinWarn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->stockMaxWarn) {
            $res['stockMaxWarn'] = $this->stockMaxWarn;
        }
        if (null !== $this->stockMinWarn) {
            $res['stockMinWarn'] = $this->stockMinWarn;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['stockMaxWarn'])) {
            $model->stockMaxWarn = $map['stockMaxWarn'];
        }
        if (isset($map['stockMinWarn'])) {
            $model->stockMinWarn = $map['stockMinWarn'];
        }

        return $model;
    }
}
