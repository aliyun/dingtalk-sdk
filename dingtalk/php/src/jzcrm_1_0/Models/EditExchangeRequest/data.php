<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditExchangeRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
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
     * @description 对应客户
     *
     * @var string
     */
    public $hhCustomerid;

    /**
     * @description 换货日期
     *
     * @var string
     */
    public $hhDate;

    /**
     * @description 换入操作员
     *
     * @var string
     */
    public $hhInempid;

    /**
     * @description 换入仓库
     *
     * @var string
     */
    public $hhInlibid;

    /**
     * @description 换入时间
     *
     * @var string
     */
    public $hhIntime;

    /**
     * @description 换货单号
     *
     * @var string
     */
    public $hhNumber;

    /**
     * @description 合同/订单
     *
     * @var string
     */
    public $hhOrderid;

    /**
     * @description 换出操作员
     *
     * @var string
     */
    public $hhOutempid;

    /**
     * @description 换出仓库
     *
     * @var string
     */
    public $hhOutlibid;

    /**
     * @description 换出时间
     *
     * @var string
     */
    public $hhOuttime;

    /**
     * @description 备注
     *
     * @var string
     */
    public $hhRemark;

    /**
     * @description 状态（未执行，已入待出，已出待入，结束）
     *
     * @var string
     */
    public $hhState;

    /**
     * @description 主题
     *
     * @var string
     */
    public $hhTitle;

    /**
     * @description 分类
     *
     * @var string
     */
    public $hhType;
    protected $_name = [
        'childMx'      => 'child_mx',
        'dataUserid'   => 'data_userid',
        'hhCustomerid' => 'hh_customerid',
        'hhDate'       => 'hh_date',
        'hhInempid'    => 'hh_inempid',
        'hhInlibid'    => 'hh_inlibid',
        'hhIntime'     => 'hh_intime',
        'hhNumber'     => 'hh_number',
        'hhOrderid'    => 'hh_orderid',
        'hhOutempid'   => 'hh_outempid',
        'hhOutlibid'   => 'hh_outlibid',
        'hhOuttime'    => 'hh_outtime',
        'hhRemark'     => 'hh_remark',
        'hhState'      => 'hh_state',
        'hhTitle'      => 'hh_title',
        'hhType'       => 'hh_type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->childMx) {
            $res['child_mx'] = $this->childMx;
        }
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
        }
        if (null !== $this->hhCustomerid) {
            $res['hh_customerid'] = $this->hhCustomerid;
        }
        if (null !== $this->hhDate) {
            $res['hh_date'] = $this->hhDate;
        }
        if (null !== $this->hhInempid) {
            $res['hh_inempid'] = $this->hhInempid;
        }
        if (null !== $this->hhInlibid) {
            $res['hh_inlibid'] = $this->hhInlibid;
        }
        if (null !== $this->hhIntime) {
            $res['hh_intime'] = $this->hhIntime;
        }
        if (null !== $this->hhNumber) {
            $res['hh_number'] = $this->hhNumber;
        }
        if (null !== $this->hhOrderid) {
            $res['hh_orderid'] = $this->hhOrderid;
        }
        if (null !== $this->hhOutempid) {
            $res['hh_outempid'] = $this->hhOutempid;
        }
        if (null !== $this->hhOutlibid) {
            $res['hh_outlibid'] = $this->hhOutlibid;
        }
        if (null !== $this->hhOuttime) {
            $res['hh_outtime'] = $this->hhOuttime;
        }
        if (null !== $this->hhRemark) {
            $res['hh_remark'] = $this->hhRemark;
        }
        if (null !== $this->hhState) {
            $res['hh_state'] = $this->hhState;
        }
        if (null !== $this->hhTitle) {
            $res['hh_title'] = $this->hhTitle;
        }
        if (null !== $this->hhType) {
            $res['hh_type'] = $this->hhType;
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
        if (isset($map['child_mx'])) {
            $model->childMx = $map['child_mx'];
        }
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }
        if (isset($map['hh_customerid'])) {
            $model->hhCustomerid = $map['hh_customerid'];
        }
        if (isset($map['hh_date'])) {
            $model->hhDate = $map['hh_date'];
        }
        if (isset($map['hh_inempid'])) {
            $model->hhInempid = $map['hh_inempid'];
        }
        if (isset($map['hh_inlibid'])) {
            $model->hhInlibid = $map['hh_inlibid'];
        }
        if (isset($map['hh_intime'])) {
            $model->hhIntime = $map['hh_intime'];
        }
        if (isset($map['hh_number'])) {
            $model->hhNumber = $map['hh_number'];
        }
        if (isset($map['hh_orderid'])) {
            $model->hhOrderid = $map['hh_orderid'];
        }
        if (isset($map['hh_outempid'])) {
            $model->hhOutempid = $map['hh_outempid'];
        }
        if (isset($map['hh_outlibid'])) {
            $model->hhOutlibid = $map['hh_outlibid'];
        }
        if (isset($map['hh_outtime'])) {
            $model->hhOuttime = $map['hh_outtime'];
        }
        if (isset($map['hh_remark'])) {
            $model->hhRemark = $map['hh_remark'];
        }
        if (isset($map['hh_state'])) {
            $model->hhState = $map['hh_state'];
        }
        if (isset($map['hh_title'])) {
            $model->hhTitle = $map['hh_title'];
        }
        if (isset($map['hh_type'])) {
            $model->hhType = $map['hh_type'];
        }

        return $model;
    }
}
