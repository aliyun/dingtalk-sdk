<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateClueTempRequest extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contactName;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $phoneNum;

    /**
     * @var string
     */
    public $position;

    /**
     * @var string
     */
    public $productCode;

    /**
     * @var int
     */
    public $salesId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $source;
    protected $_name = [
        'address'     => 'address',
        'contactName' => 'contactName',
        'deptId'      => 'deptId',
        'ext'         => 'ext',
        'name'        => 'name',
        'phoneNum'    => 'phoneNum',
        'position'    => 'position',
        'productCode' => 'productCode',
        'salesId'     => 'salesId',
        'source'      => 'source',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->contactName) {
            $res['contactName'] = $this->contactName;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->phoneNum) {
            $res['phoneNum'] = $this->phoneNum;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->salesId) {
            $res['salesId'] = $this->salesId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateClueTempRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['contactName'])) {
            $model->contactName = $map['contactName'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['phoneNum'])) {
            $model->phoneNum = $map['phoneNum'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['salesId'])) {
            $model->salesId = $map['salesId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
