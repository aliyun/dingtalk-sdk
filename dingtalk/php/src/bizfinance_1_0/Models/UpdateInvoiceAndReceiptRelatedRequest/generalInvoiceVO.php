<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO\flightItineraryDetails;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO\generalInvoiceDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO\secondHandCarInvoiceDetailList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO\usedVehicleSaleDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO\vehicleSaleDetailVOList;
use AlibabaCloud\Tea\Model;

class generalInvoiceVO extends Model
{
    /**
     * @var string
     */
    public $accountPeriod;

    /**
     * @example ABC
     *
     * @var string
     */
    public $agentCode;

    /**
     * @var string
     */
    public $amount;

    /**
     * @var string
     */
    public $amountWithTax;

    /**
     * @example 123
     *
     * @var string
     */
    public $caacDevelopmentFund;

    /**
     * @var string
     */
    public $checkCode;

    /**
     * @var string
     */
    public $checkTime;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $city;

    /**
     * @example 北京
     *
     * @var string
     */
    public $destination;

    /**
     * @example 123KM
     *
     * @var string
     */
    public $distance;

    /**
     * @example 张三
     *
     * @var string
     */
    public $drawerName;

    /**
     * @var string
     */
    public $drewDate;

    /**
     * @var string
     */
    public $electronicUrl;

    /**
     * @example 杭州北
     *
     * @var string
     */
    public $entrance;

    /**
     * @example 杭州北
     *
     * @var string
     */
    public $exit;

    /**
     * @var string
     */
    public $financeType;

    /**
     * @var flightItineraryDetails[]
     */
    public $flightItineraryDetails;

    /**
     * @example 123
     *
     * @var string
     */
    public $fuelSurcharge;

    /**
     * @var string
     */
    public $fundType;

    /**
     * @var generalInvoiceDetailVOList[]
     */
    public $generalInvoiceDetailVOList;

    /**
     * @example 18:00
     *
     * @var string
     */
    public $getOffTime;

    /**
     * @example 17:00
     *
     * @var string
     */
    public $getOnTime;

    /**
     * @example http://XXX.jpg
     *
     * @var string
     */
    public $imageUrl;

    /**
     * @var string
     */
    public $invoiceCode;

    /**
     * @var string
     */
    public $invoiceNo;

    /**
     * @var string
     */
    public $invoiceStatus;

    /**
     * @var string
     */
    public $invoiceType;

    /**
     * @example ABCD
     *
     * @var string
     */
    public $issueBy;

    /**
     * @var string
     */
    public $machineCode;

    /**
     * @var string
     */
    public $oilFlag;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $origin;

    /**
     * @example 张三
     *
     * @var string
     */
    public $passenger;

    /**
     * @example 330781****1234
     *
     * @var string
     */
    public $passengerUserId;

    /**
     * @var string
     */
    public $payee;

    /**
     * @example 123
     *
     * @var string
     */
    public $printSerialNumber;

    /**
     * @var string
     */
    public $processInstCode;

    /**
     * @var string
     */
    public $processInstType;

    /**
     * @var string
     */
    public $purchaserAddress;

    /**
     * @example abc
     *
     * @var string
     */
    public $purchaserBankAccount;

    /**
     * @example abc
     *
     * @var string
     */
    public $purchaserBankNameAccount;

    /**
     * @var string
     */
    public $purchaserName;

    /**
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @var string
     */
    public $purchaserTel;

    /**
     * @example abc@test.com
     *
     * @var string
     */
    public $receiverEmail;

    /**
     * @example 张三
     *
     * @var string
     */
    public $receiverName;

    /**
     * @example 1234567809
     *
     * @var string
     */
    public $receiverTel;

    /**
     * @var string
     */
    public $remark;

    /**
     * @example 2023-09-01
     *
     * @var string
     */
    public $seatClass;

    /**
     * @var secondHandCarInvoiceDetailList[]
     */
    public $secondHandCarInvoiceDetailList;

    /**
     * @var string
     */
    public $sellerAddress;

    /**
     * @example abc
     *
     * @var string
     */
    public $sellerBankAccount;

    /**
     * @example abc
     *
     * @var string
     */
    public $sellerBankNameAccount;

    /**
     * @var string
     */
    public $sellerName;

    /**
     * @var string
     */
    public $sellerTaxNo;

    /**
     * @var string
     */
    public $sellerTel;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $serialNo;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $startTime;

    /**
     * @var string
     */
    public $supplySign;

    /**
     * @example 123
     *
     * @var string
     */
    public $surcharge;

    /**
     * @var string
     */
    public $taxAmount;

    /**
     * @example G1234
     *
     * @var string
     */
    public $trainNo;

    /**
     * @example 2023-09-01
     *
     * @var string
     */
    public $travelDate;

    /**
     * @var usedVehicleSaleDetailVOList[]
     */
    public $usedVehicleSaleDetailVOList;

    /**
     * @var vehicleSaleDetailVOList[]
     */
    public $vehicleSaleDetailVOList;

    /**
     * @var string
     */
    public $verifyStatus;

    /**
     * @var string
     */
    public $voucherCode;

    /**
     * @var string
     */
    public $voucherStatus;
    protected $_name = [
        'accountPeriod'                  => 'accountPeriod',
        'agentCode'                      => 'agentCode',
        'amount'                         => 'amount',
        'amountWithTax'                  => 'amountWithTax',
        'caacDevelopmentFund'            => 'caacDevelopmentFund',
        'checkCode'                      => 'checkCode',
        'checkTime'                      => 'checkTime',
        'city'                           => 'city',
        'destination'                    => 'destination',
        'distance'                       => 'distance',
        'drawerName'                     => 'drawerName',
        'drewDate'                       => 'drewDate',
        'electronicUrl'                  => 'electronicUrl',
        'entrance'                       => 'entrance',
        'exit'                           => 'exit',
        'financeType'                    => 'financeType',
        'flightItineraryDetails'         => 'flightItineraryDetails',
        'fuelSurcharge'                  => 'fuelSurcharge',
        'fundType'                       => 'fundType',
        'generalInvoiceDetailVOList'     => 'generalInvoiceDetailVOList',
        'getOffTime'                     => 'getOffTime',
        'getOnTime'                      => 'getOnTime',
        'imageUrl'                       => 'imageUrl',
        'invoiceCode'                    => 'invoiceCode',
        'invoiceNo'                      => 'invoiceNo',
        'invoiceStatus'                  => 'invoiceStatus',
        'invoiceType'                    => 'invoiceType',
        'issueBy'                        => 'issueBy',
        'machineCode'                    => 'machineCode',
        'oilFlag'                        => 'oilFlag',
        'origin'                         => 'origin',
        'passenger'                      => 'passenger',
        'passengerUserId'                => 'passengerUserId',
        'payee'                          => 'payee',
        'printSerialNumber'              => 'printSerialNumber',
        'processInstCode'                => 'processInstCode',
        'processInstType'                => 'processInstType',
        'purchaserAddress'               => 'purchaserAddress',
        'purchaserBankAccount'           => 'purchaserBankAccount',
        'purchaserBankNameAccount'       => 'purchaserBankNameAccount',
        'purchaserName'                  => 'purchaserName',
        'purchaserTaxNo'                 => 'purchaserTaxNo',
        'purchaserTel'                   => 'purchaserTel',
        'receiverEmail'                  => 'receiverEmail',
        'receiverName'                   => 'receiverName',
        'receiverTel'                    => 'receiverTel',
        'remark'                         => 'remark',
        'seatClass'                      => 'seatClass',
        'secondHandCarInvoiceDetailList' => 'secondHandCarInvoiceDetailList',
        'sellerAddress'                  => 'sellerAddress',
        'sellerBankAccount'              => 'sellerBankAccount',
        'sellerBankNameAccount'          => 'sellerBankNameAccount',
        'sellerName'                     => 'sellerName',
        'sellerTaxNo'                    => 'sellerTaxNo',
        'sellerTel'                      => 'sellerTel',
        'serialNo'                       => 'serialNo',
        'startTime'                      => 'startTime',
        'supplySign'                     => 'supplySign',
        'surcharge'                      => 'surcharge',
        'taxAmount'                      => 'taxAmount',
        'trainNo'                        => 'trainNo',
        'travelDate'                     => 'travelDate',
        'usedVehicleSaleDetailVOList'    => 'usedVehicleSaleDetailVOList',
        'vehicleSaleDetailVOList'        => 'vehicleSaleDetailVOList',
        'verifyStatus'                   => 'verifyStatus',
        'voucherCode'                    => 'voucherCode',
        'voucherStatus'                  => 'voucherStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountPeriod) {
            $res['accountPeriod'] = $this->accountPeriod;
        }
        if (null !== $this->agentCode) {
            $res['agentCode'] = $this->agentCode;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->amountWithTax) {
            $res['amountWithTax'] = $this->amountWithTax;
        }
        if (null !== $this->caacDevelopmentFund) {
            $res['caacDevelopmentFund'] = $this->caacDevelopmentFund;
        }
        if (null !== $this->checkCode) {
            $res['checkCode'] = $this->checkCode;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->destination) {
            $res['destination'] = $this->destination;
        }
        if (null !== $this->distance) {
            $res['distance'] = $this->distance;
        }
        if (null !== $this->drawerName) {
            $res['drawerName'] = $this->drawerName;
        }
        if (null !== $this->drewDate) {
            $res['drewDate'] = $this->drewDate;
        }
        if (null !== $this->electronicUrl) {
            $res['electronicUrl'] = $this->electronicUrl;
        }
        if (null !== $this->entrance) {
            $res['entrance'] = $this->entrance;
        }
        if (null !== $this->exit) {
            $res['exit'] = $this->exit;
        }
        if (null !== $this->financeType) {
            $res['financeType'] = $this->financeType;
        }
        if (null !== $this->flightItineraryDetails) {
            $res['flightItineraryDetails'] = [];
            if (null !== $this->flightItineraryDetails && \is_array($this->flightItineraryDetails)) {
                $n = 0;
                foreach ($this->flightItineraryDetails as $item) {
                    $res['flightItineraryDetails'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->fuelSurcharge) {
            $res['fuelSurcharge'] = $this->fuelSurcharge;
        }
        if (null !== $this->fundType) {
            $res['fundType'] = $this->fundType;
        }
        if (null !== $this->generalInvoiceDetailVOList) {
            $res['generalInvoiceDetailVOList'] = [];
            if (null !== $this->generalInvoiceDetailVOList && \is_array($this->generalInvoiceDetailVOList)) {
                $n = 0;
                foreach ($this->generalInvoiceDetailVOList as $item) {
                    $res['generalInvoiceDetailVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->getOffTime) {
            $res['getOffTime'] = $this->getOffTime;
        }
        if (null !== $this->getOnTime) {
            $res['getOnTime'] = $this->getOnTime;
        }
        if (null !== $this->imageUrl) {
            $res['imageUrl'] = $this->imageUrl;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->invoiceStatus) {
            $res['invoiceStatus'] = $this->invoiceStatus;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->issueBy) {
            $res['issueBy'] = $this->issueBy;
        }
        if (null !== $this->machineCode) {
            $res['machineCode'] = $this->machineCode;
        }
        if (null !== $this->oilFlag) {
            $res['oilFlag'] = $this->oilFlag;
        }
        if (null !== $this->origin) {
            $res['origin'] = $this->origin;
        }
        if (null !== $this->passenger) {
            $res['passenger'] = $this->passenger;
        }
        if (null !== $this->passengerUserId) {
            $res['passengerUserId'] = $this->passengerUserId;
        }
        if (null !== $this->payee) {
            $res['payee'] = $this->payee;
        }
        if (null !== $this->printSerialNumber) {
            $res['printSerialNumber'] = $this->printSerialNumber;
        }
        if (null !== $this->processInstCode) {
            $res['processInstCode'] = $this->processInstCode;
        }
        if (null !== $this->processInstType) {
            $res['processInstType'] = $this->processInstType;
        }
        if (null !== $this->purchaserAddress) {
            $res['purchaserAddress'] = $this->purchaserAddress;
        }
        if (null !== $this->purchaserBankAccount) {
            $res['purchaserBankAccount'] = $this->purchaserBankAccount;
        }
        if (null !== $this->purchaserBankNameAccount) {
            $res['purchaserBankNameAccount'] = $this->purchaserBankNameAccount;
        }
        if (null !== $this->purchaserName) {
            $res['purchaserName'] = $this->purchaserName;
        }
        if (null !== $this->purchaserTaxNo) {
            $res['purchaserTaxNo'] = $this->purchaserTaxNo;
        }
        if (null !== $this->purchaserTel) {
            $res['purchaserTel'] = $this->purchaserTel;
        }
        if (null !== $this->receiverEmail) {
            $res['receiverEmail'] = $this->receiverEmail;
        }
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverTel) {
            $res['receiverTel'] = $this->receiverTel;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->seatClass) {
            $res['seatClass'] = $this->seatClass;
        }
        if (null !== $this->secondHandCarInvoiceDetailList) {
            $res['secondHandCarInvoiceDetailList'] = [];
            if (null !== $this->secondHandCarInvoiceDetailList && \is_array($this->secondHandCarInvoiceDetailList)) {
                $n = 0;
                foreach ($this->secondHandCarInvoiceDetailList as $item) {
                    $res['secondHandCarInvoiceDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sellerAddress) {
            $res['sellerAddress'] = $this->sellerAddress;
        }
        if (null !== $this->sellerBankAccount) {
            $res['sellerBankAccount'] = $this->sellerBankAccount;
        }
        if (null !== $this->sellerBankNameAccount) {
            $res['sellerBankNameAccount'] = $this->sellerBankNameAccount;
        }
        if (null !== $this->sellerName) {
            $res['sellerName'] = $this->sellerName;
        }
        if (null !== $this->sellerTaxNo) {
            $res['sellerTaxNo'] = $this->sellerTaxNo;
        }
        if (null !== $this->sellerTel) {
            $res['sellerTel'] = $this->sellerTel;
        }
        if (null !== $this->serialNo) {
            $res['serialNo'] = $this->serialNo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->supplySign) {
            $res['supplySign'] = $this->supplySign;
        }
        if (null !== $this->surcharge) {
            $res['surcharge'] = $this->surcharge;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
        }
        if (null !== $this->trainNo) {
            $res['trainNo'] = $this->trainNo;
        }
        if (null !== $this->travelDate) {
            $res['travelDate'] = $this->travelDate;
        }
        if (null !== $this->usedVehicleSaleDetailVOList) {
            $res['usedVehicleSaleDetailVOList'] = [];
            if (null !== $this->usedVehicleSaleDetailVOList && \is_array($this->usedVehicleSaleDetailVOList)) {
                $n = 0;
                foreach ($this->usedVehicleSaleDetailVOList as $item) {
                    $res['usedVehicleSaleDetailVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->vehicleSaleDetailVOList) {
            $res['vehicleSaleDetailVOList'] = [];
            if (null !== $this->vehicleSaleDetailVOList && \is_array($this->vehicleSaleDetailVOList)) {
                $n = 0;
                foreach ($this->vehicleSaleDetailVOList as $item) {
                    $res['vehicleSaleDetailVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->verifyStatus) {
            $res['verifyStatus'] = $this->verifyStatus;
        }
        if (null !== $this->voucherCode) {
            $res['voucherCode'] = $this->voucherCode;
        }
        if (null !== $this->voucherStatus) {
            $res['voucherStatus'] = $this->voucherStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return generalInvoiceVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountPeriod'])) {
            $model->accountPeriod = $map['accountPeriod'];
        }
        if (isset($map['agentCode'])) {
            $model->agentCode = $map['agentCode'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['amountWithTax'])) {
            $model->amountWithTax = $map['amountWithTax'];
        }
        if (isset($map['caacDevelopmentFund'])) {
            $model->caacDevelopmentFund = $map['caacDevelopmentFund'];
        }
        if (isset($map['checkCode'])) {
            $model->checkCode = $map['checkCode'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['destination'])) {
            $model->destination = $map['destination'];
        }
        if (isset($map['distance'])) {
            $model->distance = $map['distance'];
        }
        if (isset($map['drawerName'])) {
            $model->drawerName = $map['drawerName'];
        }
        if (isset($map['drewDate'])) {
            $model->drewDate = $map['drewDate'];
        }
        if (isset($map['electronicUrl'])) {
            $model->electronicUrl = $map['electronicUrl'];
        }
        if (isset($map['entrance'])) {
            $model->entrance = $map['entrance'];
        }
        if (isset($map['exit'])) {
            $model->exit = $map['exit'];
        }
        if (isset($map['financeType'])) {
            $model->financeType = $map['financeType'];
        }
        if (isset($map['flightItineraryDetails'])) {
            if (!empty($map['flightItineraryDetails'])) {
                $model->flightItineraryDetails = [];
                $n                             = 0;
                foreach ($map['flightItineraryDetails'] as $item) {
                    $model->flightItineraryDetails[$n++] = null !== $item ? flightItineraryDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['fuelSurcharge'])) {
            $model->fuelSurcharge = $map['fuelSurcharge'];
        }
        if (isset($map['fundType'])) {
            $model->fundType = $map['fundType'];
        }
        if (isset($map['generalInvoiceDetailVOList'])) {
            if (!empty($map['generalInvoiceDetailVOList'])) {
                $model->generalInvoiceDetailVOList = [];
                $n                                 = 0;
                foreach ($map['generalInvoiceDetailVOList'] as $item) {
                    $model->generalInvoiceDetailVOList[$n++] = null !== $item ? generalInvoiceDetailVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['getOffTime'])) {
            $model->getOffTime = $map['getOffTime'];
        }
        if (isset($map['getOnTime'])) {
            $model->getOnTime = $map['getOnTime'];
        }
        if (isset($map['imageUrl'])) {
            $model->imageUrl = $map['imageUrl'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['invoiceStatus'])) {
            $model->invoiceStatus = $map['invoiceStatus'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['issueBy'])) {
            $model->issueBy = $map['issueBy'];
        }
        if (isset($map['machineCode'])) {
            $model->machineCode = $map['machineCode'];
        }
        if (isset($map['oilFlag'])) {
            $model->oilFlag = $map['oilFlag'];
        }
        if (isset($map['origin'])) {
            $model->origin = $map['origin'];
        }
        if (isset($map['passenger'])) {
            $model->passenger = $map['passenger'];
        }
        if (isset($map['passengerUserId'])) {
            $model->passengerUserId = $map['passengerUserId'];
        }
        if (isset($map['payee'])) {
            $model->payee = $map['payee'];
        }
        if (isset($map['printSerialNumber'])) {
            $model->printSerialNumber = $map['printSerialNumber'];
        }
        if (isset($map['processInstCode'])) {
            $model->processInstCode = $map['processInstCode'];
        }
        if (isset($map['processInstType'])) {
            $model->processInstType = $map['processInstType'];
        }
        if (isset($map['purchaserAddress'])) {
            $model->purchaserAddress = $map['purchaserAddress'];
        }
        if (isset($map['purchaserBankAccount'])) {
            $model->purchaserBankAccount = $map['purchaserBankAccount'];
        }
        if (isset($map['purchaserBankNameAccount'])) {
            $model->purchaserBankNameAccount = $map['purchaserBankNameAccount'];
        }
        if (isset($map['purchaserName'])) {
            $model->purchaserName = $map['purchaserName'];
        }
        if (isset($map['purchaserTaxNo'])) {
            $model->purchaserTaxNo = $map['purchaserTaxNo'];
        }
        if (isset($map['purchaserTel'])) {
            $model->purchaserTel = $map['purchaserTel'];
        }
        if (isset($map['receiverEmail'])) {
            $model->receiverEmail = $map['receiverEmail'];
        }
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverTel'])) {
            $model->receiverTel = $map['receiverTel'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['seatClass'])) {
            $model->seatClass = $map['seatClass'];
        }
        if (isset($map['secondHandCarInvoiceDetailList'])) {
            if (!empty($map['secondHandCarInvoiceDetailList'])) {
                $model->secondHandCarInvoiceDetailList = [];
                $n                                     = 0;
                foreach ($map['secondHandCarInvoiceDetailList'] as $item) {
                    $model->secondHandCarInvoiceDetailList[$n++] = null !== $item ? secondHandCarInvoiceDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sellerAddress'])) {
            $model->sellerAddress = $map['sellerAddress'];
        }
        if (isset($map['sellerBankAccount'])) {
            $model->sellerBankAccount = $map['sellerBankAccount'];
        }
        if (isset($map['sellerBankNameAccount'])) {
            $model->sellerBankNameAccount = $map['sellerBankNameAccount'];
        }
        if (isset($map['sellerName'])) {
            $model->sellerName = $map['sellerName'];
        }
        if (isset($map['sellerTaxNo'])) {
            $model->sellerTaxNo = $map['sellerTaxNo'];
        }
        if (isset($map['sellerTel'])) {
            $model->sellerTel = $map['sellerTel'];
        }
        if (isset($map['serialNo'])) {
            $model->serialNo = $map['serialNo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['supplySign'])) {
            $model->supplySign = $map['supplySign'];
        }
        if (isset($map['surcharge'])) {
            $model->surcharge = $map['surcharge'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
        }
        if (isset($map['trainNo'])) {
            $model->trainNo = $map['trainNo'];
        }
        if (isset($map['travelDate'])) {
            $model->travelDate = $map['travelDate'];
        }
        if (isset($map['usedVehicleSaleDetailVOList'])) {
            if (!empty($map['usedVehicleSaleDetailVOList'])) {
                $model->usedVehicleSaleDetailVOList = [];
                $n                                  = 0;
                foreach ($map['usedVehicleSaleDetailVOList'] as $item) {
                    $model->usedVehicleSaleDetailVOList[$n++] = null !== $item ? usedVehicleSaleDetailVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['vehicleSaleDetailVOList'])) {
            if (!empty($map['vehicleSaleDetailVOList'])) {
                $model->vehicleSaleDetailVOList = [];
                $n                              = 0;
                foreach ($map['vehicleSaleDetailVOList'] as $item) {
                    $model->vehicleSaleDetailVOList[$n++] = null !== $item ? vehicleSaleDetailVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['verifyStatus'])) {
            $model->verifyStatus = $map['verifyStatus'];
        }
        if (isset($map['voucherCode'])) {
            $model->voucherCode = $map['voucherCode'];
        }
        if (isset($map['voucherStatus'])) {
            $model->voucherStatus = $map['voucherStatus'];
        }

        return $model;
    }
}
