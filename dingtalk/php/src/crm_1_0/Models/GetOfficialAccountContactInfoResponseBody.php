<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountContactInfoResponseBody extends Model
{
    /**
     * @description 联系人主企业名称
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 手机号国家码
     *
     * @var string
     */
    public $stateCode;
    protected $_name = [
        'corpName'  => 'corpName',
        'mobile'    => 'mobile',
        'stateCode' => 'stateCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountContactInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }

        return $model;
    }
}
