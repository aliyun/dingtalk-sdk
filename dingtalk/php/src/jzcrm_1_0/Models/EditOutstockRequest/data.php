<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOutstockRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 创建人
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @description 出库日期
     *
     * @var string
     */
    public $libiodate;

    /**
     * @description 出库仓库
     *
     * @var string
     */
    public $stocklibid;

    /**
     * @description 出库状态
     *
     * @var string
     */
    public $libiostate;

    /**
     * @description 出库单号
     *
     * @var string
     */
    public $billno;

    /**
     * @description 对应客户
     *
     * @var string
     */
    public $customerid;

    /**
     * @description 经办人
     *
     * @var string
     */
    public $empid;

    /**
     * @description 单据类型
     *
     * @var string
     */
    public $inorout;

    /**
     * @description 出库主题
     *
     * @var string
     */
    public $libioname;

    /**
     * @description 对应订单
     *
     * @var string
     */
    public $orderid;

    /**
     * @description 申请人
     *
     * @var string
     */
    public $askempid;

    /**
     * @description 申请备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 出库备注
     *
     * @var string
     */
    public $auditreson;

    /**
     * @description 产品明细，json格式
     *
     * @var string
     */
    public $childMx;
    protected $_name = [
        'dataUserid' => 'data_userid',
        'libiodate'  => 'libiodate',
        'stocklibid' => 'stocklibid',
        'libiostate' => 'libiostate',
        'billno'     => 'billno',
        'customerid' => 'customerid',
        'empid'      => 'empid',
        'inorout'    => 'inorout',
        'libioname'  => 'libioname',
        'orderid'    => 'orderid',
        'askempid'   => 'askempid',
        'remark'     => 'remark',
        'auditreson' => 'auditreson',
        'childMx'    => 'child_mx',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->libiodate) {
            $res['libiodate'] = $this->libiodate;
        }
        if (null !== $this->stocklibid) {
            $res['stocklibid'] = $this->stocklibid;
        }
        if (null !== $this->libiostate) {
            $res['libiostate'] = $this->libiostate;
        }
        if (null !== $this->billno) {
            $res['billno'] = $this->billno;
        }
        if (null !== $this->customerid) {
            $res['customerid'] = $this->customerid;
        }
        if (null !== $this->empid) {
            $res['empid'] = $this->empid;
        }
        if (null !== $this->inorout) {
            $res['inorout'] = $this->inorout;
        }
        if (null !== $this->libioname) {
            $res['libioname'] = $this->libioname;
        }
        if (null !== $this->orderid) {
            $res['orderid'] = $this->orderid;
        }
        if (null !== $this->askempid) {
            $res['askempid'] = $this->askempid;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->auditreson) {
            $res['auditreson'] = $this->auditreson;
        }
        if (null !== $this->childMx) {
            $res['child_mx'] = $this->childMx;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['libiodate'])) {
            $model->libiodate = $map['libiodate'];
        }
        if (isset($map['stocklibid'])) {
            $model->stocklibid = $map['stocklibid'];
        }
        if (isset($map['libiostate'])) {
            $model->libiostate = $map['libiostate'];
        }
        if (isset($map['billno'])) {
            $model->billno = $map['billno'];
        }
        if (isset($map['customerid'])) {
            $model->customerid = $map['customerid'];
        }
        if (isset($map['empid'])) {
            $model->empid = $map['empid'];
        }
        if (isset($map['inorout'])) {
            $model->inorout = $map['inorout'];
        }
        if (isset($map['libioname'])) {
            $model->libioname = $map['libioname'];
        }
        if (isset($map['orderid'])) {
            $model->orderid = $map['orderid'];
        }
        if (isset($map['askempid'])) {
            $model->askempid = $map['askempid'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['auditreson'])) {
            $model->auditreson = $map['auditreson'];
        }
        if (isset($map['child_mx'])) {
            $model->childMx = $map['child_mx'];
        }

        return $model;
    }
}
