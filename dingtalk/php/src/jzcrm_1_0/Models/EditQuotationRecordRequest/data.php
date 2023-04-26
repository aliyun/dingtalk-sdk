<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditQuotationRecordRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $bjBjren;

    /**
     * @var string
     */
    public $bjBzremark;

    /**
     * @var string
     */
    public $bjCustomerid;

    /**
     * @var string
     */
    public $bjDate;

    /**
     * @var string
     */
    public $bjFjmoney;

    /**
     * @var string
     */
    public $bjFjmoneylx;

    /**
     * @var string
     */
    public $bjFkremark;

    /**
     * @var string
     */
    public $bjJfremark;

    /**
     * @var string
     */
    public $bjJshren;

    /**
     * @var string
     */
    public $bjKjmoney;

    /**
     * @var string
     */
    public $bjLianxi;

    /**
     * @var string
     */
    public $bjMoneyzhekou;

    /**
     * @var string
     */
    public $bjNumber;

    /**
     * @var string
     */
    public $bjPrice;

    /**
     * @var string
     */
    public $bjRemark;

    /**
     * @var string
     */
    public $bjState;

    /**
     * @var string
     */
    public $bjTitle;

    /**
     * @var string
     */
    public $bjXshid;

    /**
     * @example "child_mx":[{"产品ID":"1","数量":"10","单价":"58.5","总价":"585","明细备注":"包含的测试产品"}]
     *
     * @var string
     */
    public $childMx;

    /**
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;
    protected $_name = [
        'bjBjren'       => 'bj_bjren',
        'bjBzremark'    => 'bj_bzremark',
        'bjCustomerid'  => 'bj_customerid',
        'bjDate'        => 'bj_date',
        'bjFjmoney'     => 'bj_fjmoney',
        'bjFjmoneylx'   => 'bj_fjmoneylx',
        'bjFkremark'    => 'bj_fkremark',
        'bjJfremark'    => 'bj_jfremark',
        'bjJshren'      => 'bj_jshren',
        'bjKjmoney'     => 'bj_kjmoney',
        'bjLianxi'      => 'bj_lianxi',
        'bjMoneyzhekou' => 'bj_moneyzhekou',
        'bjNumber'      => 'bj_number',
        'bjPrice'       => 'bj_price',
        'bjRemark'      => 'bj_remark',
        'bjState'       => 'bj_state',
        'bjTitle'       => 'bj_title',
        'bjXshid'       => 'bj_xshid',
        'childMx'       => 'child_mx',
        'dataUserid'    => 'data_userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bjBjren) {
            $res['bj_bjren'] = $this->bjBjren;
        }
        if (null !== $this->bjBzremark) {
            $res['bj_bzremark'] = $this->bjBzremark;
        }
        if (null !== $this->bjCustomerid) {
            $res['bj_customerid'] = $this->bjCustomerid;
        }
        if (null !== $this->bjDate) {
            $res['bj_date'] = $this->bjDate;
        }
        if (null !== $this->bjFjmoney) {
            $res['bj_fjmoney'] = $this->bjFjmoney;
        }
        if (null !== $this->bjFjmoneylx) {
            $res['bj_fjmoneylx'] = $this->bjFjmoneylx;
        }
        if (null !== $this->bjFkremark) {
            $res['bj_fkremark'] = $this->bjFkremark;
        }
        if (null !== $this->bjJfremark) {
            $res['bj_jfremark'] = $this->bjJfremark;
        }
        if (null !== $this->bjJshren) {
            $res['bj_jshren'] = $this->bjJshren;
        }
        if (null !== $this->bjKjmoney) {
            $res['bj_kjmoney'] = $this->bjKjmoney;
        }
        if (null !== $this->bjLianxi) {
            $res['bj_lianxi'] = $this->bjLianxi;
        }
        if (null !== $this->bjMoneyzhekou) {
            $res['bj_moneyzhekou'] = $this->bjMoneyzhekou;
        }
        if (null !== $this->bjNumber) {
            $res['bj_number'] = $this->bjNumber;
        }
        if (null !== $this->bjPrice) {
            $res['bj_price'] = $this->bjPrice;
        }
        if (null !== $this->bjRemark) {
            $res['bj_remark'] = $this->bjRemark;
        }
        if (null !== $this->bjState) {
            $res['bj_state'] = $this->bjState;
        }
        if (null !== $this->bjTitle) {
            $res['bj_title'] = $this->bjTitle;
        }
        if (null !== $this->bjXshid) {
            $res['bj_xshid'] = $this->bjXshid;
        }
        if (null !== $this->childMx) {
            $res['child_mx'] = $this->childMx;
        }
        if (null !== $this->dataUserid) {
            $res['data_userid'] = $this->dataUserid;
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
        if (isset($map['bj_bjren'])) {
            $model->bjBjren = $map['bj_bjren'];
        }
        if (isset($map['bj_bzremark'])) {
            $model->bjBzremark = $map['bj_bzremark'];
        }
        if (isset($map['bj_customerid'])) {
            $model->bjCustomerid = $map['bj_customerid'];
        }
        if (isset($map['bj_date'])) {
            $model->bjDate = $map['bj_date'];
        }
        if (isset($map['bj_fjmoney'])) {
            $model->bjFjmoney = $map['bj_fjmoney'];
        }
        if (isset($map['bj_fjmoneylx'])) {
            $model->bjFjmoneylx = $map['bj_fjmoneylx'];
        }
        if (isset($map['bj_fkremark'])) {
            $model->bjFkremark = $map['bj_fkremark'];
        }
        if (isset($map['bj_jfremark'])) {
            $model->bjJfremark = $map['bj_jfremark'];
        }
        if (isset($map['bj_jshren'])) {
            $model->bjJshren = $map['bj_jshren'];
        }
        if (isset($map['bj_kjmoney'])) {
            $model->bjKjmoney = $map['bj_kjmoney'];
        }
        if (isset($map['bj_lianxi'])) {
            $model->bjLianxi = $map['bj_lianxi'];
        }
        if (isset($map['bj_moneyzhekou'])) {
            $model->bjMoneyzhekou = $map['bj_moneyzhekou'];
        }
        if (isset($map['bj_number'])) {
            $model->bjNumber = $map['bj_number'];
        }
        if (isset($map['bj_price'])) {
            $model->bjPrice = $map['bj_price'];
        }
        if (isset($map['bj_remark'])) {
            $model->bjRemark = $map['bj_remark'];
        }
        if (isset($map['bj_state'])) {
            $model->bjState = $map['bj_state'];
        }
        if (isset($map['bj_title'])) {
            $model->bjTitle = $map['bj_title'];
        }
        if (isset($map['bj_xshid'])) {
            $model->bjXshid = $map['bj_xshid'];
        }
        if (isset($map['child_mx'])) {
            $model->childMx = $map['child_mx'];
        }
        if (isset($map['data_userid'])) {
            $model->dataUserid = $map['data_userid'];
        }

        return $model;
    }
}
