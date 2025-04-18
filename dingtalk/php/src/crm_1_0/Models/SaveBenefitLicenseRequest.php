<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SaveBenefitLicenseRequest\licenses;
use AlibabaCloud\Tea\Model;

class SaveBenefitLicenseRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example B_ACCOUNT_NUMBER
     *
     * @var string
     */
    public $domain;

    /**
     * @description This parameter is required.
     *
     * @var licenses[]
     */
    public $licenses;

    /**
     * @description This parameter is required.
     *
     * @example staffId
     *
     * @var string
     */
    public $saveUserId;
    protected $_name = [
        'domain' => 'domain',
        'licenses' => 'licenses',
        'saveUserId' => 'saveUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->licenses) {
            $res['licenses'] = [];
            if (null !== $this->licenses && \is_array($this->licenses)) {
                $n = 0;
                foreach ($this->licenses as $item) {
                    $res['licenses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->saveUserId) {
            $res['saveUserId'] = $this->saveUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveBenefitLicenseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['licenses'])) {
            if (!empty($map['licenses'])) {
                $model->licenses = [];
                $n = 0;
                foreach ($map['licenses'] as $item) {
                    $model->licenses[$n++] = null !== $item ? licenses::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['saveUserId'])) {
            $model->saveUserId = $map['saveUserId'];
        }

        return $model;
    }
}
