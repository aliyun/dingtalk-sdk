<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class contactInfo extends Model
{
    /**
     * @description 联系人姓名
     *
     * @var string
     */
    public $contactName;

    /**
     * @description 联系人手机号
     *
     * @var string
     */
    public $mobile;
    protected $_name = [
        'contactName' => 'contactName',
        'mobile'      => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactName) {
            $res['contactName'] = $this->contactName;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contactInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactName'])) {
            $model->contactName = $map['contactName'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }

        return $model;
    }
}
