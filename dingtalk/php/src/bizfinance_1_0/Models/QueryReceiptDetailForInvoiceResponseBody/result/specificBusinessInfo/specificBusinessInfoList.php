<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result\specificBusinessInfo;

use AlibabaCloud\Tea\Model;

class specificBusinessInfoList extends Model
{
    /**
     * @var string
     */
    public $areaUnit;

    /**
     * @var string
     */
    public $carNo;

    /**
     * @var string
     */
    public $city;

    /**
     * @var string
     */
    public $crossCityFlg;

    /**
     * @var string
     */
    public $district;

    /**
     * @var int
     */
    public $leaseEnd;

    /**
     * @var int
     */
    public $leaseStart;

    /**
     * @var string
     */
    public $project;

    /**
     * @var string
     */
    public $projectNo;

    /**
     * @var string
     */
    public $propertyCertificateNumber;

    /**
     * @var string
     */
    public $province;

    /**
     * @var string
     */
    public $realEstateDetailedAddress;

    /**
     * @var string
     */
    public $spanRegionManageNo;
    protected $_name = [
        'areaUnit' => 'areaUnit',
        'carNo' => 'carNo',
        'city' => 'city',
        'crossCityFlg' => 'crossCityFlg',
        'district' => 'district',
        'leaseEnd' => 'leaseEnd',
        'leaseStart' => 'leaseStart',
        'project' => 'project',
        'projectNo' => 'projectNo',
        'propertyCertificateNumber' => 'propertyCertificateNumber',
        'province' => 'province',
        'realEstateDetailedAddress' => 'realEstateDetailedAddress',
        'spanRegionManageNo' => 'spanRegionManageNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->areaUnit) {
            $res['areaUnit'] = $this->areaUnit;
        }
        if (null !== $this->carNo) {
            $res['carNo'] = $this->carNo;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->crossCityFlg) {
            $res['crossCityFlg'] = $this->crossCityFlg;
        }
        if (null !== $this->district) {
            $res['district'] = $this->district;
        }
        if (null !== $this->leaseEnd) {
            $res['leaseEnd'] = $this->leaseEnd;
        }
        if (null !== $this->leaseStart) {
            $res['leaseStart'] = $this->leaseStart;
        }
        if (null !== $this->project) {
            $res['project'] = $this->project;
        }
        if (null !== $this->projectNo) {
            $res['projectNo'] = $this->projectNo;
        }
        if (null !== $this->propertyCertificateNumber) {
            $res['propertyCertificateNumber'] = $this->propertyCertificateNumber;
        }
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }
        if (null !== $this->realEstateDetailedAddress) {
            $res['realEstateDetailedAddress'] = $this->realEstateDetailedAddress;
        }
        if (null !== $this->spanRegionManageNo) {
            $res['spanRegionManageNo'] = $this->spanRegionManageNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return specificBusinessInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['areaUnit'])) {
            $model->areaUnit = $map['areaUnit'];
        }
        if (isset($map['carNo'])) {
            $model->carNo = $map['carNo'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['crossCityFlg'])) {
            $model->crossCityFlg = $map['crossCityFlg'];
        }
        if (isset($map['district'])) {
            $model->district = $map['district'];
        }
        if (isset($map['leaseEnd'])) {
            $model->leaseEnd = $map['leaseEnd'];
        }
        if (isset($map['leaseStart'])) {
            $model->leaseStart = $map['leaseStart'];
        }
        if (isset($map['project'])) {
            $model->project = $map['project'];
        }
        if (isset($map['projectNo'])) {
            $model->projectNo = $map['projectNo'];
        }
        if (isset($map['propertyCertificateNumber'])) {
            $model->propertyCertificateNumber = $map['propertyCertificateNumber'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }
        if (isset($map['realEstateDetailedAddress'])) {
            $model->realEstateDetailedAddress = $map['realEstateDetailedAddress'];
        }
        if (isset($map['spanRegionManageNo'])) {
            $model->spanRegionManageNo = $map['spanRegionManageNo'];
        }

        return $model;
    }
}
