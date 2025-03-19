<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 何一兵
     *
     * @var string
     */
    public $legalPerson;

    /**
     * @example 18667021101
     *
     * @var string
     */
    public $mobilePhoneNumber;

    /**
     * @example 杭州天谷信息科技有限公司
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 86
     *
     * @var string
     */
    public $stateCode;

    /**
     * @example 913301087458306077
     *
     * @var string
     */
    public $unifiedSocialCredit;

    /**
     * @example 某人名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'legalPerson' => 'legalPerson',
        'mobilePhoneNumber' => 'mobilePhoneNumber',
        'orgName' => 'orgName',
        'stateCode' => 'stateCode',
        'unifiedSocialCredit' => 'unifiedSocialCredit',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->legalPerson) {
            $res['legalPerson'] = $this->legalPerson;
        }
        if (null !== $this->mobilePhoneNumber) {
            $res['mobilePhoneNumber'] = $this->mobilePhoneNumber;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->unifiedSocialCredit) {
            $res['unifiedSocialCredit'] = $this->unifiedSocialCredit;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['legalPerson'])) {
            $model->legalPerson = $map['legalPerson'];
        }
        if (isset($map['mobilePhoneNumber'])) {
            $model->mobilePhoneNumber = $map['mobilePhoneNumber'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['unifiedSocialCredit'])) {
            $model->unifiedSocialCredit = $map['unifiedSocialCredit'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
