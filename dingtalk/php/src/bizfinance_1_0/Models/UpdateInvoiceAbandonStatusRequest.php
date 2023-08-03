<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\blueGeneralInvoiceVO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\redGeneralInvoiceVO;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAbandonStatusRequest extends Model
{
    /**
     * @var blueGeneralInvoiceVO
     */
    public $blueGeneralInvoiceVO;

    /**
     * @var string
     */
    public $blueInvoiceCode;

    /**
     * @var string
     */
    public $blueInvoiceNo;

    /**
     * @var string
     */
    public $blueInvoiceStatus;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $operator;

    /**
     * @var redGeneralInvoiceVO
     */
    public $redGeneralInvoiceVO;

    /**
     * @var string
     */
    public $redInvoiceCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $redInvoiceNo;

    /**
     * @example abc
     *
     * @var string
     */
    public $redInvoiceStatus;

    /**
     * @example abc
     *
     * @var string
     */
    public $targetInvoice;
    protected $_name = [
        'blueGeneralInvoiceVO' => 'blueGeneralInvoiceVO',
        'blueInvoiceCode'      => 'blueInvoiceCode',
        'blueInvoiceNo'        => 'blueInvoiceNo',
        'blueInvoiceStatus'    => 'blueInvoiceStatus',
        'companyCode'          => 'companyCode',
        'operator'             => 'operator',
        'redGeneralInvoiceVO'  => 'redGeneralInvoiceVO',
        'redInvoiceCode'       => 'redInvoiceCode',
        'redInvoiceNo'         => 'redInvoiceNo',
        'redInvoiceStatus'     => 'redInvoiceStatus',
        'targetInvoice'        => 'targetInvoice',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blueGeneralInvoiceVO) {
            $res['blueGeneralInvoiceVO'] = null !== $this->blueGeneralInvoiceVO ? $this->blueGeneralInvoiceVO->toMap() : null;
        }
        if (null !== $this->blueInvoiceCode) {
            $res['blueInvoiceCode'] = $this->blueInvoiceCode;
        }
        if (null !== $this->blueInvoiceNo) {
            $res['blueInvoiceNo'] = $this->blueInvoiceNo;
        }
        if (null !== $this->blueInvoiceStatus) {
            $res['blueInvoiceStatus'] = $this->blueInvoiceStatus;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->redGeneralInvoiceVO) {
            $res['redGeneralInvoiceVO'] = null !== $this->redGeneralInvoiceVO ? $this->redGeneralInvoiceVO->toMap() : null;
        }
        if (null !== $this->redInvoiceCode) {
            $res['redInvoiceCode'] = $this->redInvoiceCode;
        }
        if (null !== $this->redInvoiceNo) {
            $res['redInvoiceNo'] = $this->redInvoiceNo;
        }
        if (null !== $this->redInvoiceStatus) {
            $res['redInvoiceStatus'] = $this->redInvoiceStatus;
        }
        if (null !== $this->targetInvoice) {
            $res['targetInvoice'] = $this->targetInvoice;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAbandonStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blueGeneralInvoiceVO'])) {
            $model->blueGeneralInvoiceVO = blueGeneralInvoiceVO::fromMap($map['blueGeneralInvoiceVO']);
        }
        if (isset($map['blueInvoiceCode'])) {
            $model->blueInvoiceCode = $map['blueInvoiceCode'];
        }
        if (isset($map['blueInvoiceNo'])) {
            $model->blueInvoiceNo = $map['blueInvoiceNo'];
        }
        if (isset($map['blueInvoiceStatus'])) {
            $model->blueInvoiceStatus = $map['blueInvoiceStatus'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['redGeneralInvoiceVO'])) {
            $model->redGeneralInvoiceVO = redGeneralInvoiceVO::fromMap($map['redGeneralInvoiceVO']);
        }
        if (isset($map['redInvoiceCode'])) {
            $model->redInvoiceCode = $map['redInvoiceCode'];
        }
        if (isset($map['redInvoiceNo'])) {
            $model->redInvoiceNo = $map['redInvoiceNo'];
        }
        if (isset($map['redInvoiceStatus'])) {
            $model->redInvoiceStatus = $map['redInvoiceStatus'];
        }
        if (isset($map['targetInvoice'])) {
            $model->targetInvoice = $map['targetInvoice'];
        }

        return $model;
    }
}
