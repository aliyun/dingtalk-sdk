<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerRequest;

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
     * @description 上级客户
     *
     * @var string
     */
    public $khPkhid;

    /**
     * @description 类别（企业客户，个人客户，供应商，个人供应商）
     *
     * @var string
     */
    public $khClass;

    /**
     * @description 客户名称
     *
     * @var string
     */
    public $khName;

    /**
     * @description 性别（男，女）
     *
     * @var string
     */
    public $khSex;

    /**
     * @description 助记简称
     *
     * @var string
     */
    public $khShortname;

    /**
     * @description 行业
     *
     * @var string
     */
    public $khIndustry;

    /**
     * @description 人员规模
     *
     * @var string
     */
    public $khEmployees;

    /**
     * @description 家庭地址
     *
     * @var string
     */
    public $khAddress;

    /**
     * @description 国家地区
     *
     * @var string
     */
    public $khCountry;

    /**
     * @description 省份
     *
     * @var string
     */
    public $khProvince;

    /**
     * @description 城市
     *
     * @var string
     */
    public $khCity;

    /**
     * @description 单位地址
     *
     * @var string
     */
    public $khCoaddress;

    /**
     * @description 热点客户（是，否）
     *
     * @var string
     */
    public $khHottype;

    /**
     * @description 热度（无，低热，中热，高热）
     *
     * @var string
     */
    public $khHotlevel;

    /**
     * @description 热点分类
     *
     * @var string
     */
    public $khHotfl;

    /**
     * @description 热点说明
     *
     * @var string
     */
    public $khHotmemo;

    /**
     * @description 种类
     *
     * @var string
     */
    public $khType;

    /**
     * @description 阶段
     *
     * @var string
     */
    public $khStatus;

    /**
     * @description 编号
     *
     * @var string
     */
    public $khSn;

    /**
     * @description 手机
     *
     * @var string
     */
    public $khHandset;

    /**
     * @description 邮箱
     *
     * @var string
     */
    public $khEmail;

    /**
     * @description 钉钉号
     *
     * @var string
     */
    public $khDingtalk;

    /**
     * @description 家庭电话
     *
     * @var string
     */
    public $khTel;

    /**
     * @description 微信号
     *
     * @var string
     */
    public $khWeixin;

    /**
     * @description QQ
     *
     * @var string
     */
    public $khQq;

    /**
     * @description Skype
     *
     * @var string
     */
    public $khSkype;

    /**
     * @description 旺旺
     *
     * @var string
     */
    public $khWangwang;

    /**
     * @description 工作电话
     *
     * @var string
     */
    public $khWorktel;

    /**
     * @description 传真
     *
     * @var string
     */
    public $khFax;

    /**
     * @description 邮编
     *
     * @var string
     */
    public $khPst;

    /**
     * @description 部门
     *
     * @var string
     */
    public $khDepartment;

    /**
     * @description 称谓
     *
     * @var string
     */
    public $khAppellation;

    /**
     * @description 负责业务
     *
     * @var string
     */
    public $khPreside;

    /**
     * @description 职务
     *
     * @var string
     */
    public $khHeadship;

    /**
     * @description 网址
     *
     * @var string
     */
    public $khWeb;

    /**
     * @description 爱好
     *
     * @var string
     */
    public $khBefontof;

    /**
     * @description 来源
     *
     * @var string
     */
    public $khFrom;

    /**
     * @description 开票资料
     *
     * @var string
     */
    public $khBillinfo;

    /**
     * @description 公司简介
     *
     * @var string
     */
    public $khInfo;

    /**
     * @description 关系等级
     *
     * @var string
     */
    public $khRalagrade;

    /**
     * @description 信用等级（低，中，高）
     *
     * @var string
     */
    public $khCreditgrade;

    /**
     * @description 价值评估（低，中，高）
     *
     * @var string
     */
    public $khValrating;

    /**
     * @description 证件类型
     *
     * @var string
     */
    public $khCttype;

    /**
     * @description 证件号码
     *
     * @var string
     */
    public $khCtnumber;

    /**
     * @description 联系人分类
     *
     * @var string
     */
    public $khContype;

    /**
     * @description 备注
     *
     * @var string
     */
    public $khRemark;

    /**
     * @description 客户级别
     *
     * @var string
     */
    public $khJibie;
    protected $_name = [
        'dataUserid'    => 'data_userid',
        'khPkhid'       => 'kh_pkhid',
        'khClass'       => 'kh_class',
        'khName'        => 'kh_name',
        'khSex'         => 'kh_sex',
        'khShortname'   => 'kh_shortname',
        'khIndustry'    => 'kh_industry',
        'khEmployees'   => 'kh_employees',
        'khAddress'     => 'kh_address',
        'khCountry'     => 'kh_country',
        'khProvince'    => 'kh_province',
        'khCity'        => 'kh_city',
        'khCoaddress'   => 'kh_coaddress',
        'khHottype'     => 'kh_hottype',
        'khHotlevel'    => 'kh_hotlevel',
        'khHotfl'       => 'kh_hotfl',
        'khHotmemo'     => 'kh_hotmemo',
        'khType'        => 'kh_type',
        'khStatus'      => 'kh_status',
        'khSn'          => 'kh_sn',
        'khHandset'     => 'kh_handset',
        'khEmail'       => 'kh_email',
        'khDingtalk'    => 'kh_dingtalk',
        'khTel'         => 'kh_tel',
        'khWeixin'      => 'kh_weixin',
        'khQq'          => 'kh_qq',
        'khSkype'       => 'kh_skype',
        'khWangwang'    => 'kh_wangwang',
        'khWorktel'     => 'kh_worktel',
        'khFax'         => 'kh_fax',
        'khPst'         => 'kh_pst',
        'khDepartment'  => 'kh_department',
        'khAppellation' => 'kh_appellation',
        'khPreside'     => 'kh_preside',
        'khHeadship'    => 'kh_headship',
        'khWeb'         => 'kh_web',
        'khBefontof'    => 'kh_befontof',
        'khFrom'        => 'kh_from',
        'khBillinfo'    => 'kh_billinfo',
        'khInfo'        => 'kh_info',
        'khRalagrade'   => 'kh_ralagrade',
        'khCreditgrade' => 'kh_creditgrade',
        'khValrating'   => 'kh_valrating',
        'khCttype'      => 'kh_cttype',
        'khCtnumber'    => 'kh_ctnumber',
        'khContype'     => 'kh_contype',
        'khRemark'      => 'kh_remark',
        'khJibie'       => 'kh_jibie',
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
        if (null !== $this->khPkhid) {
            $res['kh_pkhid'] = $this->khPkhid;
        }
        if (null !== $this->khClass) {
            $res['kh_class'] = $this->khClass;
        }
        if (null !== $this->khName) {
            $res['kh_name'] = $this->khName;
        }
        if (null !== $this->khSex) {
            $res['kh_sex'] = $this->khSex;
        }
        if (null !== $this->khShortname) {
            $res['kh_shortname'] = $this->khShortname;
        }
        if (null !== $this->khIndustry) {
            $res['kh_industry'] = $this->khIndustry;
        }
        if (null !== $this->khEmployees) {
            $res['kh_employees'] = $this->khEmployees;
        }
        if (null !== $this->khAddress) {
            $res['kh_address'] = $this->khAddress;
        }
        if (null !== $this->khCountry) {
            $res['kh_country'] = $this->khCountry;
        }
        if (null !== $this->khProvince) {
            $res['kh_province'] = $this->khProvince;
        }
        if (null !== $this->khCity) {
            $res['kh_city'] = $this->khCity;
        }
        if (null !== $this->khCoaddress) {
            $res['kh_coaddress'] = $this->khCoaddress;
        }
        if (null !== $this->khHottype) {
            $res['kh_hottype'] = $this->khHottype;
        }
        if (null !== $this->khHotlevel) {
            $res['kh_hotlevel'] = $this->khHotlevel;
        }
        if (null !== $this->khHotfl) {
            $res['kh_hotfl'] = $this->khHotfl;
        }
        if (null !== $this->khHotmemo) {
            $res['kh_hotmemo'] = $this->khHotmemo;
        }
        if (null !== $this->khType) {
            $res['kh_type'] = $this->khType;
        }
        if (null !== $this->khStatus) {
            $res['kh_status'] = $this->khStatus;
        }
        if (null !== $this->khSn) {
            $res['kh_sn'] = $this->khSn;
        }
        if (null !== $this->khHandset) {
            $res['kh_handset'] = $this->khHandset;
        }
        if (null !== $this->khEmail) {
            $res['kh_email'] = $this->khEmail;
        }
        if (null !== $this->khDingtalk) {
            $res['kh_dingtalk'] = $this->khDingtalk;
        }
        if (null !== $this->khTel) {
            $res['kh_tel'] = $this->khTel;
        }
        if (null !== $this->khWeixin) {
            $res['kh_weixin'] = $this->khWeixin;
        }
        if (null !== $this->khQq) {
            $res['kh_qq'] = $this->khQq;
        }
        if (null !== $this->khSkype) {
            $res['kh_skype'] = $this->khSkype;
        }
        if (null !== $this->khWangwang) {
            $res['kh_wangwang'] = $this->khWangwang;
        }
        if (null !== $this->khWorktel) {
            $res['kh_worktel'] = $this->khWorktel;
        }
        if (null !== $this->khFax) {
            $res['kh_fax'] = $this->khFax;
        }
        if (null !== $this->khPst) {
            $res['kh_pst'] = $this->khPst;
        }
        if (null !== $this->khDepartment) {
            $res['kh_department'] = $this->khDepartment;
        }
        if (null !== $this->khAppellation) {
            $res['kh_appellation'] = $this->khAppellation;
        }
        if (null !== $this->khPreside) {
            $res['kh_preside'] = $this->khPreside;
        }
        if (null !== $this->khHeadship) {
            $res['kh_headship'] = $this->khHeadship;
        }
        if (null !== $this->khWeb) {
            $res['kh_web'] = $this->khWeb;
        }
        if (null !== $this->khBefontof) {
            $res['kh_befontof'] = $this->khBefontof;
        }
        if (null !== $this->khFrom) {
            $res['kh_from'] = $this->khFrom;
        }
        if (null !== $this->khBillinfo) {
            $res['kh_billinfo'] = $this->khBillinfo;
        }
        if (null !== $this->khInfo) {
            $res['kh_info'] = $this->khInfo;
        }
        if (null !== $this->khRalagrade) {
            $res['kh_ralagrade'] = $this->khRalagrade;
        }
        if (null !== $this->khCreditgrade) {
            $res['kh_creditgrade'] = $this->khCreditgrade;
        }
        if (null !== $this->khValrating) {
            $res['kh_valrating'] = $this->khValrating;
        }
        if (null !== $this->khCttype) {
            $res['kh_cttype'] = $this->khCttype;
        }
        if (null !== $this->khCtnumber) {
            $res['kh_ctnumber'] = $this->khCtnumber;
        }
        if (null !== $this->khContype) {
            $res['kh_contype'] = $this->khContype;
        }
        if (null !== $this->khRemark) {
            $res['kh_remark'] = $this->khRemark;
        }
        if (null !== $this->khJibie) {
            $res['kh_jibie'] = $this->khJibie;
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
        if (isset($map['kh_pkhid'])) {
            $model->khPkhid = $map['kh_pkhid'];
        }
        if (isset($map['kh_class'])) {
            $model->khClass = $map['kh_class'];
        }
        if (isset($map['kh_name'])) {
            $model->khName = $map['kh_name'];
        }
        if (isset($map['kh_sex'])) {
            $model->khSex = $map['kh_sex'];
        }
        if (isset($map['kh_shortname'])) {
            $model->khShortname = $map['kh_shortname'];
        }
        if (isset($map['kh_industry'])) {
            $model->khIndustry = $map['kh_industry'];
        }
        if (isset($map['kh_employees'])) {
            $model->khEmployees = $map['kh_employees'];
        }
        if (isset($map['kh_address'])) {
            $model->khAddress = $map['kh_address'];
        }
        if (isset($map['kh_country'])) {
            $model->khCountry = $map['kh_country'];
        }
        if (isset($map['kh_province'])) {
            $model->khProvince = $map['kh_province'];
        }
        if (isset($map['kh_city'])) {
            $model->khCity = $map['kh_city'];
        }
        if (isset($map['kh_coaddress'])) {
            $model->khCoaddress = $map['kh_coaddress'];
        }
        if (isset($map['kh_hottype'])) {
            $model->khHottype = $map['kh_hottype'];
        }
        if (isset($map['kh_hotlevel'])) {
            $model->khHotlevel = $map['kh_hotlevel'];
        }
        if (isset($map['kh_hotfl'])) {
            $model->khHotfl = $map['kh_hotfl'];
        }
        if (isset($map['kh_hotmemo'])) {
            $model->khHotmemo = $map['kh_hotmemo'];
        }
        if (isset($map['kh_type'])) {
            $model->khType = $map['kh_type'];
        }
        if (isset($map['kh_status'])) {
            $model->khStatus = $map['kh_status'];
        }
        if (isset($map['kh_sn'])) {
            $model->khSn = $map['kh_sn'];
        }
        if (isset($map['kh_handset'])) {
            $model->khHandset = $map['kh_handset'];
        }
        if (isset($map['kh_email'])) {
            $model->khEmail = $map['kh_email'];
        }
        if (isset($map['kh_dingtalk'])) {
            $model->khDingtalk = $map['kh_dingtalk'];
        }
        if (isset($map['kh_tel'])) {
            $model->khTel = $map['kh_tel'];
        }
        if (isset($map['kh_weixin'])) {
            $model->khWeixin = $map['kh_weixin'];
        }
        if (isset($map['kh_qq'])) {
            $model->khQq = $map['kh_qq'];
        }
        if (isset($map['kh_skype'])) {
            $model->khSkype = $map['kh_skype'];
        }
        if (isset($map['kh_wangwang'])) {
            $model->khWangwang = $map['kh_wangwang'];
        }
        if (isset($map['kh_worktel'])) {
            $model->khWorktel = $map['kh_worktel'];
        }
        if (isset($map['kh_fax'])) {
            $model->khFax = $map['kh_fax'];
        }
        if (isset($map['kh_pst'])) {
            $model->khPst = $map['kh_pst'];
        }
        if (isset($map['kh_department'])) {
            $model->khDepartment = $map['kh_department'];
        }
        if (isset($map['kh_appellation'])) {
            $model->khAppellation = $map['kh_appellation'];
        }
        if (isset($map['kh_preside'])) {
            $model->khPreside = $map['kh_preside'];
        }
        if (isset($map['kh_headship'])) {
            $model->khHeadship = $map['kh_headship'];
        }
        if (isset($map['kh_web'])) {
            $model->khWeb = $map['kh_web'];
        }
        if (isset($map['kh_befontof'])) {
            $model->khBefontof = $map['kh_befontof'];
        }
        if (isset($map['kh_from'])) {
            $model->khFrom = $map['kh_from'];
        }
        if (isset($map['kh_billinfo'])) {
            $model->khBillinfo = $map['kh_billinfo'];
        }
        if (isset($map['kh_info'])) {
            $model->khInfo = $map['kh_info'];
        }
        if (isset($map['kh_ralagrade'])) {
            $model->khRalagrade = $map['kh_ralagrade'];
        }
        if (isset($map['kh_creditgrade'])) {
            $model->khCreditgrade = $map['kh_creditgrade'];
        }
        if (isset($map['kh_valrating'])) {
            $model->khValrating = $map['kh_valrating'];
        }
        if (isset($map['kh_cttype'])) {
            $model->khCttype = $map['kh_cttype'];
        }
        if (isset($map['kh_ctnumber'])) {
            $model->khCtnumber = $map['kh_ctnumber'];
        }
        if (isset($map['kh_contype'])) {
            $model->khContype = $map['kh_contype'];
        }
        if (isset($map['kh_remark'])) {
            $model->khRemark = $map['kh_remark'];
        }
        if (isset($map['kh_jibie'])) {
            $model->khJibie = $map['kh_jibie'];
        }

        return $model;
    }
}
