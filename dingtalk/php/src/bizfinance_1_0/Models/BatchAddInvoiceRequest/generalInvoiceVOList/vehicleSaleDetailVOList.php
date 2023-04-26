<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList;

use AlibabaCloud\Tea\Model;

class vehicleSaleDetailVOList extends Model
{
    /**
     * @var string
     */
    public $brand;

    /**
     * @var string
     */
    public $certificateNo;

    /**
     * @var string
     */
    public $engineNo;

    /**
     * @var string
     */
    public $idCardNo;

    /**
     * @var string
     */
    public $importCertificateNo;

    /**
     * @var string
     */
    public $inspectionListNo;

    /**
     * @var string
     */
    public $maxPassengers;

    /**
     * @var string
     */
    public $originPlace;

    /**
     * @var string
     */
    public $paymentVoucherNo;

    /**
     * @var string
     */
    public $taxAuthorityName;

    /**
     * @var string
     */
    public $taxAuthorityNo;

    /**
     * @var string
     */
    public $taxRate;

    /**
     * @var string
     */
    public $tonnage;

    /**
     * @var string
     */
    public $vehicleNo;

    /**
     * @var string
     */
    public $vehicleType;
    protected $_name = [
        'brand'               => 'brand',
        'certificateNo'       => 'certificateNo',
        'engineNo'            => 'engineNo',
        'idCardNo'            => 'idCardNo',
        'importCertificateNo' => 'importCertificateNo',
        'inspectionListNo'    => 'inspectionListNo',
        'maxPassengers'       => 'maxPassengers',
        'originPlace'         => 'originPlace',
        'paymentVoucherNo'    => 'paymentVoucherNo',
        'taxAuthorityName'    => 'taxAuthorityName',
        'taxAuthorityNo'      => 'taxAuthorityNo',
        'taxRate'             => 'taxRate',
        'tonnage'             => 'tonnage',
        'vehicleNo'           => 'vehicleNo',
        'vehicleType'         => 'vehicleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->brand) {
            $res['brand'] = $this->brand;
        }
        if (null !== $this->certificateNo) {
            $res['certificateNo'] = $this->certificateNo;
        }
        if (null !== $this->engineNo) {
            $res['engineNo'] = $this->engineNo;
        }
        if (null !== $this->idCardNo) {
            $res['idCardNo'] = $this->idCardNo;
        }
        if (null !== $this->importCertificateNo) {
            $res['importCertificateNo'] = $this->importCertificateNo;
        }
        if (null !== $this->inspectionListNo) {
            $res['inspectionListNo'] = $this->inspectionListNo;
        }
        if (null !== $this->maxPassengers) {
            $res['maxPassengers'] = $this->maxPassengers;
        }
        if (null !== $this->originPlace) {
            $res['originPlace'] = $this->originPlace;
        }
        if (null !== $this->paymentVoucherNo) {
            $res['paymentVoucherNo'] = $this->paymentVoucherNo;
        }
        if (null !== $this->taxAuthorityName) {
            $res['taxAuthorityName'] = $this->taxAuthorityName;
        }
        if (null !== $this->taxAuthorityNo) {
            $res['taxAuthorityNo'] = $this->taxAuthorityNo;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->tonnage) {
            $res['tonnage'] = $this->tonnage;
        }
        if (null !== $this->vehicleNo) {
            $res['vehicleNo'] = $this->vehicleNo;
        }
        if (null !== $this->vehicleType) {
            $res['vehicleType'] = $this->vehicleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return vehicleSaleDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['brand'])) {
            $model->brand = $map['brand'];
        }
        if (isset($map['certificateNo'])) {
            $model->certificateNo = $map['certificateNo'];
        }
        if (isset($map['engineNo'])) {
            $model->engineNo = $map['engineNo'];
        }
        if (isset($map['idCardNo'])) {
            $model->idCardNo = $map['idCardNo'];
        }
        if (isset($map['importCertificateNo'])) {
            $model->importCertificateNo = $map['importCertificateNo'];
        }
        if (isset($map['inspectionListNo'])) {
            $model->inspectionListNo = $map['inspectionListNo'];
        }
        if (isset($map['maxPassengers'])) {
            $model->maxPassengers = $map['maxPassengers'];
        }
        if (isset($map['originPlace'])) {
            $model->originPlace = $map['originPlace'];
        }
        if (isset($map['paymentVoucherNo'])) {
            $model->paymentVoucherNo = $map['paymentVoucherNo'];
        }
        if (isset($map['taxAuthorityName'])) {
            $model->taxAuthorityName = $map['taxAuthorityName'];
        }
        if (isset($map['taxAuthorityNo'])) {
            $model->taxAuthorityNo = $map['taxAuthorityNo'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['tonnage'])) {
            $model->tonnage = $map['tonnage'];
        }
        if (isset($map['vehicleNo'])) {
            $model->vehicleNo = $map['vehicleNo'];
        }
        if (isset($map['vehicleType'])) {
            $model->vehicleType = $map['vehicleType'];
        }

        return $model;
    }
}
