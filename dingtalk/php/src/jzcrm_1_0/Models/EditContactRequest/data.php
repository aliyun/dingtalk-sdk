<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditContactRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $dataUserid;

    /**
     * @var string
     */
    public $lxrAddress;

    /**
     * @var string
     */
    public $lxrBirthday;

    /**
     * @var string
     */
    public $lxrChengwei;

    /**
     * @var string
     */
    public $lxrCtnumber;

    /**
     * @var string
     */
    public $lxrCttype;

    /**
     * @var string
     */
    public $lxrCustomerid;

    /**
     * @var string
     */
    public $lxrDepartment;

    /**
     * @var string
     */
    public $lxrDingtalk;

    /**
     * @var string
     */
    public $lxrEmail;

    /**
     * @var string
     */
    public $lxrFax;

    /**
     * @var string
     */
    public $lxrGroup;

    /**
     * @var string
     */
    public $lxrHandset;

    /**
     * @var string
     */
    public $lxrHeadship;

    /**
     * @var string
     */
    public $lxrLike;

    /**
     * @var string
     */
    public $lxrName;

    /**
     * @var string
     */
    public $lxrPhoto;

    /**
     * @var string
     */
    public $lxrPreside;

    /**
     * @var string
     */
    public $lxrPst;

    /**
     * @var string
     */
    public $lxrQq;

    /**
     * @var string
     */
    public $lxrRemark;

    /**
     * @var string
     */
    public $lxrSex;

    /**
     * @var string
     */
    public $lxrSkype;

    /**
     * @var string
     */
    public $lxrTel;

    /**
     * @var string
     */
    public $lxrType;

    /**
     * @var string
     */
    public $lxrWangwang;

    /**
     * @var string
     */
    public $lxrWeixin;

    /**
     * @var string
     */
    public $lxrWorktel;
    protected $_name = [
        'dataUserid'    => 'data_userid',
        'lxrAddress'    => 'lxr_address',
        'lxrBirthday'   => 'lxr_birthday',
        'lxrChengwei'   => 'lxr_chengwei',
        'lxrCtnumber'   => 'lxr_ctnumber',
        'lxrCttype'     => 'lxr_cttype',
        'lxrCustomerid' => 'lxr_customerid',
        'lxrDepartment' => 'lxr_department',
        'lxrDingtalk'   => 'lxr_dingtalk',
        'lxrEmail'      => 'lxr_email',
        'lxrFax'        => 'lxr_fax',
        'lxrGroup'      => 'lxr_group',
        'lxrHandset'    => 'lxr_handset',
        'lxrHeadship'   => 'lxr_headship',
        'lxrLike'       => 'lxr_like',
        'lxrName'       => 'lxr_name',
        'lxrPhoto'      => 'lxr_photo',
        'lxrPreside'    => 'lxr_preside',
        'lxrPst'        => 'lxr_pst',
        'lxrQq'         => 'lxr_qq',
        'lxrRemark'     => 'lxr_remark',
        'lxrSex'        => 'lxr_sex',
        'lxrSkype'      => 'lxr_skype',
        'lxrTel'        => 'lxr_tel',
        'lxrType'       => 'lxr_type',
        'lxrWangwang'   => 'lxr_wangwang',
        'lxrWeixin'     => 'lxr_weixin',
        'lxrWorktel'    => 'lxr_worktel',
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
        if (null !== $this->lxrAddress) {
            $res['lxr_address'] = $this->lxrAddress;
        }
        if (null !== $this->lxrBirthday) {
            $res['lxr_birthday'] = $this->lxrBirthday;
        }
        if (null !== $this->lxrChengwei) {
            $res['lxr_chengwei'] = $this->lxrChengwei;
        }
        if (null !== $this->lxrCtnumber) {
            $res['lxr_ctnumber'] = $this->lxrCtnumber;
        }
        if (null !== $this->lxrCttype) {
            $res['lxr_cttype'] = $this->lxrCttype;
        }
        if (null !== $this->lxrCustomerid) {
            $res['lxr_customerid'] = $this->lxrCustomerid;
        }
        if (null !== $this->lxrDepartment) {
            $res['lxr_department'] = $this->lxrDepartment;
        }
        if (null !== $this->lxrDingtalk) {
            $res['lxr_dingtalk'] = $this->lxrDingtalk;
        }
        if (null !== $this->lxrEmail) {
            $res['lxr_email'] = $this->lxrEmail;
        }
        if (null !== $this->lxrFax) {
            $res['lxr_fax'] = $this->lxrFax;
        }
        if (null !== $this->lxrGroup) {
            $res['lxr_group'] = $this->lxrGroup;
        }
        if (null !== $this->lxrHandset) {
            $res['lxr_handset'] = $this->lxrHandset;
        }
        if (null !== $this->lxrHeadship) {
            $res['lxr_headship'] = $this->lxrHeadship;
        }
        if (null !== $this->lxrLike) {
            $res['lxr_like'] = $this->lxrLike;
        }
        if (null !== $this->lxrName) {
            $res['lxr_name'] = $this->lxrName;
        }
        if (null !== $this->lxrPhoto) {
            $res['lxr_photo'] = $this->lxrPhoto;
        }
        if (null !== $this->lxrPreside) {
            $res['lxr_preside'] = $this->lxrPreside;
        }
        if (null !== $this->lxrPst) {
            $res['lxr_pst'] = $this->lxrPst;
        }
        if (null !== $this->lxrQq) {
            $res['lxr_qq'] = $this->lxrQq;
        }
        if (null !== $this->lxrRemark) {
            $res['lxr_remark'] = $this->lxrRemark;
        }
        if (null !== $this->lxrSex) {
            $res['lxr_sex'] = $this->lxrSex;
        }
        if (null !== $this->lxrSkype) {
            $res['lxr_skype'] = $this->lxrSkype;
        }
        if (null !== $this->lxrTel) {
            $res['lxr_tel'] = $this->lxrTel;
        }
        if (null !== $this->lxrType) {
            $res['lxr_type'] = $this->lxrType;
        }
        if (null !== $this->lxrWangwang) {
            $res['lxr_wangwang'] = $this->lxrWangwang;
        }
        if (null !== $this->lxrWeixin) {
            $res['lxr_weixin'] = $this->lxrWeixin;
        }
        if (null !== $this->lxrWorktel) {
            $res['lxr_worktel'] = $this->lxrWorktel;
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
        if (isset($map['lxr_address'])) {
            $model->lxrAddress = $map['lxr_address'];
        }
        if (isset($map['lxr_birthday'])) {
            $model->lxrBirthday = $map['lxr_birthday'];
        }
        if (isset($map['lxr_chengwei'])) {
            $model->lxrChengwei = $map['lxr_chengwei'];
        }
        if (isset($map['lxr_ctnumber'])) {
            $model->lxrCtnumber = $map['lxr_ctnumber'];
        }
        if (isset($map['lxr_cttype'])) {
            $model->lxrCttype = $map['lxr_cttype'];
        }
        if (isset($map['lxr_customerid'])) {
            $model->lxrCustomerid = $map['lxr_customerid'];
        }
        if (isset($map['lxr_department'])) {
            $model->lxrDepartment = $map['lxr_department'];
        }
        if (isset($map['lxr_dingtalk'])) {
            $model->lxrDingtalk = $map['lxr_dingtalk'];
        }
        if (isset($map['lxr_email'])) {
            $model->lxrEmail = $map['lxr_email'];
        }
        if (isset($map['lxr_fax'])) {
            $model->lxrFax = $map['lxr_fax'];
        }
        if (isset($map['lxr_group'])) {
            $model->lxrGroup = $map['lxr_group'];
        }
        if (isset($map['lxr_handset'])) {
            $model->lxrHandset = $map['lxr_handset'];
        }
        if (isset($map['lxr_headship'])) {
            $model->lxrHeadship = $map['lxr_headship'];
        }
        if (isset($map['lxr_like'])) {
            $model->lxrLike = $map['lxr_like'];
        }
        if (isset($map['lxr_name'])) {
            $model->lxrName = $map['lxr_name'];
        }
        if (isset($map['lxr_photo'])) {
            $model->lxrPhoto = $map['lxr_photo'];
        }
        if (isset($map['lxr_preside'])) {
            $model->lxrPreside = $map['lxr_preside'];
        }
        if (isset($map['lxr_pst'])) {
            $model->lxrPst = $map['lxr_pst'];
        }
        if (isset($map['lxr_qq'])) {
            $model->lxrQq = $map['lxr_qq'];
        }
        if (isset($map['lxr_remark'])) {
            $model->lxrRemark = $map['lxr_remark'];
        }
        if (isset($map['lxr_sex'])) {
            $model->lxrSex = $map['lxr_sex'];
        }
        if (isset($map['lxr_skype'])) {
            $model->lxrSkype = $map['lxr_skype'];
        }
        if (isset($map['lxr_tel'])) {
            $model->lxrTel = $map['lxr_tel'];
        }
        if (isset($map['lxr_type'])) {
            $model->lxrType = $map['lxr_type'];
        }
        if (isset($map['lxr_wangwang'])) {
            $model->lxrWangwang = $map['lxr_wangwang'];
        }
        if (isset($map['lxr_weixin'])) {
            $model->lxrWeixin = $map['lxr_weixin'];
        }
        if (isset($map['lxr_worktel'])) {
            $model->lxrWorktel = $map['lxr_worktel'];
        }

        return $model;
    }
}
