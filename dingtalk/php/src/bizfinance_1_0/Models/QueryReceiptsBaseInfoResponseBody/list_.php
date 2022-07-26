<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody\list_\creator;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody\list_\customer;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody\list_\principal;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody\list_\project;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponseBody\list_\supplier;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建人
     *
     * @var creator
     */
    public $creator;

    /**
     * @description 客户
     *
     * @var customer
     */
    public $customer;

    /**
     * @description 主数据modelId
     *
     * @var string
     */
    public $modelId;

    /**
     * @var principal
     */
    public $principal;

    /**
     * @var project
     */
    public $project;

    /**
     * @description 单据ID
     *
     * @var string
     */
    public $receiptId;

    /**
     * @description 记录时间，默认为审批通过时间
     *
     * @var string
     */
    public $recordTime;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 状态 agree running
     *
     * @var string
     */
    public $status;

    /**
     * @var supplier
     */
    public $supplier;

    /**
     * @description 单据标题
     *
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $voucherStatus;
    protected $_name = [
        'amount'        => 'amount',
        'createTime'    => 'createTime',
        'creator'       => 'creator',
        'customer'      => 'customer',
        'modelId'       => 'modelId',
        'principal'     => 'principal',
        'project'       => 'project',
        'receiptId'     => 'receiptId',
        'recordTime'    => 'recordTime',
        'remark'        => 'remark',
        'source'        => 'source',
        'status'        => 'status',
        'supplier'      => 'supplier',
        'title'         => 'title',
        'voucherStatus' => 'voucherStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->customer) {
            $res['customer'] = null !== $this->customer ? $this->customer->toMap() : null;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->principal) {
            $res['principal'] = null !== $this->principal ? $this->principal->toMap() : null;
        }
        if (null !== $this->project) {
            $res['project'] = null !== $this->project ? $this->project->toMap() : null;
        }
        if (null !== $this->receiptId) {
            $res['receiptId'] = $this->receiptId;
        }
        if (null !== $this->recordTime) {
            $res['recordTime'] = $this->recordTime;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->supplier) {
            $res['supplier'] = null !== $this->supplier ? $this->supplier->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->voucherStatus) {
            $res['voucherStatus'] = $this->voucherStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['customer'])) {
            $model->customer = customer::fromMap($map['customer']);
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['principal'])) {
            $model->principal = principal::fromMap($map['principal']);
        }
        if (isset($map['project'])) {
            $model->project = project::fromMap($map['project']);
        }
        if (isset($map['receiptId'])) {
            $model->receiptId = $map['receiptId'];
        }
        if (isset($map['recordTime'])) {
            $model->recordTime = $map['recordTime'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['supplier'])) {
            $model->supplier = supplier::fromMap($map['supplier']);
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['voucherStatus'])) {
            $model->voucherStatus = $map['voucherStatus'];
        }

        return $model;
    }
}
