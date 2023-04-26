<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInvoiceVerifyStatusRequest extends Model
{
    /**
     * @example lpKgSTzGSy
     *
     * @var string
     */
    public $bizId;

    /**
     * @example 1
     *
     * @var int
     */
    public $checkingResult;

    /**
     * @example 1
     *
     * @var int
     */
    public $checkingStatus;

    /**
     * @example 200
     *
     * @var string
     */
    public $code;

    /**
     * @example ding673cxxxxxxxxxxxx85
     *
     * @var string
     */
    public $corpId;

    /**
     * @example {"restCheckTimes":10,"noticeFlag":1}
     *
     * @var string
     */
    public $extension;

    /**
     * @example 034012100111
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example 61235725
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @example 1
     *
     * @var int
     */
    public $invoiceStatus;

    /**
     * @example 1299999
     *
     * @var string
     */
    public $invoiceVerifyId;

    /**
     * @var string
     */
    public $msg;

    /**
     * @example BPq7qiSIH8PJHlB9kPuii1NQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizId'           => 'bizId',
        'checkingResult'  => 'checkingResult',
        'checkingStatus'  => 'checkingStatus',
        'code'            => 'code',
        'corpId'          => 'corpId',
        'extension'       => 'extension',
        'invoiceCode'     => 'invoiceCode',
        'invoiceNo'       => 'invoiceNo',
        'invoiceStatus'   => 'invoiceStatus',
        'invoiceVerifyId' => 'invoiceVerifyId',
        'msg'             => 'msg',
        'unionId'         => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->checkingResult) {
            $res['checkingResult'] = $this->checkingResult;
        }
        if (null !== $this->checkingStatus) {
            $res['checkingStatus'] = $this->checkingStatus;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
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
        if (null !== $this->invoiceVerifyId) {
            $res['invoiceVerifyId'] = $this->invoiceVerifyId;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceVerifyStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['checkingResult'])) {
            $model->checkingResult = $map['checkingResult'];
        }
        if (isset($map['checkingStatus'])) {
            $model->checkingStatus = $map['checkingStatus'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
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
        if (isset($map['invoiceVerifyId'])) {
            $model->invoiceVerifyId = $map['invoiceVerifyId'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
