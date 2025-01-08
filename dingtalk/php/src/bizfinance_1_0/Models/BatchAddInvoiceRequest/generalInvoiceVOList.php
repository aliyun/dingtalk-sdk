<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\eFlightItineraryDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\eTrainTicketDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\generalInvoiceDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\secondHandCarInvoiceDetailList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\usedVehicleSaleDetailVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList\vehicleSaleDetailVOList;
use AlibabaCloud\Tea\Model;

class generalInvoiceVOList extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountPeriod;

    /**
     * @example 100
     *
     * @var string
     */
    public $amount;

    /**
     * @example 120
     *
     * @var string
     */
    public $amountWithTax;

    /**
     * @example 1111
     *
     * @var string
     */
    public $checkCode;

    /**
     * @example 2010-12-12
     *
     * @var string
     */
    public $checkTime;

    /**
     * @example 张三
     *
     * @var string
     */
    public $drawerName;

    /**
     * @example 2022-12-10
     *
     * @var string
     */
    public $drewDate;

    /**
     * @var eFlightItineraryDetailVOList[]
     */
    public $eFlightItineraryDetailVOList;

    /**
     * @var eTrainTicketDetailVOList[]
     */
    public $eTrainTicketDetailVOList;

    /**
     * @example abc
     *
     * @var string
     */
    public $electronicUrl;

    /**
     * @var string
     */
    public $fileId;

    /**
     * @example INPUT_VAT
     *
     * @var string
     */
    public $financeType;

    /**
     * @example RED
     *
     * @var string
     */
    public $fundType;

    /**
     * @var generalInvoiceDetailVOList[]
     */
    public $generalInvoiceDetailVOList;

    /**
     * @example http://XXX.jpg
     *
     * @var string
     */
    public $imageUrl;

    /**
     * @example abc
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @example abc
     *
     * @var string
     */
    public $invoiceStatus;

    /**
     * @example INTPUT_VAT
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @example 1111
     *
     * @var string
     */
    public $machineCode;

    /**
     * @var string
     */
    public $ofdUrl;

    /**
     * @example abc
     *
     * @var string
     */
    public $oilFlag;

    /**
     * @example abc
     *
     * @var string
     */
    public $payee;

    /**
     * @var string
     */
    public $pdfUrl;

    /**
     * @example abc
     *
     * @var string
     */
    public $processInstCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $processInstType;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @var string
     */
    public $purchaserBankAccount;

    /**
     * @example 建行
     *
     * @var string
     */
    public $purchaserBankNameAccount;

    /**
     * @example 张三
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @example 155655
     *
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @example 1333333333
     *
     * @var string
     */
    public $purchaserTel;

    /**
     * @var string
     */
    public $receiverEmail;

    /**
     * @var string
     */
    public $receiverName;

    /**
     * @var string
     */
    public $receiverTel;

    /**
     * @example abc
     *
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $reviewer;

    /**
     * @var secondHandCarInvoiceDetailList[]
     */
    public $secondHandCarInvoiceDetailList;

    /**
     * @example 8852
     *
     * @var string
     */
    public $sellerAddress;

    /**
     * @var string
     */
    public $sellerBankAccount;

    /**
     * @example 招商银行
     *
     * @var string
     */
    public $sellerBankNameAccount;

    /**
     * @example 李四
     *
     * @var string
     */
    public $sellerName;

    /**
     * @example 2202
     *
     * @var string
     */
    public $sellerTaxNo;

    /**
     * @example 13355222222
     *
     * @var string
     */
    public $sellerTel;

    /**
     * @var string
     */
    public $spaceId;

    /**
     * @example abc
     *
     * @var string
     */
    public $supplySign;

    /**
     * @example 20
     *
     * @var string
     */
    public $taxAmount;

    /**
     * @var usedVehicleSaleDetailVOList[]
     */
    public $usedVehicleSaleDetailVOList;

    /**
     * @var vehicleSaleDetailVOList[]
     */
    public $vehicleSaleDetailVOList;

    /**
     * @example abc
     *
     * @var string
     */
    public $verifyStatus;

    /**
     * @example abc
     *
     * @var string
     */
    public $voucherCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $voucherStatus;

    /**
     * @var string
     */
    public $xmlUrl;
    protected $_name = [
        'accountPeriod'                  => 'accountPeriod',
        'amount'                         => 'amount',
        'amountWithTax'                  => 'amountWithTax',
        'checkCode'                      => 'checkCode',
        'checkTime'                      => 'checkTime',
        'drawerName'                     => 'drawerName',
        'drewDate'                       => 'drewDate',
        'eFlightItineraryDetailVOList'   => 'eFlightItineraryDetailVOList',
        'eTrainTicketDetailVOList'       => 'eTrainTicketDetailVOList',
        'electronicUrl'                  => 'electronicUrl',
        'fileId'                         => 'fileId',
        'financeType'                    => 'financeType',
        'fundType'                       => 'fundType',
        'generalInvoiceDetailVOList'     => 'generalInvoiceDetailVOList',
        'imageUrl'                       => 'imageUrl',
        'invoiceCode'                    => 'invoiceCode',
        'invoiceNo'                      => 'invoiceNo',
        'invoiceStatus'                  => 'invoiceStatus',
        'invoiceType'                    => 'invoiceType',
        'machineCode'                    => 'machineCode',
        'ofdUrl'                         => 'ofdUrl',
        'oilFlag'                        => 'oilFlag',
        'payee'                          => 'payee',
        'pdfUrl'                         => 'pdfUrl',
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
        'reviewer'                       => 'reviewer',
        'secondHandCarInvoiceDetailList' => 'secondHandCarInvoiceDetailList',
        'sellerAddress'                  => 'sellerAddress',
        'sellerBankAccount'              => 'sellerBankAccount',
        'sellerBankNameAccount'          => 'sellerBankNameAccount',
        'sellerName'                     => 'sellerName',
        'sellerTaxNo'                    => 'sellerTaxNo',
        'sellerTel'                      => 'sellerTel',
        'spaceId'                        => 'spaceId',
        'supplySign'                     => 'supplySign',
        'taxAmount'                      => 'taxAmount',
        'usedVehicleSaleDetailVOList'    => 'usedVehicleSaleDetailVOList',
        'vehicleSaleDetailVOList'        => 'vehicleSaleDetailVOList',
        'verifyStatus'                   => 'verifyStatus',
        'voucherCode'                    => 'voucherCode',
        'voucherStatus'                  => 'voucherStatus',
        'xmlUrl'                         => 'xmlUrl',
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
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->amountWithTax) {
            $res['amountWithTax'] = $this->amountWithTax;
        }
        if (null !== $this->checkCode) {
            $res['checkCode'] = $this->checkCode;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->drawerName) {
            $res['drawerName'] = $this->drawerName;
        }
        if (null !== $this->drewDate) {
            $res['drewDate'] = $this->drewDate;
        }
        if (null !== $this->eFlightItineraryDetailVOList) {
            $res['eFlightItineraryDetailVOList'] = [];
            if (null !== $this->eFlightItineraryDetailVOList && \is_array($this->eFlightItineraryDetailVOList)) {
                $n = 0;
                foreach ($this->eFlightItineraryDetailVOList as $item) {
                    $res['eFlightItineraryDetailVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->eTrainTicketDetailVOList) {
            $res['eTrainTicketDetailVOList'] = [];
            if (null !== $this->eTrainTicketDetailVOList && \is_array($this->eTrainTicketDetailVOList)) {
                $n = 0;
                foreach ($this->eTrainTicketDetailVOList as $item) {
                    $res['eTrainTicketDetailVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->electronicUrl) {
            $res['electronicUrl'] = $this->electronicUrl;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->financeType) {
            $res['financeType'] = $this->financeType;
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
        if (null !== $this->machineCode) {
            $res['machineCode'] = $this->machineCode;
        }
        if (null !== $this->ofdUrl) {
            $res['ofdUrl'] = $this->ofdUrl;
        }
        if (null !== $this->oilFlag) {
            $res['oilFlag'] = $this->oilFlag;
        }
        if (null !== $this->payee) {
            $res['payee'] = $this->payee;
        }
        if (null !== $this->pdfUrl) {
            $res['pdfUrl'] = $this->pdfUrl;
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
        if (null !== $this->reviewer) {
            $res['reviewer'] = $this->reviewer;
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
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->supplySign) {
            $res['supplySign'] = $this->supplySign;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
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
        if (null !== $this->xmlUrl) {
            $res['xmlUrl'] = $this->xmlUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return generalInvoiceVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountPeriod'])) {
            $model->accountPeriod = $map['accountPeriod'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['amountWithTax'])) {
            $model->amountWithTax = $map['amountWithTax'];
        }
        if (isset($map['checkCode'])) {
            $model->checkCode = $map['checkCode'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['drawerName'])) {
            $model->drawerName = $map['drawerName'];
        }
        if (isset($map['drewDate'])) {
            $model->drewDate = $map['drewDate'];
        }
        if (isset($map['eFlightItineraryDetailVOList'])) {
            if (!empty($map['eFlightItineraryDetailVOList'])) {
                $model->eFlightItineraryDetailVOList = [];
                $n                                   = 0;
                foreach ($map['eFlightItineraryDetailVOList'] as $item) {
                    $model->eFlightItineraryDetailVOList[$n++] = null !== $item ? eFlightItineraryDetailVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['eTrainTicketDetailVOList'])) {
            if (!empty($map['eTrainTicketDetailVOList'])) {
                $model->eTrainTicketDetailVOList = [];
                $n                               = 0;
                foreach ($map['eTrainTicketDetailVOList'] as $item) {
                    $model->eTrainTicketDetailVOList[$n++] = null !== $item ? eTrainTicketDetailVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['electronicUrl'])) {
            $model->electronicUrl = $map['electronicUrl'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['financeType'])) {
            $model->financeType = $map['financeType'];
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
        if (isset($map['machineCode'])) {
            $model->machineCode = $map['machineCode'];
        }
        if (isset($map['ofdUrl'])) {
            $model->ofdUrl = $map['ofdUrl'];
        }
        if (isset($map['oilFlag'])) {
            $model->oilFlag = $map['oilFlag'];
        }
        if (isset($map['payee'])) {
            $model->payee = $map['payee'];
        }
        if (isset($map['pdfUrl'])) {
            $model->pdfUrl = $map['pdfUrl'];
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
        if (isset($map['reviewer'])) {
            $model->reviewer = $map['reviewer'];
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
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['supplySign'])) {
            $model->supplySign = $map['supplySign'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
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
        if (isset($map['xmlUrl'])) {
            $model->xmlUrl = $map['xmlUrl'];
        }

        return $model;
    }
}
