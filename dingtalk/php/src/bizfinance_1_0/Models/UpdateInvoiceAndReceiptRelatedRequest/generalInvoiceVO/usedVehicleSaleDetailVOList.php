<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO;

use AlibabaCloud\Tea\Model;

class usedVehicleSaleDetailVOList extends Model
{
    /**
     * @var string
     */
    public $auctionUnit;

    /**
     * @var string
     */
    public $auctionUnitAddress;

    /**
     * @var string
     */
    public $auctionUnitBank;

    /**
     * @var string
     */
    public $auctionUnitTaxNo;

    /**
     * @var string
     */
    public $auctionUtilTel;

    /**
     * @var string
     */
    public $carModel;

    /**
     * @var string
     */
    public $cardNo;

    /**
     * @var string
     */
    public $registration;

    /**
     * @var string
     */
    public $transferVehicle;

    /**
     * @var string
     */
    public $usedCarAddress;

    /**
     * @var string
     */
    public $usedCarMarket;

    /**
     * @var string
     */
    public $usedCarMarketBank;

    /**
     * @var string
     */
    public $usedCarMarketPhone;

    /**
     * @var string
     */
    public $usedCarMarketTaxNo;

    /**
     * @var string
     */
    public $vehicleNo;

    /**
     * @var string
     */
    public $vehicleType;
    protected $_name = [
        'auctionUnit'        => 'auctionUnit',
        'auctionUnitAddress' => 'auctionUnitAddress',
        'auctionUnitBank'    => 'auctionUnitBank',
        'auctionUnitTaxNo'   => 'auctionUnitTaxNo',
        'auctionUtilTel'     => 'auctionUtilTel',
        'carModel'           => 'carModel',
        'cardNo'             => 'cardNo',
        'registration'       => 'registration',
        'transferVehicle'    => 'transferVehicle',
        'usedCarAddress'     => 'usedCarAddress',
        'usedCarMarket'      => 'usedCarMarket',
        'usedCarMarketBank'  => 'usedCarMarketBank',
        'usedCarMarketPhone' => 'usedCarMarketPhone',
        'usedCarMarketTaxNo' => 'usedCarMarketTaxNo',
        'vehicleNo'          => 'vehicleNo',
        'vehicleType'        => 'vehicleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->auctionUnit) {
            $res['auctionUnit'] = $this->auctionUnit;
        }
        if (null !== $this->auctionUnitAddress) {
            $res['auctionUnitAddress'] = $this->auctionUnitAddress;
        }
        if (null !== $this->auctionUnitBank) {
            $res['auctionUnitBank'] = $this->auctionUnitBank;
        }
        if (null !== $this->auctionUnitTaxNo) {
            $res['auctionUnitTaxNo'] = $this->auctionUnitTaxNo;
        }
        if (null !== $this->auctionUtilTel) {
            $res['auctionUtilTel'] = $this->auctionUtilTel;
        }
        if (null !== $this->carModel) {
            $res['carModel'] = $this->carModel;
        }
        if (null !== $this->cardNo) {
            $res['cardNo'] = $this->cardNo;
        }
        if (null !== $this->registration) {
            $res['registration'] = $this->registration;
        }
        if (null !== $this->transferVehicle) {
            $res['transferVehicle'] = $this->transferVehicle;
        }
        if (null !== $this->usedCarAddress) {
            $res['usedCarAddress'] = $this->usedCarAddress;
        }
        if (null !== $this->usedCarMarket) {
            $res['usedCarMarket'] = $this->usedCarMarket;
        }
        if (null !== $this->usedCarMarketBank) {
            $res['usedCarMarketBank'] = $this->usedCarMarketBank;
        }
        if (null !== $this->usedCarMarketPhone) {
            $res['usedCarMarketPhone'] = $this->usedCarMarketPhone;
        }
        if (null !== $this->usedCarMarketTaxNo) {
            $res['usedCarMarketTaxNo'] = $this->usedCarMarketTaxNo;
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
     * @return usedVehicleSaleDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auctionUnit'])) {
            $model->auctionUnit = $map['auctionUnit'];
        }
        if (isset($map['auctionUnitAddress'])) {
            $model->auctionUnitAddress = $map['auctionUnitAddress'];
        }
        if (isset($map['auctionUnitBank'])) {
            $model->auctionUnitBank = $map['auctionUnitBank'];
        }
        if (isset($map['auctionUnitTaxNo'])) {
            $model->auctionUnitTaxNo = $map['auctionUnitTaxNo'];
        }
        if (isset($map['auctionUtilTel'])) {
            $model->auctionUtilTel = $map['auctionUtilTel'];
        }
        if (isset($map['carModel'])) {
            $model->carModel = $map['carModel'];
        }
        if (isset($map['cardNo'])) {
            $model->cardNo = $map['cardNo'];
        }
        if (isset($map['registration'])) {
            $model->registration = $map['registration'];
        }
        if (isset($map['transferVehicle'])) {
            $model->transferVehicle = $map['transferVehicle'];
        }
        if (isset($map['usedCarAddress'])) {
            $model->usedCarAddress = $map['usedCarAddress'];
        }
        if (isset($map['usedCarMarket'])) {
            $model->usedCarMarket = $map['usedCarMarket'];
        }
        if (isset($map['usedCarMarketBank'])) {
            $model->usedCarMarketBank = $map['usedCarMarketBank'];
        }
        if (isset($map['usedCarMarketPhone'])) {
            $model->usedCarMarketPhone = $map['usedCarMarketPhone'];
        }
        if (isset($map['usedCarMarketTaxNo'])) {
            $model->usedCarMarketTaxNo = $map['usedCarMarketTaxNo'];
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
