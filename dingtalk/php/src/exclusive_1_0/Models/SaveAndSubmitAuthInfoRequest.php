<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveAndSubmitAuthInfoRequest extends Model
{
    /**
     * @example XXX组织申请高级认证
     *
     * @var string
     */
    public $applyRemark;

    /**
     * @example @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
     *
     * @var string
     */
    public $authorizeMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 计算机
     *
     * @var string
     */
    public $industry;

    /**
     * @description This parameter is required.
     *
     * @example 钉三多
     *
     * @var string
     */
    public $legalPerson;

    /**
     * @description This parameter is required.
     *
     * @example 3301XX1997XXXXXXXXX
     *
     * @var string
     */
    public $legalPersonIdCard;

    /**
     * @example @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
     *
     * @var string
     */
    public $licenseMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 330100
     *
     * @var int
     */
    public $locCity;

    /**
     * @description This parameter is required.
     *
     * @example 杭州
     *
     * @var string
     */
    public $locCityName;

    /**
     * @description This parameter is required.
     *
     * @example 330000
     *
     * @var int
     */
    public $locProvince;

    /**
     * @description This parameter is required.
     *
     * @example 浙江
     *
     * @var string
     */
    public $locProvinceName;

    /**
     * @description This parameter is required.
     *
     * @example 15869110714
     *
     * @var string
     */
    public $mobileNum;

    /**
     * @description This parameter is required.
     *
     * @example 测试组织
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 11111111-1
     *
     * @var string
     */
    public $organizationCode;

    /**
     * @example @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
     *
     * @var string
     */
    public $organizationCodeMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 余杭区文一西路XX号
     *
     * @var string
     */
    public $registLocation;

    /**
     * @example 1111111111111111
     *
     * @var string
     */
    public $registNum;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @example 9111111XX2957XX4X
     *
     * @var string
     */
    public $unifiedSocialCredit;
    protected $_name = [
        'applyRemark'             => 'applyRemark',
        'authorizeMediaId'        => 'authorizeMediaId',
        'industry'                => 'industry',
        'legalPerson'             => 'legalPerson',
        'legalPersonIdCard'       => 'legalPersonIdCard',
        'licenseMediaId'          => 'licenseMediaId',
        'locCity'                 => 'locCity',
        'locCityName'             => 'locCityName',
        'locProvince'             => 'locProvince',
        'locProvinceName'         => 'locProvinceName',
        'mobileNum'               => 'mobileNum',
        'orgName'                 => 'orgName',
        'organizationCode'        => 'organizationCode',
        'organizationCodeMediaId' => 'organizationCodeMediaId',
        'registLocation'          => 'registLocation',
        'registNum'               => 'registNum',
        'targetCorpId'            => 'targetCorpId',
        'unifiedSocialCredit'     => 'unifiedSocialCredit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyRemark) {
            $res['applyRemark'] = $this->applyRemark;
        }
        if (null !== $this->authorizeMediaId) {
            $res['authorizeMediaId'] = $this->authorizeMediaId;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->legalPerson) {
            $res['legalPerson'] = $this->legalPerson;
        }
        if (null !== $this->legalPersonIdCard) {
            $res['legalPersonIdCard'] = $this->legalPersonIdCard;
        }
        if (null !== $this->licenseMediaId) {
            $res['licenseMediaId'] = $this->licenseMediaId;
        }
        if (null !== $this->locCity) {
            $res['locCity'] = $this->locCity;
        }
        if (null !== $this->locCityName) {
            $res['locCityName'] = $this->locCityName;
        }
        if (null !== $this->locProvince) {
            $res['locProvince'] = $this->locProvince;
        }
        if (null !== $this->locProvinceName) {
            $res['locProvinceName'] = $this->locProvinceName;
        }
        if (null !== $this->mobileNum) {
            $res['mobileNum'] = $this->mobileNum;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->organizationCode) {
            $res['organizationCode'] = $this->organizationCode;
        }
        if (null !== $this->organizationCodeMediaId) {
            $res['organizationCodeMediaId'] = $this->organizationCodeMediaId;
        }
        if (null !== $this->registLocation) {
            $res['registLocation'] = $this->registLocation;
        }
        if (null !== $this->registNum) {
            $res['registNum'] = $this->registNum;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->unifiedSocialCredit) {
            $res['unifiedSocialCredit'] = $this->unifiedSocialCredit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveAndSubmitAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyRemark'])) {
            $model->applyRemark = $map['applyRemark'];
        }
        if (isset($map['authorizeMediaId'])) {
            $model->authorizeMediaId = $map['authorizeMediaId'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['legalPerson'])) {
            $model->legalPerson = $map['legalPerson'];
        }
        if (isset($map['legalPersonIdCard'])) {
            $model->legalPersonIdCard = $map['legalPersonIdCard'];
        }
        if (isset($map['licenseMediaId'])) {
            $model->licenseMediaId = $map['licenseMediaId'];
        }
        if (isset($map['locCity'])) {
            $model->locCity = $map['locCity'];
        }
        if (isset($map['locCityName'])) {
            $model->locCityName = $map['locCityName'];
        }
        if (isset($map['locProvince'])) {
            $model->locProvince = $map['locProvince'];
        }
        if (isset($map['locProvinceName'])) {
            $model->locProvinceName = $map['locProvinceName'];
        }
        if (isset($map['mobileNum'])) {
            $model->mobileNum = $map['mobileNum'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['organizationCode'])) {
            $model->organizationCode = $map['organizationCode'];
        }
        if (isset($map['organizationCodeMediaId'])) {
            $model->organizationCodeMediaId = $map['organizationCodeMediaId'];
        }
        if (isset($map['registLocation'])) {
            $model->registLocation = $map['registLocation'];
        }
        if (isset($map['registNum'])) {
            $model->registNum = $map['registNum'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['unifiedSocialCredit'])) {
            $model->unifiedSocialCredit = $map['unifiedSocialCredit'];
        }

        return $model;
    }
}
