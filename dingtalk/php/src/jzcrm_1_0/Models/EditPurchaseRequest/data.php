<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditPurchaseRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 附加费用金额
     *
     * @var string
     */
    public $cgFjmoney;

    /**
     * @description 附加费用分类
     *
     * @var string
     */
    public $cgFjmoneylx;

    /**
     * @description 优惠抹零金额
     *
     * @var string
     */
    public $cgKjmoney;

    /**
     * @description 优惠折扣率
     *
     * @var string
     */
    public $cgMoneyzhekou;

    /**
     * @description 执行状态
     *
     * @var string
     */
    public $cgZxstate;

    /**
     * @description 采购日期
     *
     * @var string
     */
    public $cgdate;

    /**
     * @description 采购主题
     *
     * @var string
     */
    public $cgname;

    /**
     * @description 采购单号
     *
     * @var string
     */
    public $cgno;

    /**
     * @description 采购摘要
     *
     * @var string
     */
    public $cgremark;

    /**
     * @description 采购分类
     *
     * @var string
     */
    public $cgtype;

    /**
     * @description 产品明细，json格式
     *
     * @var string
     */
    public $childMx;

    /**
     * @description 创建人
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @description 我方代表
     *
     * @var string
     */
    public $empid;

    /**
     * @description 供应商联系人
     *
     * @var string
     */
    public $gysLxrid;

    /**
     * @description 联系方式
     *
     * @var string
     */
    public $gysLxrinfo;

    /**
     * @description 供应商
     *
     * @var string
     */
    public $gysid;

    /**
     * @description 供应商代表
     *
     * @var string
     */
    public $gysjingban;

    /**
     * @description 关联订单
     *
     * @var string
     */
    public $orderHtid;

    /**
     * @description 关联订单客户
     *
     * @var string
     */
    public $orderKhid;

    /**
     * @description 采购金额
     *
     * @var string
     */
    public $summoney;
    protected $_name = [
        'cgFjmoney'     => 'cg_fjmoney',
        'cgFjmoneylx'   => 'cg_fjmoneylx',
        'cgKjmoney'     => 'cg_kjmoney',
        'cgMoneyzhekou' => 'cg_moneyzhekou',
        'cgZxstate'     => 'cg_zxstate',
        'cgdate'        => 'cgdate',
        'cgname'        => 'cgname',
        'cgno'          => 'cgno',
        'cgremark'      => 'cgremark',
        'cgtype'        => 'cgtype',
        'childMx'       => 'child_mx',
        'dataUserid'    => 'data_userid',
        'empid'         => 'empid',
        'gysLxrid'      => 'gys_lxrid',
        'gysLxrinfo'    => 'gys_lxrinfo',
        'gysid'         => 'gysid',
        'gysjingban'    => 'gysjingban',
        'orderHtid'     => 'order_htid',
        'orderKhid'     => 'order_khid',
        'summoney'      => 'summoney',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cgFjmoney) {
            $res['cg_fjmoney'] = $this->cgFjmoney;
        }
        if (null !== $this->cgFjmoneylx) {
            $res['cg_fjmoneylx'] = $this->cgFjmoneylx;
        }
        if (null !== $this->cgKjmoney) {
            $res['cg_kjmoney'] = $this->cgKjmoney;
        }
        if (null !== $this->cgMoneyzhekou) {
            $res['cg_moneyzhekou'] = $this->cgMoneyzhekou;
        }
        if (null !== $this->cgZxstate) {
            $res['cg_zxstate'] = $this->cgZxstate;
        }
        if (null !== $this->cgdate) {
            $res['cgdate'] = $this->cgdate;
        }
        if (null !== $this->cgname) {
            $res['cgname'] = $this->cgname;
        }
        if (null !== $this->cgno) {
            $res['cgno'] = $this->cgno;
        }
        if (null !== $this->cgremark) {
            $res['cgremark'] = $this->cgremark;
        }
        if (null !== $this->cgtype) {
            $res['cgtype'] = $this->cgtype;
        }
        if (null !== $this->childMx) {
            $res['child_mx'] = $this->childMx;
        }
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->empid) {
            $res['empid'] = $this->empid;
        }
        if (null !== $this->gysLxrid) {
            $res['gys_lxrid'] = $this->gysLxrid;
        }
        if (null !== $this->gysLxrinfo) {
            $res['gys_lxrinfo'] = $this->gysLxrinfo;
        }
        if (null !== $this->gysid) {
            $res['gysid'] = $this->gysid;
        }
        if (null !== $this->gysjingban) {
            $res['gysjingban'] = $this->gysjingban;
        }
        if (null !== $this->orderHtid) {
            $res['order_htid'] = $this->orderHtid;
        }
        if (null !== $this->orderKhid) {
            $res['order_khid'] = $this->orderKhid;
        }
        if (null !== $this->summoney) {
            $res['summoney'] = $this->summoney;
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
        if (isset($map['cg_fjmoney'])) {
            $model->cgFjmoney = $map['cg_fjmoney'];
        }
        if (isset($map['cg_fjmoneylx'])) {
            $model->cgFjmoneylx = $map['cg_fjmoneylx'];
        }
        if (isset($map['cg_kjmoney'])) {
            $model->cgKjmoney = $map['cg_kjmoney'];
        }
        if (isset($map['cg_moneyzhekou'])) {
            $model->cgMoneyzhekou = $map['cg_moneyzhekou'];
        }
        if (isset($map['cg_zxstate'])) {
            $model->cgZxstate = $map['cg_zxstate'];
        }
        if (isset($map['cgdate'])) {
            $model->cgdate = $map['cgdate'];
        }
        if (isset($map['cgname'])) {
            $model->cgname = $map['cgname'];
        }
        if (isset($map['cgno'])) {
            $model->cgno = $map['cgno'];
        }
        if (isset($map['cgremark'])) {
            $model->cgremark = $map['cgremark'];
        }
        if (isset($map['cgtype'])) {
            $model->cgtype = $map['cgtype'];
        }
        if (isset($map['child_mx'])) {
            $model->childMx = $map['child_mx'];
        }
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['empid'])) {
            $model->empid = $map['empid'];
        }
        if (isset($map['gys_lxrid'])) {
            $model->gysLxrid = $map['gys_lxrid'];
        }
        if (isset($map['gys_lxrinfo'])) {
            $model->gysLxrinfo = $map['gys_lxrinfo'];
        }
        if (isset($map['gysid'])) {
            $model->gysid = $map['gysid'];
        }
        if (isset($map['gysjingban'])) {
            $model->gysjingban = $map['gysjingban'];
        }
        if (isset($map['order_htid'])) {
            $model->orderHtid = $map['order_htid'];
        }
        if (isset($map['order_khid'])) {
            $model->orderKhid = $map['order_khid'];
        }
        if (isset($map['summoney'])) {
            $model->summoney = $map['summoney'];
        }

        return $model;
    }
}
