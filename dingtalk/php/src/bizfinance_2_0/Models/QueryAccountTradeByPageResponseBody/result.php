<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAccountTradeByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAccountTradeByPageResponseBody\result\receiptFile;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $balance;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $instanceTitle;

    /**
     * @var string
     */
    public $instanceUrl;

    /**
     * @var string
     */
    public $otherAccountName;

    /**
     * @var string
     */
    public $otherAccountNo;

    /**
     * @var receiptFile
     */
    public $receiptFile;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $tradeAmount;

    /**
     * @var string
     */
    public $tradeNo;

    /**
     * @var int
     */
    public $tradeTime;

    /**
     * @var string
     */
    public $tradeType;
    protected $_name = [
        'balance'          => 'balance',
        'instanceId'       => 'instanceId',
        'instanceTitle'    => 'instanceTitle',
        'instanceUrl'      => 'instanceUrl',
        'otherAccountName' => 'otherAccountName',
        'otherAccountNo'   => 'otherAccountNo',
        'receiptFile'      => 'receiptFile',
        'remark'           => 'remark',
        'tradeAmount'      => 'tradeAmount',
        'tradeNo'          => 'tradeNo',
        'tradeTime'        => 'tradeTime',
        'tradeType'        => 'tradeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->balance) {
            $res['balance'] = $this->balance;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->instanceTitle) {
            $res['instanceTitle'] = $this->instanceTitle;
        }
        if (null !== $this->instanceUrl) {
            $res['instanceUrl'] = $this->instanceUrl;
        }
        if (null !== $this->otherAccountName) {
            $res['otherAccountName'] = $this->otherAccountName;
        }
        if (null !== $this->otherAccountNo) {
            $res['otherAccountNo'] = $this->otherAccountNo;
        }
        if (null !== $this->receiptFile) {
            $res['receiptFile'] = null !== $this->receiptFile ? $this->receiptFile->toMap() : null;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->tradeAmount) {
            $res['tradeAmount'] = $this->tradeAmount;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->tradeTime) {
            $res['tradeTime'] = $this->tradeTime;
        }
        if (null !== $this->tradeType) {
            $res['tradeType'] = $this->tradeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['balance'])) {
            $model->balance = $map['balance'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['instanceTitle'])) {
            $model->instanceTitle = $map['instanceTitle'];
        }
        if (isset($map['instanceUrl'])) {
            $model->instanceUrl = $map['instanceUrl'];
        }
        if (isset($map['otherAccountName'])) {
            $model->otherAccountName = $map['otherAccountName'];
        }
        if (isset($map['otherAccountNo'])) {
            $model->otherAccountNo = $map['otherAccountNo'];
        }
        if (isset($map['receiptFile'])) {
            $model->receiptFile = receiptFile::fromMap($map['receiptFile']);
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['tradeAmount'])) {
            $model->tradeAmount = $map['tradeAmount'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['tradeTime'])) {
            $model->tradeTime = $map['tradeTime'];
        }
        if (isset($map['tradeType'])) {
            $model->tradeType = $map['tradeType'];
        }

        return $model;
    }
}
