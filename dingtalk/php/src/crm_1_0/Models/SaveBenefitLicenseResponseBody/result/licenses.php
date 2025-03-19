<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SaveBenefitLicenseResponseBody\result;

use AlibabaCloud\Tea\Model;

class licenses extends Model
{
    /**
     * @example license账号信息
     *
     * @var string
     */
    public $licenseUserId;
    protected $_name = [
        'licenseUserId' => 'licenseUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->licenseUserId) {
            $res['licenseUserId'] = $this->licenseUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return licenses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['licenseUserId'])) {
            $model->licenseUserId = $map['licenseUserId'];
        }

        return $model;
    }
}
