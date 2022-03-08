<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostResponseBody;

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
    public $ext;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $labourCostName;

    /**
     * @var string
     */
    public $labourCostNo;

    /**
     * @var string
     */
    public $materialName;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $processName;

    /**
     * @var string
     */
    public $processNo;

    /**
     * @var float
     */
    public $qualifiedPrice;

    /**
     * @var string
     */
    public $unQualifiedInfo;

    /**
     * @var float
     */
    public $unQualifiedPrice1;

    /**
     * @var float
     */
    public $unQualifiedPrice2;

    /**
     * @var string
     */
    public $unQualifiedReason1;

    /**
     * @var string
     */
    public $unQualifiedReason2;
    protected $_name = [
        'corpId'             => 'corpId',
        'ext'                => 'ext',
        'gmtCreate'          => 'gmtCreate',
        'gmtModified'        => 'gmtModified',
        'instanceId'         => 'instanceId',
        'labourCostName'     => 'labourCostName',
        'labourCostNo'       => 'labourCostNo',
        'materialName'       => 'materialName',
        'materialNo'         => 'materialNo',
        'processCode'        => 'processCode',
        'processName'        => 'processName',
        'processNo'          => 'processNo',
        'qualifiedPrice'     => 'qualifiedPrice',
        'unQualifiedInfo'    => 'unQualifiedInfo',
        'unQualifiedPrice1'  => 'unQualifiedPrice1',
        'unQualifiedPrice2'  => 'unQualifiedPrice2',
        'unQualifiedReason1' => 'unQualifiedReason1',
        'unQualifiedReason2' => 'unQualifiedReason2',
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
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->labourCostName) {
            $res['labourCostName'] = $this->labourCostName;
        }
        if (null !== $this->labourCostNo) {
            $res['labourCostNo'] = $this->labourCostNo;
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
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->processNo) {
            $res['processNo'] = $this->processNo;
        }
        if (null !== $this->qualifiedPrice) {
            $res['qualifiedPrice'] = $this->qualifiedPrice;
        }
        if (null !== $this->unQualifiedInfo) {
            $res['unQualifiedInfo'] = $this->unQualifiedInfo;
        }
        if (null !== $this->unQualifiedPrice1) {
            $res['unQualifiedPrice1'] = $this->unQualifiedPrice1;
        }
        if (null !== $this->unQualifiedPrice2) {
            $res['unQualifiedPrice2'] = $this->unQualifiedPrice2;
        }
        if (null !== $this->unQualifiedReason1) {
            $res['unQualifiedReason1'] = $this->unQualifiedReason1;
        }
        if (null !== $this->unQualifiedReason2) {
            $res['unQualifiedReason2'] = $this->unQualifiedReason2;
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
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['labourCostName'])) {
            $model->labourCostName = $map['labourCostName'];
        }
        if (isset($map['labourCostNo'])) {
            $model->labourCostNo = $map['labourCostNo'];
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
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['processNo'])) {
            $model->processNo = $map['processNo'];
        }
        if (isset($map['qualifiedPrice'])) {
            $model->qualifiedPrice = $map['qualifiedPrice'];
        }
        if (isset($map['unQualifiedInfo'])) {
            $model->unQualifiedInfo = $map['unQualifiedInfo'];
        }
        if (isset($map['unQualifiedPrice1'])) {
            $model->unQualifiedPrice1 = $map['unQualifiedPrice1'];
        }
        if (isset($map['unQualifiedPrice2'])) {
            $model->unQualifiedPrice2 = $map['unQualifiedPrice2'];
        }
        if (isset($map['unQualifiedReason1'])) {
            $model->unQualifiedReason1 = $map['unQualifiedReason1'];
        }
        if (isset($map['unQualifiedReason2'])) {
            $model->unQualifiedReason2 = $map['unQualifiedReason2'];
        }

        return $model;
    }
}
