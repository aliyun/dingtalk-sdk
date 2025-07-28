<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListBenefitLicenseRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $domains;
    protected $_name = [
        'domains' => 'domains',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->domains) {
            $res['domains'] = $this->domains;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListBenefitLicenseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domains'])) {
            if (!empty($map['domains'])) {
                $model->domains = $map['domains'];
            }
        }

        return $model;
    }
}
