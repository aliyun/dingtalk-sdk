<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\blueGeneralInvoiceVO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\redGeneralInvoiceVO;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAbandonStatusRequest extends Model
{
    /**
     * @description 发票全票面信息（蓝票）
     *
     * @var blueGeneralInvoiceVO
     */
    public $blueGeneralInvoiceVO;

    /**
     * @description 发票编码（蓝票）
     *
     * @var string
     */
    public $blueInvoiceCode;

    /**
     * @description 发票号码（蓝票）
     *
     * @var string
     */
    public $blueInvoiceNo;

    /**
     * @description 状态-红冲、废弃
     *
     * @var string
     */
    public $blueInvoiceStatus;

    /**
     * @description 操作员
     *
     * @var string
     */
    public $operator;

    /**
     * @description 发票全票面信息（红票）
     *
     * @var redGeneralInvoiceVO
     */
    public $redGeneralInvoiceVO;

    /**
     * @description 红字发票code
     *
     * @var string
     */
    public $redInvoiceCode;

    /**
     * @description 红字发票编码
     *
     * @var string
     */
    public $redInvoiceNo;

    /**
     * @description 红字发票状态
     *
     * @var string
     */
    public $redInvoiceStatus;

    /**
     * @description 目标发票
     *
     * @var string
     */
    public $targetInvoice;
    protected $_name = [
        'blueGeneralInvoiceVO' => 'blueGeneralInvoiceVO',
        'blueInvoiceCode'      => 'blueInvoiceCode',
        'blueInvoiceNo'        => 'blueInvoiceNo',
        'blueInvoiceStatus'    => 'blueInvoiceStatus',
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
