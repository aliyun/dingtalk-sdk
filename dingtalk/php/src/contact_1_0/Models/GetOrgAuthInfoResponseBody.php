<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrgAuthInfoResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $authLevel;

    /**
     * @example xxx
     *
     * @var string
     */
    public $legalPerson;

    /**
     * @description This parameter is required.
     *
     * @example 测试有限公司
     *
     * @var string
     */
    public $licenseOrgName;

    /**
     * @example https://XXX.XX
     *
     * @var string
     */
    public $licenseUrl;

    /**
     * @description This parameter is required.
     *
     * @example 测试
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 2456677
     *
     * @var string
     */
    public $organizationCode;

    /**
     * @example 1233
     *
     * @var string
     */
    public $registrationNum;

    /**
     * @example 123566788
     *
     * @var string
     */
    public $unifiedSocialCredit;
    protected $_name = [
        'authLevel'           => 'authLevel',
        'legalPerson'         => 'legalPerson',
        'licenseOrgName'      => 'licenseOrgName',
        'licenseUrl'          => 'licenseUrl',
        'orgName'             => 'orgName',
        'organizationCode'    => 'organizationCode',
        'registrationNum'     => 'registrationNum',
        'unifiedSocialCredit' => 'unifiedSocialCredit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authLevel) {
            $res['authLevel'] = $this->authLevel;
        }
        if (null !== $this->legalPerson) {
            $res['legalPerson'] = $this->legalPerson;
        }
        if (null !== $this->licenseOrgName) {
            $res['licenseOrgName'] = $this->licenseOrgName;
        }
        if (null !== $this->licenseUrl) {
            $res['licenseUrl'] = $this->licenseUrl;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->organizationCode) {
            $res['organizationCode'] = $this->organizationCode;
        }
        if (null !== $this->registrationNum) {
            $res['registrationNum'] = $this->registrationNum;
        }
        if (null !== $this->unifiedSocialCredit) {
            $res['unifiedSocialCredit'] = $this->unifiedSocialCredit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrgAuthInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authLevel'])) {
            $model->authLevel = $map['authLevel'];
        }
        if (isset($map['legalPerson'])) {
            $model->legalPerson = $map['legalPerson'];
        }
        if (isset($map['licenseOrgName'])) {
            $model->licenseOrgName = $map['licenseOrgName'];
        }
        if (isset($map['licenseUrl'])) {
            $model->licenseUrl = $map['licenseUrl'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['organizationCode'])) {
            $model->organizationCode = $map['organizationCode'];
        }
        if (isset($map['registrationNum'])) {
            $model->registrationNum = $map['registrationNum'];
        }
        if (isset($map['unifiedSocialCredit'])) {
            $model->unifiedSocialCredit = $map['unifiedSocialCredit'];
        }

        return $model;
    }
}
