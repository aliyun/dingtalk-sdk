<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditIntostockRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $askempid;

    /**
     * @var string
     */
    public $auditreson;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $billno;

    /**
     * @description This parameter is required.
     *
     * @example "child_mx":[{"产品ID":"1","数量":"10","单价":"58.5","总价":"585","明细备注":"包含的测试产品"}]
     *
     * @var string
     */
    public $childMx;

    /**
     * @var string
     */
    public $customerid;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $empid;

    /**
     * @var string
     */
    public $inorout;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $libiodate;

    /**
     * @var string
     */
    public $libioname;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $libiostate;

    /**
     * @var string
     */
    public $orderid;

    /**
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $stocklibid;
    protected $_name = [
        'askempid' => 'askempid',
        'auditreson' => 'auditreson',
        'billno' => 'billno',
        'childMx' => 'child_mx',
        'customerid' => 'customerid',
        'dataUserid' => 'data_userid',
        'empid' => 'empid',
        'inorout' => 'inorout',
        'libiodate' => 'libiodate',
        'libioname' => 'libioname',
        'libiostate' => 'libiostate',
        'orderid' => 'orderid',
        'remark' => 'remark',
        'stocklibid' => 'stocklibid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->askempid) {
            $res['askempid'] = $this->askempid;
        }
        if (null !== $this->auditreson) {
            $res['auditreson'] = $this->auditreson;
        }
        if (null !== $this->billno) {
            $res['billno'] = $this->billno;
        }
        if (null !== $this->childMx) {
            $res['child_mx'] = $this->childMx;
        }
        if (null !== $this->customerid) {
            $res['customerid'] = $this->customerid;
        }
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->empid) {
            $res['empid'] = $this->empid;
        }
        if (null !== $this->inorout) {
            $res['inorout'] = $this->inorout;
        }
        if (null !== $this->libiodate) {
            $res['libiodate'] = $this->libiodate;
        }
        if (null !== $this->libioname) {
            $res['libioname'] = $this->libioname;
        }
        if (null !== $this->libiostate) {
            $res['libiostate'] = $this->libiostate;
        }
        if (null !== $this->orderid) {
            $res['orderid'] = $this->orderid;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->stocklibid) {
            $res['stocklibid'] = $this->stocklibid;
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
        if (isset($map['askempid'])) {
            $model->askempid = $map['askempid'];
        }
        if (isset($map['auditreson'])) {
            $model->auditreson = $map['auditreson'];
        }
        if (isset($map['billno'])) {
            $model->billno = $map['billno'];
        }
        if (isset($map['child_mx'])) {
            $model->childMx = $map['child_mx'];
        }
        if (isset($map['customerid'])) {
            $model->customerid = $map['customerid'];
        }
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['empid'])) {
            $model->empid = $map['empid'];
        }
        if (isset($map['inorout'])) {
            $model->inorout = $map['inorout'];
        }
        if (isset($map['libiodate'])) {
            $model->libiodate = $map['libiodate'];
        }
        if (isset($map['libioname'])) {
            $model->libioname = $map['libioname'];
        }
        if (isset($map['libiostate'])) {
            $model->libiostate = $map['libiostate'];
        }
        if (isset($map['orderid'])) {
            $model->orderid = $map['orderid'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['stocklibid'])) {
            $model->stocklibid = $map['stocklibid'];
        }

        return $model;
    }
}
