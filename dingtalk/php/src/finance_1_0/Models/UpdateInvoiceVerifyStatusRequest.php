<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInvoiceVerifyStatusRequest extends Model
{
    /**
     * @description 查验流水号
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 查验结果
     *
     * @var int
     */
    public $checkingResult;

    /**
     * @description 查验状态
     *
     * @var int
     */
    public $checkingStatus;

    /**
     * @description 业务响应码
     *
     * @var string
     */
    public $code;

    /**
     * @description 企业Id
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $extension;

    /**
     * @description 发票代码
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description 发票号码
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description 发票状态
     *
     * @var int
     */
    public $invoiceStatus;

    /**
     * @description 发票验真编号
     *
     * @var string
     */
    public $invoiceVerifyId;

    /**
     * @description 响应信息
     *
     * @var string
     */
    public $msg;

    /**
     * @description 用户Id
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
