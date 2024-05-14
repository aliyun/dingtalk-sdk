<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditExchangeRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example "child_mx":[{"产品ID":"1","数量":"10","明细备注":"包含的测试产品","序列号-换入":"• in1001• in1002...无则不传递","批次号-换入":"• in2001 (10)• in2002 (20)...无则不传递","序列号-换出":"• out1001• out1002...无则不传递","批次号-换出":"• out2001 (10)• out2002 (20)...无则不传递"}]
     *
     * @var string
     */
    public $childMx;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @var string
     */
    public $hhCustomerid;

    /**
     * @var string
     */
    public $hhDate;

    /**
     * @var string
     */
    public $hhInempid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $hhInlibid;

    /**
     * @var string
     */
    public $hhIntime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $hhNumber;

    /**
     * @var string
     */
    public $hhOrderid;

    /**
     * @var string
     */
    public $hhOutempid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $hhOutlibid;

    /**
     * @var string
     */
    public $hhOuttime;

    /**
     * @var string
     */
    public $hhRemark;

    /**
     * @var string
     */
    public $hhState;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $hhTitle;

    /**
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
