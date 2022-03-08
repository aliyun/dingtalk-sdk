<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditInvoiceRequest;

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
     * @description 地址
     *
     * @var string
     */
    public $fhAddress;

    /**
     * @description 对应客户
     *
     * @var string
     */
    public $fhCustomerid;

    /**
     * @description 发货日期
     *
     * @var string
     */
    public $fhDate;

    /**
     * @description Email
     *
     * @var string
     */
    public $fhEmail;

    /**
     * @description 手机
     *
     * @var string
     */
    public $fhHandset;

    /**
     * @description 对应订单
     *
     * @var string
     */
    public $fhHtorder;

    /**
     * @description 打包件数
     *
     * @var string
     */
    public $fhJianshu;

    /**
     * @description 重量(Kg)
     *
     * @var string
     */
    public $fhKg;

    /**
     * @description 收货人
     *
     * @var string
     */
    public $fhLinkman;

    /**
     * @description 联系人
     *
     * @var string
     */
    public $fhLxrid;

    /**
     * @description 发货方式
     *
     * @var string
     */
    public $fhMode;

    /**
     * @description MSN
     *
     * @var string
     */
    public $fhMsn;

    /**
     * @description 发货单号
     *
     * @var string
     */
    public $fhNumber;

    /**
     * @description 邮编
     *
     * @var string
     */
    public $fhPost;

    /**
     * @description 所有者
     *
     * @var string
     */
    public $fhPreside;

    /**
     * @description 备注
     *
     * @var string
     */
    public $fhRemark;

    /**
     * @description 发货人
     *
     * @var string
     */
    public $fhShipper;

    /**
     * @description 发货状态
     *
     * @var string
     */
    public $fhState;

    /**
     * @description 电话
     *
     * @var string
     */
    public $fhTel;

    /**
     * @description 发货主题
     *
     * @var string
     */
    public $fhTitle;

    /**
     * @description 运费
     *
     * @var string
     */
    public $fhYunfei;
    protected $_name = [
        'childMx'      => 'child_mx',
        'dataUserid'   => 'data_userid',
        'fhAddress'    => 'fh_address',
        'fhCustomerid' => 'fh_customerid',
        'fhDate'       => 'fh_date',
        'fhEmail'      => 'fh_email',
        'fhHandset'    => 'fh_handset',
        'fhHtorder'    => 'fh_htorder',
        'fhJianshu'    => 'fh_jianshu',
        'fhKg'         => 'fh_kg',
        'fhLinkman'    => 'fh_linkman',
        'fhLxrid'      => 'fh_lxrid',
        'fhMode'       => 'fh_mode',
        'fhMsn'        => 'fh_msn',
        'fhNumber'     => 'fh_number',
        'fhPost'       => 'fh_post',
        'fhPreside'    => 'fh_preside',
        'fhRemark'     => 'fh_remark',
        'fhShipper'    => 'fh_shipper',
        'fhState'      => 'fh_state',
        'fhTel'        => 'fh_tel',
        'fhTitle'      => 'fh_title',
        'fhYunfei'     => 'fh_yunfei',
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
        if (null !== $this->fhAddress) {
            $res['fh_address'] = $this->fhAddress;
        }
        if (null !== $this->fhCustomerid) {
            $res['fh_customerid'] = $this->fhCustomerid;
        }
        if (null !== $this->fhDate) {
            $res['fh_date'] = $this->fhDate;
        }
        if (null !== $this->fhEmail) {
            $res['fh_email'] = $this->fhEmail;
        }
        if (null !== $this->fhHandset) {
            $res['fh_handset'] = $this->fhHandset;
        }
        if (null !== $this->fhHtorder) {
            $res['fh_htorder'] = $this->fhHtorder;
        }
        if (null !== $this->fhJianshu) {
            $res['fh_jianshu'] = $this->fhJianshu;
        }
        if (null !== $this->fhKg) {
            $res['fh_kg'] = $this->fhKg;
        }
        if (null !== $this->fhLinkman) {
            $res['fh_linkman'] = $this->fhLinkman;
        }
        if (null !== $this->fhLxrid) {
            $res['fh_lxrid'] = $this->fhLxrid;
        }
        if (null !== $this->fhMode) {
            $res['fh_mode'] = $this->fhMode;
        }
        if (null !== $this->fhMsn) {
            $res['fh_msn'] = $this->fhMsn;
        }
        if (null !== $this->fhNumber) {
            $res['fh_number'] = $this->fhNumber;
        }
        if (null !== $this->fhPost) {
            $res['fh_post'] = $this->fhPost;
        }
        if (null !== $this->fhPreside) {
            $res['fh_preside'] = $this->fhPreside;
        }
        if (null !== $this->fhRemark) {
            $res['fh_remark'] = $this->fhRemark;
        }
        if (null !== $this->fhShipper) {
            $res['fh_shipper'] = $this->fhShipper;
        }
        if (null !== $this->fhState) {
            $res['fh_state'] = $this->fhState;
        }
        if (null !== $this->fhTel) {
            $res['fh_tel'] = $this->fhTel;
        }
        if (null !== $this->fhTitle) {
            $res['fh_title'] = $this->fhTitle;
        }
        if (null !== $this->fhYunfei) {
            $res['fh_yunfei'] = $this->fhYunfei;
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
        if (isset($map['fh_address'])) {
            $model->fhAddress = $map['fh_address'];
        }
        if (isset($map['fh_customerid'])) {
            $model->fhCustomerid = $map['fh_customerid'];
        }
        if (isset($map['fh_date'])) {
            $model->fhDate = $map['fh_date'];
        }
        if (isset($map['fh_email'])) {
            $model->fhEmail = $map['fh_email'];
        }
        if (isset($map['fh_handset'])) {
            $model->fhHandset = $map['fh_handset'];
        }
        if (isset($map['fh_htorder'])) {
            $model->fhHtorder = $map['fh_htorder'];
        }
        if (isset($map['fh_jianshu'])) {
            $model->fhJianshu = $map['fh_jianshu'];
        }
        if (isset($map['fh_kg'])) {
            $model->fhKg = $map['fh_kg'];
        }
        if (isset($map['fh_linkman'])) {
            $model->fhLinkman = $map['fh_linkman'];
        }
        if (isset($map['fh_lxrid'])) {
            $model->fhLxrid = $map['fh_lxrid'];
        }
        if (isset($map['fh_mode'])) {
            $model->fhMode = $map['fh_mode'];
        }
        if (isset($map['fh_msn'])) {
            $model->fhMsn = $map['fh_msn'];
        }
        if (isset($map['fh_number'])) {
            $model->fhNumber = $map['fh_number'];
        }
        if (isset($map['fh_post'])) {
            $model->fhPost = $map['fh_post'];
        }
        if (isset($map['fh_preside'])) {
            $model->fhPreside = $map['fh_preside'];
        }
        if (isset($map['fh_remark'])) {
            $model->fhRemark = $map['fh_remark'];
        }
        if (isset($map['fh_shipper'])) {
            $model->fhShipper = $map['fh_shipper'];
        }
        if (isset($map['fh_state'])) {
            $model->fhState = $map['fh_state'];
        }
        if (isset($map['fh_tel'])) {
            $model->fhTel = $map['fh_tel'];
        }
        if (isset($map['fh_title'])) {
            $model->fhTitle = $map['fh_title'];
        }
        if (isset($map['fh_yunfei'])) {
            $model->fhYunfei = $map['fh_yunfei'];
        }

        return $model;
    }
}
